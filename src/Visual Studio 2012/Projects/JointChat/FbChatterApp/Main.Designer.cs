using System.Drawing;
namespace JointChatApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblpw = new MetroFramework.Controls.MetroLabel();
            this.lblid = new MetroFramework.Controls.MetroLabel();
            this.tbid = new MetroFramework.Controls.MetroTextBox();
            this.tbpw = new MetroFramework.Controls.MetroTextBox();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.tbphone = new MetroFramework.Controls.MetroTextBox();
            this.lblphone = new MetroFramework.Controls.MetroLabel();
            this.tbemail = new MetroFramework.Controls.MetroTextBox();
            this.lblemail = new MetroFramework.Controls.MetroLabel();
            this.tbpass = new MetroFramework.Controls.MetroTextBox();
            this.lblpass = new MetroFramework.Controls.MetroLabel();
            this.tbxInput = new MetroFramework.Controls.MetroTextBox();
            this.tbLog = new MetroFramework.Controls.MetroTextBox();
            this.lbxContacts = new System.Windows.Forms.ListBox();
            this.btnAuth = new MetroFramework.Controls.MetroButton();
            this.tbpass2 = new MetroFramework.Controls.MetroTextBox();
            this.lblpass2 = new MetroFramework.Controls.MetroLabel();
            this.btnDisconnect = new MetroFramework.Controls.MetroButton();
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.ValidationPanel = new System.Windows.Forms.Panel();
            this.lbStatusVal = new MetroFramework.Controls.MetroLabel();
            this.lbAuthVal = new MetroFramework.Controls.MetroLabel();
            this.lbSendVal = new MetroFramework.Controls.MetroLabel();
            this.lbLogVal = new MetroFramework.Controls.MetroLabel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.checkBoxEncryptChannel = new MetroFramework.Controls.MetroToggle();
            this.lblCL = new MetroFramework.Controls.MetroLabel();
            this.lblEncrypt = new MetroFramework.Controls.MetroLabel();
            this.lblLog = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.AuthPanel.SuspendLayout();
            this.ValidationPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.ChatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Location = new System.Drawing.Point(249, 9);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(64, 19);
            this.lblpw.TabIndex = 19;
            this.lblpw.Text = "Password";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(9, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(82, 19);
            this.lblid.TabIndex = 18;
            this.lblid.Text = "Facebook ID";
            // 
            // tbid
            // 
            this.tbid.BackColor = System.Drawing.Color.DarkGray;
            this.tbid.Lines = new string[0];
            this.tbid.Location = new System.Drawing.Point(7, 31);
            this.tbid.MaxLength = 32767;
            this.tbid.Name = "tbid";
            this.tbid.PasswordChar = '\0';
            this.tbid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbid.SelectedText = "";
            this.tbid.Size = new System.Drawing.Size(218, 20);
            this.tbid.TabIndex = 15;
            this.tbid.UseSelectable = true;
            // 
            // tbpw
            // 
            this.tbpw.Lines = new string[0];
            this.tbpw.Location = new System.Drawing.Point(253, 31);
            this.tbpw.MaxLength = 32767;
            this.tbpw.Name = "tbpw";
            this.tbpw.PasswordChar = '*';
            this.tbpw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpw.SelectedText = "";
            this.tbpw.Size = new System.Drawing.Size(218, 27);
            this.tbpw.TabIndex = 16;
            this.tbpw.UseSelectable = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(494, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 27);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Login";
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(28, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(53, 58);
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(14, 158);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(204, 25);
            this.btnSend.TabIndex = 27;
            this.btnSend.Text = "Authenticate My buddy!";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbphone
            // 
            this.tbphone.Enabled = false;
            this.tbphone.Lines = new string[0];
            this.tbphone.Location = new System.Drawing.Point(14, 129);
            this.tbphone.MaxLength = 32767;
            this.tbphone.Name = "tbphone";
            this.tbphone.PasswordChar = '\0';
            this.tbphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbphone.SelectedText = "";
            this.tbphone.Size = new System.Drawing.Size(255, 23);
            this.tbphone.TabIndex = 26;
            this.tbphone.UseSelectable = true;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(11, 110);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(231, 19);
            this.lblphone.TabIndex = 31;
            this.lblphone.Text = "Your buddy\'s phone/ secondary email";
            // 
            // tbemail
            // 
            this.tbemail.Enabled = false;
            this.tbemail.Lines = new string[0];
            this.tbemail.Location = new System.Drawing.Point(14, 79);
            this.tbemail.MaxLength = 32767;
            this.tbemail.Name = "tbemail";
            this.tbemail.PasswordChar = '\0';
            this.tbemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbemail.SelectedText = "";
            this.tbemail.Size = new System.Drawing.Size(255, 23);
            this.tbemail.TabIndex = 25;
            this.tbemail.UseSelectable = true;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(11, 60);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(122, 19);
            this.lblemail.TabIndex = 30;
            this.lblemail.Text = "Your buddy\'s Email";
            // 
            // tbpass
            // 
            this.tbpass.Enabled = false;
            this.tbpass.Lines = new string[0];
            this.tbpass.Location = new System.Drawing.Point(14, 27);
            this.tbpass.Margin = new System.Windows.Forms.Padding(2);
            this.tbpass.MaxLength = 32767;
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '\0';
            this.tbpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpass.SelectedText = "";
            this.tbpass.Size = new System.Drawing.Size(255, 23);
            this.tbpass.TabIndex = 24;
            this.tbpass.UseSelectable = true;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(11, 9);
            this.lblpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(151, 19);
            this.lblpass.TabIndex = 28;
            this.lblpass.Text = "Your Session Passphrase";
            // 
            // tbxInput
            // 
            this.tbxInput.Enabled = false;
            this.tbxInput.Lines = new string[0];
            this.tbxInput.Location = new System.Drawing.Point(5, 307);
            this.tbxInput.MaxLength = 32767;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.PasswordChar = '\0';
            this.tbxInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxInput.SelectedText = "";
            this.tbxInput.Size = new System.Drawing.Size(547, 23);
            this.tbxInput.TabIndex = 29;
            this.tbxInput.UseSelectable = true;
            // 
            // tbLog
            // 
            this.tbLog.Lines = new string[0];
            this.tbLog.Location = new System.Drawing.Point(5, 19);
            this.tbLog.MaxLength = 32767;
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.PasswordChar = '\0';
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.SelectedText = "";
            this.tbLog.Size = new System.Drawing.Size(268, 277);
            this.tbLog.TabIndex = 22;
            this.tbLog.UseSelectable = true;
            // 
            // lbxContacts
            // 
            this.lbxContacts.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxContacts.FormattingEnabled = true;
            this.lbxContacts.ItemHeight = 21;
            this.lbxContacts.Location = new System.Drawing.Point(279, 19);
            this.lbxContacts.Name = "lbxContacts";
            this.lbxContacts.Size = new System.Drawing.Size(273, 277);
            this.lbxContacts.TabIndex = 21;
            // 
            // btnAuth
            // 
            this.btnAuth.Enabled = false;
            this.btnAuth.Location = new System.Drawing.Point(324, 56);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(135, 23);
            this.btnAuth.TabIndex = 33;
            this.btnAuth.Text = "Authenticate Me!";
            this.btnAuth.UseSelectable = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // tbpass2
            // 
            this.tbpass2.Enabled = false;
            this.tbpass2.Lines = new string[0];
            this.tbpass2.Location = new System.Drawing.Point(324, 27);
            this.tbpass2.MaxLength = 32767;
            this.tbpass2.Name = "tbpass2";
            this.tbpass2.PasswordChar = '\0';
            this.tbpass2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpass2.SelectedText = "";
            this.tbpass2.Size = new System.Drawing.Size(255, 23);
            this.tbpass2.TabIndex = 32;
            this.tbpass2.UseSelectable = true;
            this.tbpass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpass2_KeyPress);
            // 
            // lblpass2
            // 
            this.lblpass2.AutoSize = true;
            this.lblpass2.Location = new System.Drawing.Point(326, 8);
            this.lblpass2.Name = "lblpass2";
            this.lblpass2.Size = new System.Drawing.Size(168, 19);
            this.lblpass2.TabIndex = 34;
            this.lblpass2.Text = "Buddy\'s Session Passphrase";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(494, 41);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 27);
            this.btnDisconnect.TabIndex = 35;
            this.btnDisconnect.Text = "Logout";
            this.btnDisconnect.UseSelectable = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.ValidationPanel);
            this.AuthPanel.Controls.Add(this.tbemail);
            this.AuthPanel.Controls.Add(this.lblpass);
            this.AuthPanel.Controls.Add(this.tbpass);
            this.AuthPanel.Controls.Add(this.lblemail);
            this.AuthPanel.Controls.Add(this.btnAuth);
            this.AuthPanel.Controls.Add(this.lblphone);
            this.AuthPanel.Controls.Add(this.tbpass2);
            this.AuthPanel.Controls.Add(this.tbphone);
            this.AuthPanel.Controls.Add(this.lblpass2);
            this.AuthPanel.Controls.Add(this.btnSend);
            this.AuthPanel.Location = new System.Drawing.Point(54, 86);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(594, 194);
            this.AuthPanel.TabIndex = 38;
            // 
            // ValidationPanel
            // 
            this.ValidationPanel.Controls.Add(this.lbStatusVal);
            this.ValidationPanel.Controls.Add(this.lbAuthVal);
            this.ValidationPanel.Controls.Add(this.lbSendVal);
            this.ValidationPanel.Controls.Add(this.lbLogVal);
            this.ValidationPanel.Location = new System.Drawing.Point(315, 96);
            this.ValidationPanel.Name = "ValidationPanel";
            this.ValidationPanel.Size = new System.Drawing.Size(264, 87);
            this.ValidationPanel.TabIndex = 35;
            // 
            // lbStatusVal
            // 
            this.lbStatusVal.AutoSize = true;
            this.lbStatusVal.ForeColor = System.Drawing.Color.Red;
            this.lbStatusVal.Location = new System.Drawing.Point(18, 49);
            this.lbStatusVal.Name = "lbStatusVal";
            this.lbStatusVal.Size = new System.Drawing.Size(15, 19);
            this.lbStatusVal.TabIndex = 3;
            this.lbStatusVal.Text = "*";
            this.lbStatusVal.Visible = false;
            // 
            // lbAuthVal
            // 
            this.lbAuthVal.AutoSize = true;
            this.lbAuthVal.ForeColor = System.Drawing.Color.Red;
            this.lbAuthVal.Location = new System.Drawing.Point(18, 34);
            this.lbAuthVal.Name = "lbAuthVal";
            this.lbAuthVal.Size = new System.Drawing.Size(15, 19);
            this.lbAuthVal.TabIndex = 2;
            this.lbAuthVal.Text = "*";
            this.lbAuthVal.Visible = false;
            // 
            // lbSendVal
            // 
            this.lbSendVal.AutoSize = true;
            this.lbSendVal.ForeColor = System.Drawing.Color.Red;
            this.lbSendVal.Location = new System.Drawing.Point(18, 19);
            this.lbSendVal.Name = "lbSendVal";
            this.lbSendVal.Size = new System.Drawing.Size(15, 19);
            this.lbSendVal.TabIndex = 1;
            this.lbSendVal.Text = "*";
            this.lbSendVal.Visible = false;
            // 
            // lbLogVal
            // 
            this.lbLogVal.AutoSize = true;
            this.lbLogVal.ForeColor = System.Drawing.Color.Red;
            this.lbLogVal.Location = new System.Drawing.Point(18, 4);
            this.lbLogVal.Name = "lbLogVal";
            this.lbLogVal.Size = new System.Drawing.Size(89, 19);
            this.lbLogVal.TabIndex = 0;
            this.lbLogVal.Text = "*Please login!";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LoginPanel.Controls.Add(this.tbpw);
            this.LoginPanel.Controls.Add(this.btnConnect);
            this.LoginPanel.Controls.Add(this.tbid);
            this.LoginPanel.Controls.Add(this.lblid);
            this.LoginPanel.Controls.Add(this.btnDisconnect);
            this.LoginPanel.Controls.Add(this.lblpw);
            this.LoginPanel.Location = new System.Drawing.Point(87, 12);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(597, 68);
            this.LoginPanel.TabIndex = 39;
            // 
            // ChatPanel
            // 
            this.ChatPanel.Controls.Add(this.checkBoxEncryptChannel);
            this.ChatPanel.Controls.Add(this.lblCL);
            this.ChatPanel.Controls.Add(this.lblEncrypt);
            this.ChatPanel.Controls.Add(this.lblLog);
            this.ChatPanel.Controls.Add(this.lbxContacts);
            this.ChatPanel.Controls.Add(this.tbLog);
            this.ChatPanel.Controls.Add(this.tbxInput);
            this.ChatPanel.Location = new System.Drawing.Point(68, 286);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(580, 367);
            this.ChatPanel.TabIndex = 40;
            // 
            // checkBoxEncryptChannel
            // 
            this.checkBoxEncryptChannel.AutoSize = true;
            this.checkBoxEncryptChannel.Checked = true;
            this.checkBoxEncryptChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEncryptChannel.Location = new System.Drawing.Point(81, 337);
            this.checkBoxEncryptChannel.Name = "checkBoxEncryptChannel";
            this.checkBoxEncryptChannel.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEncryptChannel.TabIndex = 42;
            this.checkBoxEncryptChannel.Text = "On";
            this.checkBoxEncryptChannel.UseSelectable = true;
            // 
            // lblCL
            // 
            this.lblCL.AutoSize = true;
            this.lblCL.Location = new System.Drawing.Point(279, 1);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(76, 19);
            this.lblCL.TabIndex = 39;
            this.lblCL.Text = "Contact List";
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(5, 335);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(70, 19);
            this.lblEncrypt.TabIndex = 41;
            this.lblEncrypt.Text = "Encryption";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(5, 1);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(31, 19);
            this.lblLog.TabIndex = 38;
            this.lblLog.Text = "Log";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(981, 662);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.AuthPanel);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "JointChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.ValidationPanel.ResumeLayout(false);
            this.ValidationPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblpw;
        private MetroFramework.Controls.MetroLabel lblid;
        private MetroFramework.Controls.MetroTextBox tbid;
        private MetroFramework.Controls.MetroTextBox tbpw;
        private MetroFramework.Controls.MetroButton btnConnect;
        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroTextBox tbphone;
        private MetroFramework.Controls.MetroLabel lblphone;
        private MetroFramework.Controls.MetroTextBox tbemail;
        private MetroFramework.Controls.MetroLabel lblemail;
        private MetroFramework.Controls.MetroTextBox tbpass;
        private MetroFramework.Controls.MetroLabel lblpass;
        private MetroFramework.Controls.MetroTextBox tbxInput;
        private MetroFramework.Controls.MetroTextBox tbLog;
        private System.Windows.Forms.ListBox lbxContacts;
        private MetroFramework.Controls.MetroButton btnAuth;
        private MetroFramework.Controls.MetroTextBox tbpass2;
        private MetroFramework.Controls.MetroLabel lblpass2;
        private MetroFramework.Controls.MetroButton btnDisconnect;
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel ChatPanel;
        private MetroFramework.Controls.MetroLabel lblCL;
        private MetroFramework.Controls.MetroLabel lblLog;
        private System.Windows.Forms.Panel ValidationPanel;
        private MetroFramework.Controls.MetroLabel lbAuthVal;
        private MetroFramework.Controls.MetroLabel lbSendVal;
        private MetroFramework.Controls.MetroLabel lbLogVal;
        private MetroFramework.Controls.MetroLabel lbStatusVal;
        private MetroFramework.Controls.MetroToggle checkBoxEncryptChannel;
        private MetroFramework.Controls.MetroLabel lblEncrypt;
    }
}