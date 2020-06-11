namespace chat_client
{
	partial class fHome
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.btnJoin = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.btnSignOut = new System.Windows.Forms.Button();
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
			// txtCode
			// 
			this.txtCode.ForeColor = System.Drawing.Color.Silver;
			this.txtCode.Location = new System.Drawing.Point(0, 45);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(241, 20);
			this.txtCode.TabIndex = 12;
			this.txtCode.Text = "Enter a code to join a room";
			this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
			this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
			// 
			// btnJoin
			// 
			this.btnJoin.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnJoin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnJoin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnJoin.Location = new System.Drawing.Point(247, 45);
			this.btnJoin.Name = "btnJoin";
			this.btnJoin.Size = new System.Drawing.Size(50, 20);
			this.btnJoin.TabIndex = 13;
			this.btnJoin.Text = "Join";
			this.btnJoin.UseVisualStyleBackColor = false;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCreate.Location = new System.Drawing.Point(247, 71);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(50, 20);
			this.btnCreate.TabIndex = 15;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			// 
			// txtName
			// 
			this.txtName.ForeColor = System.Drawing.Color.Silver;
			this.txtName.Location = new System.Drawing.Point(0, 71);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(241, 20);
			this.txtName.TabIndex = 14;
			this.txtName.Text = "Enter a name to create a room";
			this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
			this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 95);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(300, 280);
			this.listView1.TabIndex = 16;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// btnSignOut
			// 
			this.btnSignOut.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSignOut.ForeColor = System.Drawing.Color.White;
			this.btnSignOut.Location = new System.Drawing.Point(225, 375);
			this.btnSignOut.Name = "btnSignOut";
			this.btnSignOut.Size = new System.Drawing.Size(75, 25);
			this.btnSignOut.TabIndex = 17;
			this.btnSignOut.Text = "SIGN OUT";
			this.btnSignOut.UseVisualStyleBackColor = false;
			this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
			// 
			// fHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(300, 400);
			this.Controls.Add(this.btnSignOut);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnJoin);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pnHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fHome";
			this.Text = "HOME";
			this.pnHeader.ResumeLayout(false);
			this.pnHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Button btnJoin;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnSignOut;
	}
}