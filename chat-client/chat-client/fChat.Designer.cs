namespace chat_client
{
	partial class fChat
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
			this.txtName = new System.Windows.Forms.Label();
			this.txtMsg = new System.Windows.Forms.RichTextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.listChat = new System.Windows.Forms.ListView();
			this.listUser = new System.Windows.Forms.ListView();
			this.txtNameUser = new System.Windows.Forms.Label();
			this.txtHello = new System.Windows.Forms.Label();
			this.listFiles = new System.Windows.Forms.ListView();
			this.user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAddFile = new System.Windows.Forms.Button();
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.btnOpenFolder = new System.Windows.Forms.Button();
			this.pnHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnHide
			// 
			this.btnHide.BackColor = System.Drawing.Color.White;
			this.btnHide.ForeColor = System.Drawing.Color.Black;
			this.btnHide.Location = new System.Drawing.Point(410, 0);
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
			this.btnClose.Location = new System.Drawing.Point(455, 0);
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
			this.pnHeader.Controls.Add(this.btnHide);
			this.pnHeader.Controls.Add(this.btnClose);
			this.pnHeader.Controls.Add(this.txtName);
			this.pnHeader.ForeColor = System.Drawing.Color.White;
			this.pnHeader.Location = new System.Drawing.Point(0, 0);
			this.pnHeader.Name = "pnHeader";
			this.pnHeader.Size = new System.Drawing.Size(500, 45);
			this.pnHeader.TabIndex = 12;
			this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
			this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
			this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
			// 
			// txtName
			// 
			this.txtName.AutoSize = true;
			this.txtName.Font = new System.Drawing.Font("Montserrat Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(3, 13);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(131, 29);
			this.txtName.TabIndex = 7;
			this.txtName.Text = "CHAT APP";
			// 
			// txtMsg
			// 
			this.txtMsg.Location = new System.Drawing.Point(0, 345);
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.Size = new System.Drawing.Size(419, 43);
			this.txtMsg.TabIndex = 14;
			this.txtMsg.Text = "";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(425, 343);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 45);
			this.btnSend.TabIndex = 15;
			this.btnSend.Text = "SEND";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// listChat
			// 
			this.listChat.HideSelection = false;
			this.listChat.Location = new System.Drawing.Point(0, 76);
			this.listChat.Name = "listChat";
			this.listChat.Size = new System.Drawing.Size(359, 263);
			this.listChat.TabIndex = 16;
			this.listChat.UseCompatibleStateImageBehavior = false;
			this.listChat.View = System.Windows.Forms.View.List;
			// 
			// listUser
			// 
			this.listUser.HideSelection = false;
			this.listUser.Location = new System.Drawing.Point(365, 76);
			this.listUser.Name = "listUser";
			this.listUser.Size = new System.Drawing.Size(135, 101);
			this.listUser.TabIndex = 17;
			this.listUser.UseCompatibleStateImageBehavior = false;
			this.listUser.View = System.Windows.Forms.View.List;
			// 
			// txtNameUser
			// 
			this.txtNameUser.AutoSize = true;
			this.txtNameUser.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNameUser.Location = new System.Drawing.Point(53, 48);
			this.txtNameUser.Name = "txtNameUser";
			this.txtNameUser.Size = new System.Drawing.Size(56, 22);
			this.txtNameUser.TabIndex = 18;
			this.txtNameUser.Text = "Name";
			this.txtNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtHello
			// 
			this.txtHello.AutoSize = true;
			this.txtHello.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHello.Location = new System.Drawing.Point(1, 48);
			this.txtHello.Name = "txtHello";
			this.txtHello.Size = new System.Drawing.Size(55, 22);
			this.txtHello.TabIndex = 19;
			this.txtHello.Text = "Hello";
			this.txtHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listFiles
			// 
			this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user,
            this.fileName});
			this.listFiles.FullRowSelect = true;
			this.listFiles.GridLines = true;
			this.listFiles.HideSelection = false;
			this.listFiles.Location = new System.Drawing.Point(365, 204);
			this.listFiles.MultiSelect = false;
			this.listFiles.Name = "listFiles";
			this.listFiles.Size = new System.Drawing.Size(135, 108);
			this.listFiles.TabIndex = 20;
			this.listFiles.UseCompatibleStateImageBehavior = false;
			this.listFiles.View = System.Windows.Forms.View.Details;
			// 
			// user
			// 
			this.user.Text = "User";
			this.user.Width = 45;
			// 
			// fileName
			// 
			this.fileName.Text = "File Name";
			this.fileName.Width = 90;
			// 
			// btnAddFile
			// 
			this.btnAddFile.Location = new System.Drawing.Point(450, 182);
			this.btnAddFile.Name = "btnAddFile";
			this.btnAddFile.Size = new System.Drawing.Size(50, 20);
			this.btnAddFile.TabIndex = 22;
			this.btnAddFile.Text = "add";
			this.btnAddFile.UseVisualStyleBackColor = true;
			this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
			// 
			// txtFilePath
			// 
			this.txtFilePath.ForeColor = System.Drawing.Color.Gray;
			this.txtFilePath.Location = new System.Drawing.Point(365, 182);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(84, 20);
			this.txtFilePath.TabIndex = 23;
			this.txtFilePath.Text = "enter file path";
			this.txtFilePath.Enter += new System.EventHandler(this.txtFilePath_Enter);
			this.txtFilePath.Leave += new System.EventHandler(this.txtFilePath_Leave);
			// 
			// btnOpenFolder
			// 
			this.btnOpenFolder.Location = new System.Drawing.Point(365, 314);
			this.btnOpenFolder.Name = "btnOpenFolder";
			this.btnOpenFolder.Size = new System.Drawing.Size(135, 23);
			this.btnOpenFolder.TabIndex = 24;
			this.btnOpenFolder.Text = "Show folder";
			this.btnOpenFolder.UseVisualStyleBackColor = true;
			this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
			// 
			// fChat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 400);
			this.Controls.Add(this.btnOpenFolder);
			this.Controls.Add(this.txtFilePath);
			this.Controls.Add(this.btnAddFile);
			this.Controls.Add(this.listFiles);
			this.Controls.Add(this.txtHello);
			this.Controls.Add(this.txtNameUser);
			this.Controls.Add(this.listUser);
			this.Controls.Add(this.listChat);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtMsg);
			this.Controls.Add(this.pnHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fChat";
			this.Text = "fChat";
			this.Load += new System.EventHandler(this.fChat_Load);
			this.pnHeader.ResumeLayout(false);
			this.pnHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel pnHeader;
		private System.Windows.Forms.Label txtName;
		private System.Windows.Forms.RichTextBox txtMsg;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.ListView listChat;
		private System.Windows.Forms.ListView listUser;
		private System.Windows.Forms.Label txtNameUser;
		private System.Windows.Forms.Label txtHello;
		private System.Windows.Forms.ListView listFiles;
		private System.Windows.Forms.Button btnAddFile;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.ColumnHeader user;
		private System.Windows.Forms.ColumnHeader fileName;
		private System.Windows.Forms.Button btnOpenFolder;
	}
}