using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace chat_client
{
	public partial class fLogin : Form
	{

		public fLogin()
		{
			InitializeComponent();

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

		private void btnRegister_Click(object sender, EventArgs e)
		{
			Client cl = new Client();
			cl = null;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			fHome home = new fHome();
			home.Show();
			this.Hide();
		}
	}
}
