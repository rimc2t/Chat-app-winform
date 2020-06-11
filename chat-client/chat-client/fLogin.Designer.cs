namespace chat_client
{
	partial class fLogin
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
			this.pnHeader = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pnHeader.SuspendLayout();
			this.SuspendLayout();
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
			this.pnHeader.TabIndex = 0;
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
			this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
			this.label2.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label2.Location = new System.Drawing.Point(80, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 47);
			this.label2.TabIndex = 6;
			this.label2.Text = "LOGIN";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(39, 150);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(223, 27);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(39, 211);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(223, 27);
			this.txtPassword.TabIndex = 1;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSubmit.Font = new System.Drawing.Font("Montserrat Alternates Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnSubmit.Location = new System.Drawing.Point(80, 269);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(140, 50);
			this.btnSubmit.TabIndex = 2;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = false;
			// 
			// btnRegister
			// 
			this.btnRegister.AutoSize = true;
			this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegister.Location = new System.Drawing.Point(49, 378);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(202, 13);
			this.btnRegister.TabIndex = 5;
			this.btnRegister.Text = "Do not you have account? Register now!";
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 14);
			this.label3.TabIndex = 8;
			this.label3.Text = "username:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 14);
			this.label4.TabIndex = 9;
			this.label4.Text = "password:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Brown;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(255, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 45);
			this.button1.TabIndex = 10;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(210, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 45);
			this.button2.TabIndex = 11;
			this.button2.Text = "__";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(300, 400);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pnHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fLogin";
			this.Text = "LOGIN";
			this.pnHeader.ResumeLayout(false);
			this.pnHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label btnRegister;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

