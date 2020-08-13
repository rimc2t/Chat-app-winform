namespace chat_client
{
	partial class fRegister
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnHide = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnHeader = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.pnHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnHide
			// 
			this.btnHide.BackColor = System.Drawing.Color.White;
			this.btnHide.ForeColor = System.Drawing.Color.Black;
			this.btnHide.Location = new System.Drawing.Point(211, 0);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(45, 45);
			this.btnHide.TabIndex = 14;
			this.btnHide.Text = "__";
			this.btnHide.UseVisualStyleBackColor = false;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Brown;
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(256, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(45, 45);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pnHeader
			// 
			this.pnHeader.BackColor = System.Drawing.Color.DarkSlateGray;
			this.pnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pnHeader.Controls.Add(this.label1);
			this.pnHeader.ForeColor = System.Drawing.Color.White;
			this.pnHeader.Location = new System.Drawing.Point(0, 0);
			this.pnHeader.Name = "pnHeader";
			this.pnHeader.Size = new System.Drawing.Size(300, 45);
			this.pnHeader.TabIndex = 12;
			this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
			this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
			this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 33);
			this.label1.TabIndex = 7;
			this.label1.Text = "CHAT APP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.label2.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label2.Location = new System.Drawing.Point(44, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(202, 47);
			this.label2.TabIndex = 15;
			this.label2.Text = "REGISTER";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(30, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 14);
			this.label4.TabIndex = 19;
			this.label4.Text = "password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 14);
			this.label3.TabIndex = 18;
			this.label3.Text = "username:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(33, 165);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(223, 27);
			this.txtPassword.TabIndex = 17;
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(33, 111);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(223, 27);
			this.txtUsername.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(30, 203);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 14);
			this.label5.TabIndex = 21;
			this.label5.Text = "confirm password:";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmPassword.Location = new System.Drawing.Point(33, 220);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(223, 27);
			this.txtConfirmPassword.TabIndex = 20;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSubmit.Font = new System.Drawing.Font("Montserrat Alternates Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnSubmit.Location = new System.Drawing.Point(75, 258);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(140, 50);
			this.btnSubmit.TabIndex = 22;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// fRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(300, 320);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnHide);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fRegister";
			this.Text = "Register";
			this.pnHeader.ResumeLayout(false);
			this.pnHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel pnHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Button btnSubmit;
	}
}