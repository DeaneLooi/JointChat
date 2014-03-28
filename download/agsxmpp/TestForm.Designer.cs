namespace Test
{
    partial class TestForm
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
            this.SuspendLayout();
            // 
            // lbxContacts
            // 
            this.lbxContacts.FormattingEnabled = true;
            this.lbxContacts.Location = new System.Drawing.Point(281, 12);
            this.lbxContacts.Name = "lbxContacts";
            this.lbxContacts.Size = new System.Drawing.Size(243, 368);
            this.lbxContacts.TabIndex = 0;
            // 
            // tbxLog
            // 
            this.tbxLog.Location = new System.Drawing.Point(12, 64);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.Size = new System.Drawing.Size(263, 316);
            this.tbxLog.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(181, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 20);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Login";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(181, 38);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 20);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Logout";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(75, 38);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(100, 20);
            this.tbxPass.TabIndex = 4;
            // 
            // tbxNick
            // 
            this.tbxNick.Location = new System.Drawing.Point(75, 12);
            this.tbxNick.Name = "tbxNick";
            this.tbxNick.Size = new System.Drawing.Size(100, 20);
            this.tbxNick.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(13, 387);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(511, 20);
            this.tbxInput.TabIndex = 8;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 413);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNick);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.lbxContacts);
            this.Name = "TestForm";
            this.Text = "Form1";
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
    }
}