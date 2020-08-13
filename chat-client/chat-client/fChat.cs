using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_client
{
	public partial class fChat : Form
	{
		public Thread clientThread = null;
		public const int bytelen = 1024 * 5000;
		public fChat()
		{
			InitializeComponent();
			//CheckForIllegalCrossThreadCalls = false;
			//clientThread = new Thread(listenServer)
			//{
			//	IsBackground = true
			//};
			//clientThread.Start();
		}

		private void fChat_Load(object sender, EventArgs e)
		{
			txtNameUser.Text = Program.username;
			listUser.Items.Add("List online user: ");
			listUser.Items.Add("Loading...");
			CheckForIllegalCrossThreadCalls = false;
			clientThread = new Thread(listenServer)
			{
				IsBackground = true
			};
			clientThread.Start();
		}

		public void listenServer()
		{
			try
			{
				while (true)
				{
					NetworkStream ns = new NetworkStream(Program.con.clientSocket);
					byte[] recData = new byte[bytelen];
					int recv;
					string strData = "";
					recv = ns.Read(recData, 0, recData.Length);
					if (recv > 0)
					{
						strData = Program.han.Deseriliaze(recData).ToString();
						string cod = strData.Substring(0, 5);
						string msg = strData.Substring(5);
						if (cod == "addus")
						{
							//txtListUsername.AppendText(msg);
							listUser.Items.Clear();
							listUser.Items.Add("List online user: ");
							string[] strUser = msg.Split(',');
							foreach (string user in strUser)
							{
								listUser.Items.Add(user);
							}
						}
						if (cod == "outok")
						{
						}
						if (cod == "msgok")
						{
							listChat.Items.Add(msg);
						}
						if (cod == "filok")
						{
							string username = msg.Split('|')[0];
							string fileName = msg.Split('|')[1];
							//Lấy đường dẫn mặc định
							string currentPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
							string pathFolder = currentPath + $"\\{Program.username}Files";
							string pathFile = pathFolder + "\\" + fileName;
							//Nếu không tồn tại thư mục
							if (!Directory.Exists(pathFolder))
							{
								//Tạo mới
								DirectoryInfo di = Directory.CreateDirectory(pathFolder);
							}
							//Nếu tồn tại file cũ
							if (File.Exists(pathFile))
							{
								//Xóa file cũ
								File.Delete(pathFile);
							}

							//Nhận file
							recv = ns.Read(recData, 0, recData.Length);
							FileStream fs = File.Create(pathFile);
							fs.Write(recData, 0, recv);
							fs.Close();

							//Ghi vào bảng file của chat
							ListViewItem item = new ListViewItem();
							item.Text = username;
							item.SubItems.Add(fileName);
							listFiles.Items.Add(item);
							MessageBox.Show($"You have just recived a file.\nCheck in {pathFile}");
						}
					}
					ns.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ex: " + ex.Message);
				clientThread = new Thread(listenServer)
				{
					IsBackground = true
				};
				clientThread.Start();
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (txtMsg.Text != "")
			{
				Program.han.sendData("msg" + txtMsg.Text);
				Program.han.sendData(Program.username);
				txtMsg.Text = "";
			}
		}


		private void btnAddFile_Click(object sender, EventArgs e)
		{
			if (File.Exists(txtFilePath.Text))
			{
				try
				{
					string[] strDetail = txtFilePath.Text.Split('\\');
					string fileName = strDetail[strDetail.Length - 1];
					Program.han.sendData("fil" + Program.username + "|" + fileName);
					byte[] data = File.ReadAllBytes(txtFilePath.Text);
					Program.con.clientSocket.Send(data);
				}
				catch (Exception ex)
				{
					MessageBox.Show("ERROR:" + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("File does not exist.");
			}
		}

		private void btnOpenFolder_Click(object sender, EventArgs e)
		{
			string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
			Process.Start($"{path}\\{Program.username}Files");
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
			Program.con.clientSocket.Send(Program.han.Serialize("out" + Program.username));
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "LOGIN")
				{
					f.Close();
				}
			}
			this.Close();
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void txtFilePath_Enter(object sender, EventArgs e)
		{
			if (txtFilePath.Text == "enter file path")
			{
				txtFilePath.Text = "";
				txtFilePath.ForeColor = Color.Black;
			}
		}

		private void txtFilePath_Leave(object sender, EventArgs e)
		{
			if (txtFilePath.Text == "")
			{
				txtFilePath.Text = "enter file path";
				txtFilePath.ForeColor = Color.Gray;
			}
		}
	}
}
