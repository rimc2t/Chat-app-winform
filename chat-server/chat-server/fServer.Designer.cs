namespace chat_server
{
	partial class fServer
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
			this.txtStatus = new System.Windows.Forms.RichTextBox();
			this.txtCmd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnHide = new System.Windows.Forms.Button();
			this.pnHeader = new System.Windows.Forms.Panel();
			this.pnHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtStatus
			// 
			this.txtStatus.Enabled = false;
			this.txtStatus.Location = new System.Drawing.Point(12, 41);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(560, 282);
			this.txtStatus.TabIndex = 0;
			this.txtStatus.Text = "";
			// 
			// txtCmd
			// 
			this.txtCmd.Location = new System.Drawing.Point(12, 329);
			this.txtCmd.Name = "txtCmd";
			this.txtCmd.Size = new System.Drawing.Size(560, 20);
			this.txtCmd.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(7, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Chat Server";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Maroon;
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(540, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(33, 33);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnHide
			// 
			this.btnHide.BackColor = System.Drawing.Color.Snow;
			this.btnHide.ForeColor = System.Drawing.Color.Black;
			this.btnHide.Location = new System.Drawing.Point(508, 1);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(33, 33);
			this.btnHide.TabIndex = 4;
			this.btnHide.Text = "__";
			this.btnHide.UseVisualStyleBackColor = false;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// pnHeader
			// 
			this.pnHeader.BackColor = System.Drawing.Color.Teal;
			this.pnHeader.Controls.Add(this.label1);
			this.pnHeader.Controls.Add(this.btnHide);
			this.pnHeader.Controls.Add(this.btnClose);
			this.pnHeader.Location = new System.Drawing.Point(0, 0);
			this.pnHeader.Name = "pnHeader";
			this.pnHeader.Size = new System.Drawing.Size(584, 35);
			this.pnHeader.TabIndex = 5;
			this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
			this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
			this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
			// 
			// fServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.pnHeader);
			this.Controls.Add(this.txtCmd);
			this.Controls.Add(this.txtStatus);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fServer";
			this.Text = "CHAT SERVER";
			this.Load += new System.EventHandler(this.fServer_Load);
			this.pnHeader.ResumeLayout(false);
			this.pnHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtStatus;
		private System.Windows.Forms.TextBox txtCmd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.Panel pnHeader;
	}
}

