namespace PlexPyActiveStreams
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtPPIP = new System.Windows.Forms.TextBox();
            this.lblPPIP = new System.Windows.Forms.Label();
            this.lblPPAPI = new System.Windows.Forms.Label();
            this.txtPPAPI = new System.Windows.Forms.TextBox();
            this.lblPPOutput = new System.Windows.Forms.Label();
            this.txtPPOutput = new System.Windows.Forms.TextBox();
            this.btnPPSubmit = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPlexPyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPPIP
            // 
            this.txtPPIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPPIP.Location = new System.Drawing.Point(16, 31);
            this.txtPPIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPIP.Name = "txtPPIP";
            this.txtPPIP.Size = new System.Drawing.Size(412, 22);
            this.txtPPIP.TabIndex = 0;
            this.txtPPIP.Text = "192.168.0.6:8181";
            // 
            // lblPPIP
            // 
            this.lblPPIP.AutoSize = true;
            this.lblPPIP.Location = new System.Drawing.Point(16, 11);
            this.lblPPIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPIP.Name = "lblPPIP";
            this.lblPPIP.Size = new System.Drawing.Size(66, 17);
            this.lblPPIP.TabIndex = 1;
            this.lblPPIP.Text = "PlexPy IP";
            // 
            // lblPPAPI
            // 
            this.lblPPAPI.AutoSize = true;
            this.lblPPAPI.Location = new System.Drawing.Point(16, 59);
            this.lblPPAPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPAPI.Name = "lblPPAPI";
            this.lblPPAPI.Size = new System.Drawing.Size(103, 17);
            this.lblPPAPI.TabIndex = 3;
            this.lblPPAPI.Text = "PlexPy API Key";
            // 
            // txtPPAPI
            // 
            this.txtPPAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPPAPI.Location = new System.Drawing.Point(16, 79);
            this.txtPPAPI.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPAPI.Name = "txtPPAPI";
            this.txtPPAPI.Size = new System.Drawing.Size(412, 22);
            this.txtPPAPI.TabIndex = 2;
            this.txtPPAPI.Text = "affbc33fb32c8ec3ebf98828326982cf";
            // 
            // lblPPOutput
            // 
            this.lblPPOutput.AutoSize = true;
            this.lblPPOutput.Location = new System.Drawing.Point(12, 143);
            this.lblPPOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPOutput.Name = "lblPPOutput";
            this.lblPPOutput.Size = new System.Drawing.Size(101, 17);
            this.lblPPOutput.TabIndex = 7;
            this.lblPPOutput.Text = "PlexPy Output:";
            // 
            // txtPPOutput
            // 
            this.txtPPOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPPOutput.Location = new System.Drawing.Point(16, 162);
            this.txtPPOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPOutput.Multiline = true;
            this.txtPPOutput.Name = "txtPPOutput";
            this.txtPPOutput.Size = new System.Drawing.Size(412, 143);
            this.txtPPOutput.TabIndex = 6;
            // 
            // btnPPSubmit
            // 
            this.btnPPSubmit.Location = new System.Drawing.Point(16, 111);
            this.btnPPSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnPPSubmit.Name = "btnPPSubmit";
            this.btnPPSubmit.Size = new System.Drawing.Size(413, 28);
            this.btnPPSubmit.TabIndex = 8;
            this.btnPPSubmit.Text = "Save / Go";
            this.btnPPSubmit.UseVisualStyleBackColor = true;
            this.btnPPSubmit.Click += new System.EventHandler(this.btnPPSubmit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PlexPyActiveStreams";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIconContextMenu
            // 
            this.notifyIconContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPlexPyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyIconContextMenu.Name = "notifyIconContextMenu";
            this.notifyIconContextMenu.Size = new System.Drawing.Size(167, 56);
            // 
            // openPlexPyToolStripMenuItem
            // 
            this.openPlexPyToolStripMenuItem.Name = "openPlexPyToolStripMenuItem";
            this.openPlexPyToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.openPlexPyToolStripMenuItem.Text = "Open PlexPy";
            this.openPlexPyToolStripMenuItem.Click += new System.EventHandler(this.openPlexPyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 321);
            this.Controls.Add(this.btnPPSubmit);
            this.Controls.Add(this.lblPPOutput);
            this.Controls.Add(this.txtPPOutput);
            this.Controls.Add(this.lblPPAPI);
            this.Controls.Add(this.txtPPAPI);
            this.Controls.Add(this.lblPPIP);
            this.Controls.Add(this.txtPPIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(461, 358);
            this.Name = "MainForm";
            this.Text = "PlexPy Active Streams";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.notifyIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPPIP;
        private System.Windows.Forms.Label lblPPIP;
        private System.Windows.Forms.Label lblPPAPI;
        private System.Windows.Forms.TextBox txtPPAPI;
        private System.Windows.Forms.Label lblPPOutput;
        private System.Windows.Forms.TextBox txtPPOutput;
        private System.Windows.Forms.Button btnPPSubmit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openPlexPyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

