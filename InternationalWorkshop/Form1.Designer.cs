namespace InternationalWorkshop
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.tbx_IP = new System.Windows.Forms.TextBox();
			this.lbl_IP = new System.Windows.Forms.Label();
			this.btnChangeServer = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolTip_IP = new System.Windows.Forms.ToolTip(this.components);
			this.tbx_sharedFolderName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbx_details = new System.Windows.Forms.ListBox();
			this.llb_showDetails = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbx_IP
			// 
			this.tbx_IP.Location = new System.Drawing.Point(253, 24);
			this.tbx_IP.Name = "tbx_IP";
			this.tbx_IP.Size = new System.Drawing.Size(100, 20);
			this.tbx_IP.TabIndex = 0;
			this.tbx_IP.Text = "192.168.178.10";
			this.toolTip_IP.SetToolTip(this.tbx_IP, "Bitte die IP-Adresse des neuen BoCash-Servers eintragen.\r\n\r\nStandard-Betrieb: 192" +
        ".168.178.10\r\nFailover-Betrieb: 192.168.178.11");
			// 
			// lbl_IP
			// 
			this.lbl_IP.AutoSize = true;
			this.lbl_IP.Location = new System.Drawing.Point(186, 27);
			this.lbl_IP.Name = "lbl_IP";
			this.lbl_IP.Size = new System.Drawing.Size(61, 13);
			this.lbl_IP.TabIndex = 1;
			this.lbl_IP.Text = "IP-Adresse:";
			// 
			// btnChangeServer
			// 
			this.btnChangeServer.Location = new System.Drawing.Point(253, 108);
			this.btnChangeServer.Name = "btnChangeServer";
			this.btnChangeServer.Size = new System.Drawing.Size(100, 23);
			this.btnChangeServer.TabIndex = 2;
			this.btnChangeServer.Text = "Server wechseln";
			this.btnChangeServer.UseVisualStyleBackColor = true;
			this.btnChangeServer.Click += new System.EventHandler(this.BtnChangeServer_ClickHandler);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::InternationalWorkshop.Properties.Resources.Logo_Workshop_allgem;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(145, 83);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// toolTip_IP
			// 
			this.toolTip_IP.AutoPopDelay = 5000;
			this.toolTip_IP.InitialDelay = 150;
			this.toolTip_IP.ReshowDelay = 50;
			this.toolTip_IP.ShowAlways = true;
			this.toolTip_IP.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// tbx_sharedFolderName
			// 
			this.tbx_sharedFolderName.Location = new System.Drawing.Point(253, 64);
			this.tbx_sharedFolderName.Name = "tbx_sharedFolderName";
			this.tbx_sharedFolderName.Size = new System.Drawing.Size(100, 20);
			this.tbx_sharedFolderName.TabIndex = 4;
			this.tbx_sharedFolderName.Text = "Exchange";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(170, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Freigabename:";
			// 
			// lbx_details
			// 
			this.lbx_details.FormattingEnabled = true;
			this.lbx_details.Location = new System.Drawing.Point(42, 167);
			this.lbx_details.Name = "lbx_details";
			this.lbx_details.Size = new System.Drawing.Size(292, 108);
			this.lbx_details.TabIndex = 6;
			this.lbx_details.Visible = false;
			// 
			// llb_showDetails
			// 
			this.llb_showDetails.AutoSize = true;
			this.llb_showDetails.Location = new System.Drawing.Point(39, 151);
			this.llb_showDetails.Name = "llb_showDetails";
			this.llb_showDetails.Size = new System.Drawing.Size(106, 13);
			this.llb_showDetails.TabIndex = 8;
			this.llb_showDetails.TabStop = true;
			this.llb_showDetails.Text = "Details einblenden ...";
			this.llb_showDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_showDetails_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 287);
			this.Controls.Add(this.llb_showDetails);
			this.Controls.Add(this.lbx_details);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbx_sharedFolderName);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnChangeServer);
			this.Controls.Add(this.lbl_IP);
			this.Controls.Add(this.tbx_IP);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "International Workshop";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbx_IP;
		private System.Windows.Forms.Label lbl_IP;
		private System.Windows.Forms.Button btnChangeServer;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolTip toolTip_IP;
		private System.Windows.Forms.TextBox tbx_sharedFolderName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbx_details;
		private System.Windows.Forms.LinkLabel llb_showDetails;
	}
}

