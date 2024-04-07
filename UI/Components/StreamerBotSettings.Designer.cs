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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbActions = new System.Windows.Forms.ComboBox();
            this.grpCurrentSplit = new System.Windows.Forms.GroupBox();
            this.btnAddCurrentSplit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbStart = new System.Windows.Forms.TabPage();
            this.tbSplitName = new System.Windows.Forms.TabPage();
            this.tbReset = new System.Windows.Forms.TabPage();
            this.tbGold = new System.Windows.Forms.TabPage();
            this.tbAhead = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBehind = new System.Windows.Forms.TabPage();
            this.topLevelLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCurrentSplit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbSplitName.SuspendLayout();
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
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(387, 128);
            this.topLevelLayoutPanel.TabIndex = 0;
            // 
            // lblSBServer
            // 
            this.lblSBServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSBServer.AutoSize = true;
            this.lblSBServer.Location = new System.Drawing.Point(3, 8);
            this.lblSBServer.Name = "lblSBServer";
            this.lblSBServer.Size = new System.Drawing.Size(110, 13);
            this.lblSBServer.TabIndex = 0;
            this.lblSBServer.Text = "Streamer.Bot Server";
            this.lblSBServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(119, 5);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(265, 20);
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
            this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(3, 38);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(110, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Streamer.Bot Port";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Location = new System.Drawing.Point(119, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(265, 20);
            this.txtPort.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbActions);
            this.groupBox1.Location = new System.Drawing.Point(3, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Streamer.Bot Actions";
            // 
            // cbActions
            // 
            this.cbActions.FormattingEnabled = true;
            this.cbActions.Location = new System.Drawing.Point(6, 33);
            this.cbActions.Name = "cbActions";
            this.cbActions.Size = new System.Drawing.Size(228, 21);
            this.cbActions.TabIndex = 0;
            // 
            // grpCurrentSplit
            // 
            this.grpCurrentSplit.Controls.Add(this.btnAddCurrentSplit);
            this.grpCurrentSplit.Location = new System.Drawing.Point(6, 25);
            this.grpCurrentSplit.Name = "grpCurrentSplit";
            this.grpCurrentSplit.Size = new System.Drawing.Size(333, 57);
            this.grpCurrentSplit.TabIndex = 1;
            this.grpCurrentSplit.TabStop = false;
            this.grpCurrentSplit.Text = "On Current Split";
            // 
            // btnAddCurrentSplit
            // 
            this.btnAddCurrentSplit.Location = new System.Drawing.Point(237, 19);
            this.btnAddCurrentSplit.Name = "btnAddCurrentSplit";
            this.btnAddCurrentSplit.Size = new System.Drawing.Size(75, 23);
            this.btnAddCurrentSplit.TabIndex = 0;
            this.btnAddCurrentSplit.Text = "Add";
            this.btnAddCurrentSplit.UseVisualStyleBackColor = true;
            this.btnAddCurrentSplit.Click += new System.EventHandler(this.btnAddCurrentSplit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbStart);
            this.tabControl1.Controls.Add(this.tbReset);
            this.tabControl1.Controls.Add(this.tbSplitName);
            this.tabControl1.Controls.Add(this.tbGold);
            this.tabControl1.Controls.Add(this.tbAhead);
            this.tabControl1.Controls.Add(this.tbBehind);
            this.tabControl1.Location = new System.Drawing.Point(5, 244);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 290);
            this.tabControl1.TabIndex = 3;
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(4, 22);
            this.tbStart.Name = "tbStart";
            this.tbStart.Padding = new System.Windows.Forms.Padding(3);
            this.tbStart.Size = new System.Drawing.Size(363, 264);
            this.tbStart.TabIndex = 1;
            this.tbStart.Text = "Start";
            this.tbStart.UseVisualStyleBackColor = true;
            // 
            // tbSplitName
            // 
            this.tbSplitName.AutoScroll = true;
            this.tbSplitName.Controls.Add(this.grpCurrentSplit);
            this.tbSplitName.Location = new System.Drawing.Point(4, 22);
            this.tbSplitName.Name = "tbSplitName";
            this.tbSplitName.Padding = new System.Windows.Forms.Padding(3);
            this.tbSplitName.Size = new System.Drawing.Size(363, 264);
            this.tbSplitName.TabIndex = 0;
            this.tbSplitName.Text = "Split Name";
            this.tbSplitName.UseVisualStyleBackColor = true;
            // 
            // tbReset
            // 
            this.tbReset.Location = new System.Drawing.Point(4, 22);
            this.tbReset.Name = "tbReset";
            this.tbReset.Padding = new System.Windows.Forms.Padding(3);
            this.tbReset.Size = new System.Drawing.Size(363, 264);
            this.tbReset.TabIndex = 2;
            this.tbReset.Text = "Reset";
            this.tbReset.UseVisualStyleBackColor = true;
            // 
            // tbGold
            // 
            this.tbGold.Location = new System.Drawing.Point(4, 22);
            this.tbGold.Name = "tbGold";
            this.tbGold.Padding = new System.Windows.Forms.Padding(3);
            this.tbGold.Size = new System.Drawing.Size(363, 264);
            this.tbGold.TabIndex = 3;
            this.tbGold.Text = "Gold Split";
            this.tbGold.UseVisualStyleBackColor = true;
            // 
            // tbAhead
            // 
            this.tbAhead.Location = new System.Drawing.Point(4, 22);
            this.tbAhead.Name = "tbAhead";
            this.tbAhead.Padding = new System.Windows.Forms.Padding(3);
            this.tbAhead.Size = new System.Drawing.Size(363, 264);
            this.tbAhead.TabIndex = 4;
            this.tbAhead.Text = "Ahead";
            this.tbAhead.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Perform Action On...";
            // 
            // tbBehind
            // 
            this.tbBehind.Location = new System.Drawing.Point(4, 22);
            this.tbBehind.Name = "tbBehind";
            this.tbBehind.Size = new System.Drawing.Size(363, 264);
            this.tbBehind.TabIndex = 5;
            this.tbBehind.Text = "Behind";
            this.tbBehind.UseVisualStyleBackColor = true;
            // 
            // StreamerBotSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.topLevelLayoutPanel);
            this.Name = "StreamerBotSettings";
            this.Size = new System.Drawing.Size(393, 648);
            this.Load += new System.EventHandler(this.StreamerBotSettings_Load);
            this.topLevelLayoutPanel.ResumeLayout(false);
            this.topLevelLayoutPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpCurrentSplit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbSplitName.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbActions;
        private System.Windows.Forms.GroupBox grpCurrentSplit;
        private System.Windows.Forms.Button btnAddCurrentSplit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbSplitName;
        private System.Windows.Forms.TabPage tbStart;
        private System.Windows.Forms.TabPage tbReset;
        private System.Windows.Forms.TabPage tbGold;
        private System.Windows.Forms.TabPage tbAhead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbBehind;
    }
}
