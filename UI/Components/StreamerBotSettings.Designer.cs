namespace LiveSplit.UI.Components
{
    partial class StreamerBotSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLevelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblSBServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.topLevelLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLevelLayoutPanel
            // 
            this.topLevelLayoutPanel.AutoSize = true;
            this.topLevelLayoutPanel.ColumnCount = 2;
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.05181F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.94819F));
            this.topLevelLayoutPanel.Controls.Add(this.lblSBServer, 0, 0);
            this.topLevelLayoutPanel.Controls.Add(this.txtServer, 1, 0);
            this.topLevelLayoutPanel.Controls.Add(this.btnConnect, 0, 2);
            this.topLevelLayoutPanel.Controls.Add(this.lblPort, 0, 1);
            this.topLevelLayoutPanel.Controls.Add(this.txtPort, 1, 1);
            this.topLevelLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.topLevelLayoutPanel.Name = "topLevelLayoutPanel";
            this.topLevelLayoutPanel.RowCount = 3;
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(386, 128);
            this.topLevelLayoutPanel.TabIndex = 0;
            this.topLevelLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblSBServer
            // 
            this.lblSBServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSBServer.AutoSize = true;
            this.lblSBServer.Location = new System.Drawing.Point(3, 8);
            this.lblSBServer.Name = "lblSBServer";
            this.lblSBServer.Size = new System.Drawing.Size(102, 13);
            this.lblSBServer.TabIndex = 0;
            this.lblSBServer.Text = "Streamer.Bot Server";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(119, 5);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(264, 20);
            this.txtServer.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.Location = new System.Drawing.Point(20, 82);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPort
            // 
            this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(3, 38);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(90, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Streamer.Bot Port";
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Location = new System.Drawing.Point(119, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(264, 20);
            this.txtPort.TabIndex = 4;
            // 
            // StreamerBotSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.topLevelLayoutPanel);
            this.Name = "StreamerBotSettings";
            this.Size = new System.Drawing.Size(392, 269);
            this.Load += new System.EventHandler(this.StreamerBotSettings_Load);
            this.topLevelLayoutPanel.ResumeLayout(false);
            this.topLevelLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topLevelLayoutPanel;
        private System.Windows.Forms.Label lblSBServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
    }
}
