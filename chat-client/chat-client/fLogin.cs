using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace chat_client
{
	public partial class fLogin : Form
	{
		//Tạo thread lắng nghe server
		public Thread clientThread = null;

		public fLogin()
		{
			InitializeComponent();
			//CheckForIllegalCrossThreadCalls = false;
			//clientThread = new Thread(listenServer)
			//{
			//	IsBackground = true
			//};
			//clientThread.Start();
		}

		public void fLogin_Load(object sender, EventArgs e)
		{
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
					byte[] recData = new byte[1024];
					int recv;
					string strData = "";
					recv = ns.Read(recData, 0, recData.Length);
					if (recv > 0)
					{
						strData = Program.han.Deseriliaze(recData).ToString();
						string cod = strData.Substring(0, 5);
						string msg = strData.Substring(5);
						if (cod == "logok")
						{
							this.Hide();
							Application.Run(new fChat());
						}
						if (cod == "lfail")
						{
							Program.username = null;
							Program.password = null;
							MessageBox.Show("Username or password is invalid || Account was logged in.");
						}
						if (cod == "regok")
						{
							MessageBox.Show("Success!!!");
						}
					}
					ns.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ex: " + ex.Message);
			}
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			fRegister f = new fRegister();
			f.ShowDialog();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			if (username != "" && password != "")
			{
				Program.username = username;
				Program.password = password;
				login(username, password);
				txtUsername.Text = "";
				txtPassword.Text = "";
				txtUsername.Focus();
			}
		}

		public void login(string username, string password)
		{
			Program.han.sendData("log" + username);
			Program.han.sendData(password);
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
			Program.con.clientSocket.Close();
			this.Close();
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSubmit_Click(sender, new EventArgs());
			}
		}
	}
}
