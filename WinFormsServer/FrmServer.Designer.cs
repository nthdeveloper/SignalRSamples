namespace WinFormsServer
{
    partial class FrmServer
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
            this.btnStartServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpBroadcast = new System.Windows.Forms.GroupBox();
            this.rdToAll = new System.Windows.Forms.RadioButton();
            this.rdToGroup = new System.Windows.Forms.RadioButton();
            this.rdToClient = new System.Windows.Forms.RadioButton();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBroadcast.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(44, 45);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(108, 23);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Start";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(44, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(242, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "http://localhost:8080";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(178, 45);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(8, 29);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(418, 205);
            this.txtLog.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Location = new System.Drawing.Point(10, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUrl);
            this.groupBox2.Controls.Add(this.btnStartServer);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 82);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // grpBroadcast
            // 
            this.grpBroadcast.Controls.Add(this.btnSend);
            this.grpBroadcast.Controls.Add(this.label2);
            this.grpBroadcast.Controls.Add(this.txtMessage);
            this.grpBroadcast.Controls.Add(this.cmbClients);
            this.grpBroadcast.Controls.Add(this.cmbGroups);
            this.grpBroadcast.Controls.Add(this.rdToClient);
            this.grpBroadcast.Controls.Add(this.rdToGroup);
            this.grpBroadcast.Controls.Add(this.rdToAll);
            this.grpBroadcast.Enabled = false;
            this.grpBroadcast.Location = new System.Drawing.Point(10, 100);
            this.grpBroadcast.Name = "grpBroadcast";
            this.grpBroadcast.Size = new System.Drawing.Size(444, 130);
            this.grpBroadcast.TabIndex = 7;
            this.grpBroadcast.TabStop = false;
            this.grpBroadcast.Text = "Broadcast Message";
            // 
            // rdToAll
            // 
            this.rdToAll.AutoSize = true;
            this.rdToAll.Checked = true;
            this.rdToAll.Location = new System.Drawing.Point(12, 22);
            this.rdToAll.Name = "rdToAll";
            this.rdToAll.Size = new System.Drawing.Size(52, 17);
            this.rdToAll.TabIndex = 0;
            this.rdToAll.TabStop = true;
            this.rdToAll.Text = "To All";
            this.rdToAll.UseVisualStyleBackColor = true;
            // 
            // rdToGroup
            // 
            this.rdToGroup.AutoSize = true;
            this.rdToGroup.Location = new System.Drawing.Point(12, 50);
            this.rdToGroup.Name = "rdToGroup";
            this.rdToGroup.Size = new System.Drawing.Size(70, 17);
            this.rdToGroup.TabIndex = 1;
            this.rdToGroup.Text = "To Group";
            this.rdToGroup.UseVisualStyleBackColor = true;
            // 
            // rdToClient
            // 
            this.rdToClient.AutoSize = true;
            this.rdToClient.Location = new System.Drawing.Point(12, 76);
            this.rdToClient.Name = "rdToClient";
            this.rdToClient.Size = new System.Drawing.Size(67, 17);
            this.rdToClient.TabIndex = 2;
            this.rdToClient.Text = "To Client";
            this.rdToClient.UseVisualStyleBackColor = true;
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(98, 44);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(188, 21);
            this.cmbGroups.TabIndex = 3;
            // 
            // cmbClients
            // 
            this.cmbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(98, 71);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(188, 21);
            this.cmbClients.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(98, 98);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(188, 20);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(301, 42);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 76);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 508);
            this.Controls.Add(this.grpBroadcast);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBroadcast.ResumeLayout(false);
            this.grpBroadcast.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpBroadcast;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.RadioButton rdToClient;
        private System.Windows.Forms.RadioButton rdToGroup;
        private System.Windows.Forms.RadioButton rdToAll;
    }
}

