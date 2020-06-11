using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_client
{
	public partial class fHome : Form
	{
		public fHome()
		{
			InitializeComponent();
		}

		//Text code and name effect
		private void txtCode_Enter(object sender, EventArgs e)
		{
			if (txtCode.Text == "Enter a code to join a room")
			{
				txtCode.Text = "";
				txtCode.ForeColor = Color.Black;
			}
		}

		private void txtCode_Leave(object sender, EventArgs e)
		{
			if (txtCode.Text == "")
			{
				txtCode.Text = "Enter a code to join a room";
				txtCode.ForeColor = Color.Silver;
			}
		}

		private void txtName_Enter(object sender, EventArgs e)
		{
			if (txtName.Text == "Enter a name to create a room")
			{
				txtName.Text = "";
				txtName.ForeColor = Color.Black;
			}
		}

		private void txtName_Leave(object sender, EventArgs e)
		{
			if (txtName.Text == "")
			{
				txtName.Text = "Enter a name to create a room";
				txtName.ForeColor = Color.Silver;
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
			fLogin login = new fLogin();
			login.Close();
			this.Close();
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}


		private void btnSignOut_Click(object sender, EventArgs e)
		{
			fLogin login = new fLogin();
			login.Show();
			this.Close();
		}
	}
}
