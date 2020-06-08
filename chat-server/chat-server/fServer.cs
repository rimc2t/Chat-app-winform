using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace chat_server
{
	public partial class fServer : Form
	{
		//Tạo socket
		private Socket serverSocket = new Socket(
			AddressFamily.InterNetwork,
			SocketType.Stream,
			ProtocolType.Tcp);
		//Tạo endpoint
		private IPEndPoint ep = new IPEndPoint(IPAddress.Any, 1302);

		//Khởi tạo kết nối database
		string dbHost;
		string dbName;
		string dbUsername;
		string dbPassword;
		string conStr;
		MySqlConnection con;

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
			Thread serverThread = new Thread(proceedServer);
			try
			{
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
			//Liên kết cổng sk với endpoint
			serverSocket.Bind(ep);
			txtStatus.AppendText("Server is already running ...\n");
			//Lắng nghe kết nối với hàng đợi tối đa 10
			serverSocket.Listen(100);
			txtStatus.AppendText("Server is listening ...\n");
			while (true)
			{
				try
				{
					Socket clientSocket = serverSocket.Accept();
					Thread clientThread = new Thread(proceedThread);
					clientThread.Start(clientSocket);
				}
				catch (Exception ex)
				{
					txtStatus.AppendText("ERROR: " + ex.Message + "\n");
					break;
				}
			}
		}

		private void proceedThread(object state)
		{
			Socket acceptedClientSocket = (Socket)state;
			txtStatus.AppendText("A client connected!\n");
			try
			{
				while (true)
				{
					byte[] recData = new byte[1024];
					string strData = "";
					acceptedClientSocket.Receive(recData);
					strData = Encoding.UTF8.GetString(recData);
				}
			}
			catch(Exception ex)
			{
				txtStatus.AppendText("ERROR: " + ex.Message + "\n");
				acceptedClientSocket.Close();
				Thread.CurrentThread.Abort();
			}
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
			con.Close();
			this.Close();
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
