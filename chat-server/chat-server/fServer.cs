using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace chat_server
{
	public partial class fServer : Form
	{
		public const int bytelen = 1024 * 5000;

		//List client
		private static List<Socket> listClient = new List<Socket>();
		private static List<string> listUsername = new List<string>();

		//Tạo endpoint
		private static IPEndPoint ep;
		//Tạo socket server
		private static Socket serverSocket;
		//Socket client
		private static Socket clientSocket;
		//Thread lắng nghe
		private static Thread serverThread;
		//Thread nhận msg từ client
		private static Thread clientThread;

		//Khởi tạo kết nối database
		public string dbHost;
		public string dbName;
		public string dbUsername;
		public string dbPassword;
		public string conStr;
		public MySqlConnection con;

		public fServer()
		{
			InitializeComponent();
		}

		private void fServer_Load(object sender, EventArgs e)
		{
			txtStatus.AppendText("Setting up Server ...\n");

			//Open Database			
			connectDatabase();
			txtStatus.AppendText("Database connected!\n");
			try
			{
				con.Open();
				txtStatus.AppendText("Database is openning...\n");
			}
			catch (Exception ex)
			{
				txtStatus.AppendText("ERROR: " + ex.Message + "\n");
			}

			//Server Thread
			CheckForIllegalCrossThreadCalls = false;
			serverThread = new Thread(proceedServer);
			try
			{
				serverThread.IsBackground = true;
				serverThread.Start();
			}
			catch (Exception ex)
			{
				txtStatus.AppendText("ERROR: " + ex.Message + "\n");
			}
		}

		private void connectDatabase()
		{
			txtStatus.AppendText("Connecting database ...\n");
			dbHost = "localhost";
			dbName = "chat_app_wfrm";
			dbUsername = "root";
			dbPassword = "1302";
			conStr =
				"SERVER=" + dbHost +
				";DATABASE=" + dbName +
				";uid=" + dbUsername +
				";pwd=" + dbPassword + ";";
			con = new MySqlConnection(conStr);
		}

		private void proceedServer()
		{
			//Tạo socket
			serverSocket = new Socket(
				AddressFamily.InterNetwork,
				SocketType.Stream,
				ProtocolType.Tcp);
			//Tạo endpoint
			ep = new IPEndPoint(IPAddress.Any, 1302);
			//Liên kết cổng sk với endpoint
			serverSocket.Bind(ep);
			txtStatus.AppendText("Server is already running ...\n");
			//Lắng nghe kết nối với hàng đợi tối đa 100
			serverSocket.Listen(100);
			txtStatus.AppendText("Server is listening ...\n");
			while (true)
			{
				try
				{
					//Đồng ý client kết nối
					clientSocket = serverSocket.Accept();
					//Thêm socket của client vào danh sách listClient
					listClient.Add(clientSocket);
					//Thêm username (chưa đăng nhập là khoảng trống)
					listUsername.Add(" ");
					txtStatus.AppendText($"{listClient.Count} client connected!\n");
					//Mỗi client đăng nhập tạo một thread lắng nghe yêu cầu riêng
					clientThread = new Thread(proceedThread);
					clientThread.Start(clientSocket);
				}
				catch (Exception ex)
				{
					//Trường hợp 1 client thoát, tạo lại kết nối
					ep = new IPEndPoint(IPAddress.Any, 1302);
					serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
					txtStatus.AppendText("ERROR: " + ex.Message + "\n");
				}
			}
		}

		private void proceedThread(object state)
		{
			Socket acceptedClientSocket = (Socket)state;
			try
			{
				// Recive data
				while (true)
				{
					byte[] recData = new byte[bytelen];
					string strData = "";
					//Nhận dữ liệu dạng byte
					acceptedClientSocket.Receive(recData);
					//Chuyển dữ liệu sang string
					strData = Deseriliaze(recData).ToString();
					if (strData != String.Empty)
					{
						string cod = strData.Substring(0, 3);
						string msg = strData.Substring(3);
						switch (cod)
						{
							case "log":
								login(msg, acceptedClientSocket);
								break;
							case "out":
								logout(msg, acceptedClientSocket);
								break;
							case "reg":
								register(msg, acceptedClientSocket);
								break;
							case "msg":
								acceptedClientSocket.Receive(recData);
								strData = Deseriliaze(recData).ToString();
								sendMessage(msg, strData);
								break;
							case "fil":
								//Lấy tên người gửi và tên file
								string[] recStr = msg.Split('|');
								string username = recStr[0];
								string fileName = recStr[1];
								txtStatus.AppendText($"{username} sending a file\n");

								byte[] fileData = new byte[bytelen];
								//Nhận file
								acceptedClientSocket.Receive(fileData);
								txtStatus.AppendText($"Server received {fileName} form {username}\n");
								//Gửi lại cho tất cả client
								sendFile(fileData, username, fileName);
								txtStatus.AppendText($"{username} sent\n{Encoding.UTF8.GetString(fileData)}\n");
								break;
						}
					}
					strData = String.Empty;
				}
			}
			catch (Exception ex)
			{
				int index = listClient.IndexOf(acceptedClientSocket);
				if (listUsername[index] != " ")
				{
					listClient.RemoveAt(index);
					exit(listUsername[index], index);
				}
				else
				{
					listClient.RemoveAt(index);
					listUsername.RemoveAt(index);
				}
				txtStatus.AppendText($"ERROR: {ex.Message}\n");
				txtStatus.AppendText("A client DISconnected\n");
				acceptedClientSocket.Close();
				Thread.CurrentThread.Abort();
			}
		}

		void login(string msg, Socket aS)
		{
			string username = msg;
			//Nhận thêm dữ liệu là password
			byte[] recData = new byte[bytelen];
			aS.Receive(recData);
			string password = Deseriliaze(recData).ToString();

			//Truy vấn database
			string qry = $"SELECT COUNT(*) FROM tbl_user " +
				$"WHERE user_name='{username}' " +
				$"AND password='{password}'" +
				$"AND active=0;";
			MySqlCommand cmd = new MySqlCommand(qry, con);
			txtStatus.AppendText(qry + "\n");

			//Nhận phản hồi từ database
			object result = cmd.ExecuteScalar();
			txtStatus.AppendText(result.ToString() + " \n");

			//Kết quả 1 là thành công và !=1 là thất bại
			if (result.ToString() == "1")
			{
				//Truy vấn database, sửa đổi field active của tbl_user từ 0 thành 1
				qry = $"UPDATE tbl_user SET active=1 WHERE user_name='{username}';";
				MySqlCommand subCMD = new MySqlCommand(qry, con);
				subCMD.ExecuteNonQuery();
				txtStatus.AppendText($"{username} logged in!\n");

				//Gửi lại tín hiệu cho client đăng nhập thành công
				aS.Send(Serialize("logok"));
				//Thêm username vào list usernmae với socket tương ứng
				listUsername[listClient.IndexOf(aS)] = username;
				Thread.Sleep(1500);
				//Xuất danh sách online now
				txtStatus.AppendText($"Online now: ");
				string strUsername = "";
				foreach (string c in listUsername)
				{
					if (c != " ")
					{
						strUsername = strUsername + "," + c;
					}
				}
				//Gửi lại danh sách user đang online
				txtStatus.AppendText($"{strUsername}\n");
				foreach (Socket sk in listClient)
				{
					if (sk != null)
					{
						sk.Send(Serialize("addus" + strUsername));
					}
				}
			}
			else
			{
				//Gửi tín hiệu thất bại nếu không đăng nhập thành công
				txtStatus.AppendText($"{username} logged fail!\n");
				aS.Send(Serialize("lfail"));
			}
		}

		void logout(string msg, Socket aS)
		{
			string username = msg;
			//Truy vấn đến database để đăng xuất
			string qry = $"UPDATE tbl_user " +
				$"SET active = 0 " +
				$"WHERE user_name='{username}' ;";
			MySqlCommand cmd = new MySqlCommand(qry, con);
			txtStatus.AppendText(qry + "\n");
			cmd.ExecuteNonQuery();
			txtStatus.AppendText($"{username} logged out!\n");
			//Xóa username với client tương ứng
			listUsername[listClient.FindIndex(s => s == aS)] = " ";
			txtStatus.AppendText($"Online now: ");
			string strUsername = "";
			foreach (string c in listUsername)
			{
				if (c != " ")
				{
					strUsername = strUsername + "," + c;
				}
			}
			txtStatus.AppendText($"{strUsername}\n");
			//Cập nhất lại danh sách online cho client
			foreach (Socket sk in listClient)
			{
				if (sk != null)
				{
					sk.Send(Serialize("addus" + strUsername));
				}
			}
			//Gửi tín hiệu đăng xuất thành công
			aS.Send(Serialize("outok"));
		}

		void register(string msg, Socket aS)
		{
			string username = msg;
			byte[] recData = new byte[bytelen];
			aS.Receive(recData);
			string password = Deseriliaze(recData).ToString();
			string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
			string qry = $"INSERT INTO tbl_user (user_name, password,  create_at) " +
				$"VALUES ('{username}', '{password}', '{time}');";
			MySqlCommand cmd = new MySqlCommand(qry, con);
			txtStatus.AppendText(qry + "\n");
			cmd.ExecuteNonQuery();
			txtStatus.AppendText($"{username} registed!\n");
			aS.Send(Serialize("regok"));
		}

		void sendMessage(string msg, string username)
		{
			foreach (Socket sk in listClient)
			{
				sk.Send(Serialize("msgok" + username + ": " + msg));
			}
		}

		void sendFile(byte[] file, string username, string fileName)
		{
			foreach (Socket sk in listClient)
			{
				sk.Send(Serialize("filok" + username + "|" + fileName));
				sk.Send(file);
			}
		}

		void exit(string username, int index)
		{
			string qry = $"UPDATE tbl_user " +
				$"SET active = 0 " +
				$"WHERE user_name='{username}' ;";
			MySqlCommand cmd = new MySqlCommand(qry, con);
			txtStatus.AppendText(qry + "\n");
			cmd.ExecuteNonQuery();
			listUsername.RemoveAt(index);
			txtStatus.AppendText($"Online now: ");
			string strUsername = "";
			foreach (Socket sk in listClient)
			{
				if (sk != null)
				{
					sk.Send(Serialize("addus" + strUsername));
				}
			}
		}

		public byte[] Serialize(object obj)
		{
			//khởi tạo stream để lưu các byte phân mảnh
			MemoryStream stream = new MemoryStream();
			//khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
			BinaryFormatter formatter = new BinaryFormatter();
			//phân mảnh rồi ghi vào stream
			formatter.Serialize(stream, obj);
			//từ stream chuyển các các byte thành dãy rồi cbi gửi đi
			return stream.ToArray();
		}

		//Hàm gom mảnh các byte nhận được rồi chuyển sang kiểu string
		public object Deseriliaze(byte[] data)
		{
			//khởi tạo stream đọc kết quả của quá trình phân mảnh 
			MemoryStream stream = new MemoryStream(data);
			//khởi tạo đối tượng chuyển đổi
			BinaryFormatter formatter = new BinaryFormatter();
			//chuyển đổi dữ liệu và lưu lại kết quả 
			return (string)formatter.Deserialize(stream);
		}

		//Move winform
		private int mov;
		private int movX;
		private int movY;

		private void pnHeader_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}

		private void pnHeader_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
			}
		}

		private void pnHeader_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			serverSocket.Close();
			clientSocket.Close();
			con.Close();
			this.Close();
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
