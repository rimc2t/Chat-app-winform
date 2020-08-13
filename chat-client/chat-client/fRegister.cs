using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_client
{
	public partial class fRegister : Form
	{
		public fRegister()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			string confirmPassword = txtConfirmPassword.Text;
			if (username != "" && password != "" && confirmPassword != "" && confirmPassword == password)
			{
				register(username, password);
				txtUsername.Text = "";
				txtPassword.Text = "";
				txtConfirmPassword.Text = "";
				txtUsername.Focus();
			}
			else
			{
				MessageBox.Show("Enter somthing wrong. Please try again!");
			}
		}

		public void register(string username, string password)
		{
			byte[] u = new byte[1024];
			u = Program.han.Serialize("reg" + username);
			Program.con.clientSocket.Send(u);
			u = Program.han.Serialize(password);
			Program.con.clientSocket.Send(u);
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
			this.Close();
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
