namespace FbChatterApp
{
    partial class FbChatterForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxContacts = new System.Windows.Forms.ListBox();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.tbxNick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.labelSessionPassphrase = new System.Windows.Forms.Label();
            this.textBoxSessionPassphrase = new System.Windows.Forms.TextBox();
            this.checkBoxEncryptChannel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbxContacts
            // 
            this.lbxContacts.FormattingEnabled = true;
            this.lbxContacts.ItemHeight = 16;
            this.lbxContacts.Items.AddRange(new object[] {
            "Contacts:"});
            this.lbxContacts.Location = new System.Drawing.Point(375, 15);
            this.lbxContacts.Margin = new System.Windows.Forms.Padding(4);
            this.lbxContacts.Name = "lbxContacts";
            this.lbxContacts.Size = new System.Drawing.Size(323, 452);
            this.lbxContacts.TabIndex = 0;
            // 
            // tbxLog
            // 
            this.tbxLog.Location = new System.Drawing.Point(16, 115);
            this.tbxLog.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLog.Size = new System.Drawing.Size(349, 352);
            this.tbxLog.TabIndex = 1;
            this.tbxLog.Text = "Log:\r\n";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(267, 14);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 25);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Login";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(267, 46);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 25);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Logout";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(119, 47);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(133, 22);
            this.tbxPass.TabIndex = 4;
            // 
            // tbxNick
            // 
            this.tbxNick.Location = new System.Drawing.Point(119, 15);
            this.tbxNick.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNick.Name = "tbxNick";
            this.tbxNick.Size = new System.Drawing.Size(133, 22);
            this.tbxNick.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Facebook ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(17, 476);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(680, 22);
            this.tbxInput.TabIndex = 8;
            // 
            // labelSessionPassphrase
            // 
            this.labelSessionPassphrase.AutoSize = true;
            this.labelSessionPassphrase.Location = new System.Drawing.Point(116, 86);
            this.labelSessionPassphrase.Name = "labelSessionPassphrase";
            this.labelSessionPassphrase.Size = new System.Drawing.Size(136, 17);
            this.labelSessionPassphrase.TabIndex = 9;
            this.labelSessionPassphrase.Text = "Session Passphrass";
            // 
            // textBoxSessionPassphrase
            // 
            this.textBoxSessionPassphrase.Location = new System.Drawing.Point(267, 83);
            this.textBoxSessionPassphrase.Name = "textBoxSessionPassphrase";
            this.textBoxSessionPassphrase.Size = new System.Drawing.Size(98, 22);
            this.textBoxSessionPassphrase.TabIndex = 10;
            this.textBoxSessionPassphrase.TextChanged += new System.EventHandler(this.textBoxSessionPassphrase_TextChanged);
            // 
            // checkBoxEncryptChannel
            // 
            this.checkBoxEncryptChannel.AutoSize = true;
            this.checkBoxEncryptChannel.Location = new System.Drawing.Point(27, 85);
            this.checkBoxEncryptChannel.Name = "checkBoxEncryptChannel";
            this.checkBoxEncryptChannel.Size = new System.Drawing.Size(78, 21);
            this.checkBoxEncryptChannel.TabIndex = 11;
            this.checkBoxEncryptChannel.Text = "Encrypt";
            this.checkBoxEncryptChannel.UseVisualStyleBackColor = true;
            // 
            // FbChatterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 511);
            this.Controls.Add(this.checkBoxEncryptChannel);
            this.Controls.Add(this.textBoxSessionPassphrase);
            this.Controls.Add(this.labelSessionPassphrase);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNick);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.lbxContacts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FbChatterForm";
            this.Text = "Facebook Chatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxContacts;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.TextBox tbxNick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label labelSessionPassphrase;
        private System.Windows.Forms.TextBox textBoxSessionPassphrase;
        private System.Windows.Forms.CheckBox checkBoxEncryptChannel;
    }
}