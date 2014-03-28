using System.Drawing;

namespace JointChatApp
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panelTwitterLogin = new MetroFramework.Controls.MetroPanel();
            this.btnTwitterLogout = new System.Windows.Forms.Button();
            this.panelTwitterLogo = new System.Windows.Forms.Panel();
            this.VerifyMe = new System.Windows.Forms.Button();
            this.btnTwitterLogin = new System.Windows.Forms.Button();
            this.tbVerify = new MetroFramework.Controls.MetroTextBox();
            this.lblVerify = new MetroFramework.Controls.MetroLabel();
            this.panelFBLogin = new MetroFramework.Controls.MetroPanel();
            this.panelFBLogo = new System.Windows.Forms.Panel();
            this.lblpw = new MetroFramework.Controls.MetroLabel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblid = new MetroFramework.Controls.MetroLabel();
            this.tbid = new MetroFramework.Controls.MetroTextBox();
            this.tbpw = new MetroFramework.Controls.MetroTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panelContacts = new MetroFramework.Controls.MetroPanel();
            this.lblCompleteInval = new System.Windows.Forms.Label();
            this.lblAuthInval = new System.Windows.Forms.Label();
            this.lblSendInval = new System.Windows.Forms.Label();
            this.lblCompleteVal = new System.Windows.Forms.Label();
            this.lblAuthVal = new System.Windows.Forms.Label();
            this.lblSendVal = new System.Windows.Forms.Label();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbxContacts = new MetroFramework.Controls.MetroComboBox();
            this.lblContacts = new MetroFramework.Controls.MetroLabel();
            this.panelAuthenticate = new MetroFramework.Controls.MetroPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAuth = new System.Windows.Forms.Button();
            this.lblAuthenticateFriend = new MetroFramework.Controls.MetroLabel();
            this.tbphone = new MetroFramework.Controls.MetroTextBox();
            this.tbpass = new MetroFramework.Controls.MetroTextBox();
            this.lblAuthenticateSelf = new MetroFramework.Controls.MetroLabel();
            this.tbpass2 = new MetroFramework.Controls.MetroTextBox();
            this.tbemail = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lblEncrypt = new MetroFramework.Controls.MetroLabel();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblBuddy = new MetroFramework.Controls.MetroLabel();
            this.tbxInput = new MetroFramework.Controls.MetroTextBox();
            this.tbLog = new MetroFramework.Controls.MetroTextBox();
            this.panelCurrentUser = new MetroFramework.Controls.MetroPanel();
            this.lblCurrentTwitter = new MetroFramework.Controls.MetroLabel();
            this.lblCurrentFB = new MetroFramework.Controls.MetroLabel();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panelTwitterLogin.SuspendLayout();
            this.panelFBLogin.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panelContacts.SuspendLayout();
            this.panelAuthenticate.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.panelCurrentUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(181, 17);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(77, 83);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.panelTitle.Location = new System.Drawing.Point(0, -16);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(650, 33);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 50);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "JointChat";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(594, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 25);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseClick);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.ForeColor = System.Drawing.Color.White;
            this.btnMinimise.Location = new System.Drawing.Point(552, 17);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(36, 25);
            this.btnMinimise.TabIndex = 50;
            this.btnMinimise.Text = "-";
            this.btnMinimise.UseVisualStyleBackColor = true;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            this.btnMinimise.MouseEnter += new System.EventHandler(this.btnMinimise_MouseEnter);
            this.btnMinimise.MouseLeave += new System.EventHandler(this.btnMinimise_MouseLeave);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(21, 113);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(594, 377);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.metroTabPage1.Controls.Add(this.panelTwitterLogin);
            this.metroTabPage1.Controls.Add(this.panelFBLogin);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(586, 335);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Login";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panelTwitterLogin
            // 
            this.panelTwitterLogin.Controls.Add(this.btnTwitterLogout);
            this.panelTwitterLogin.Controls.Add(this.panelTwitterLogo);
            this.panelTwitterLogin.Controls.Add(this.VerifyMe);
            this.panelTwitterLogin.Controls.Add(this.btnTwitterLogin);
            this.panelTwitterLogin.Controls.Add(this.tbVerify);
            this.panelTwitterLogin.Controls.Add(this.lblVerify);
            this.panelTwitterLogin.HorizontalScrollbarBarColor = true;
            this.panelTwitterLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTwitterLogin.HorizontalScrollbarSize = 10;
            this.panelTwitterLogin.Location = new System.Drawing.Point(320, 26);
            this.panelTwitterLogin.Name = "panelTwitterLogin";
            this.panelTwitterLogin.Size = new System.Drawing.Size(213, 270);
            this.panelTwitterLogin.TabIndex = 48;
            this.panelTwitterLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelTwitterLogin.VerticalScrollbarBarColor = true;
            this.panelTwitterLogin.VerticalScrollbarHighlightOnWheel = false;
            this.panelTwitterLogin.VerticalScrollbarSize = 10;
            // 
            // btnTwitterLogout
            // 
            this.btnTwitterLogout.AutoSize = true;
            this.btnTwitterLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnTwitterLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTwitterLogout.FlatAppearance.BorderSize = 0;
            this.btnTwitterLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitterLogout.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwitterLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnTwitterLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnTwitterLogout.Image")));
            this.btnTwitterLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTwitterLogout.Location = new System.Drawing.Point(71, 154);
            this.btnTwitterLogout.Name = "btnTwitterLogout";
            this.btnTwitterLogout.Size = new System.Drawing.Size(56, 33);
            this.btnTwitterLogout.TabIndex = 50;
            this.btnTwitterLogout.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTwitterLogout.UseVisualStyleBackColor = false;
            this.btnTwitterLogout.Visible = false;
            this.btnTwitterLogout.Click += new System.EventHandler(this.btnTwitterLogout_Click);
            this.btnTwitterLogout.MouseEnter += new System.EventHandler(this.btnTwitterLogout_MouseEnter);
            this.btnTwitterLogout.MouseLeave += new System.EventHandler(this.btnTwitterLogout_MouseLeave);
            // 
            // panelTwitterLogo
            // 
            this.panelTwitterLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelTwitterLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTwitterLogo.BackgroundImage")));
            this.panelTwitterLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTwitterLogo.Location = new System.Drawing.Point(32, 30);
            this.panelTwitterLogo.Name = "panelTwitterLogo";
            this.panelTwitterLogo.Size = new System.Drawing.Size(135, 79);
            this.panelTwitterLogo.TabIndex = 37;
            // 
            // VerifyMe
            // 
            this.VerifyMe.AutoSize = true;
            this.VerifyMe.BackColor = System.Drawing.Color.Transparent;
            this.VerifyMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VerifyMe.FlatAppearance.BorderSize = 0;
            this.VerifyMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyMe.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyMe.ForeColor = System.Drawing.Color.DimGray;
            this.VerifyMe.Image = ((System.Drawing.Image)(resources.GetObject("VerifyMe.Image")));
            this.VerifyMe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VerifyMe.Location = new System.Drawing.Point(129, 218);
            this.VerifyMe.Name = "VerifyMe";
            this.VerifyMe.Size = new System.Drawing.Size(56, 33);
            this.VerifyMe.TabIndex = 6;
            this.VerifyMe.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.VerifyMe.UseVisualStyleBackColor = false;
            this.VerifyMe.Click += new System.EventHandler(this.VerifyMe_Click);
            this.VerifyMe.MouseEnter += new System.EventHandler(this.VerifyMe_MouseEnter);
            this.VerifyMe.MouseLeave += new System.EventHandler(this.VerifyMe_MouseLeave);
            // 
            // btnTwitterLogin
            // 
            this.btnTwitterLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnTwitterLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTwitterLogin.BackgroundImage")));
            this.btnTwitterLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTwitterLogin.FlatAppearance.BorderSize = 0;
            this.btnTwitterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwitterLogin.Location = new System.Drawing.Point(14, 127);
            this.btnTwitterLogin.Name = "btnTwitterLogin";
            this.btnTwitterLogin.Size = new System.Drawing.Size(171, 32);
            this.btnTwitterLogin.TabIndex = 4;
            this.btnTwitterLogin.UseVisualStyleBackColor = false;
            this.btnTwitterLogin.Click += new System.EventHandler(this.btnLoginTwitter_Click);
            this.btnTwitterLogin.MouseEnter += new System.EventHandler(this.btnLoginTwitter_MouseEnter);
            this.btnTwitterLogin.MouseLeave += new System.EventHandler(this.btnLoginTwitter_MouseLeave);
            // 
            // tbVerify
            // 
            this.tbVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbVerify.IconRight = true;
            this.tbVerify.Lines = new string[0];
            this.tbVerify.Location = new System.Drawing.Point(14, 190);
            this.tbVerify.MaxLength = 32767;
            this.tbVerify.Name = "tbVerify";
            this.tbVerify.PasswordChar = '\0';
            this.tbVerify.PromptText = "Pin";
            this.tbVerify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVerify.SelectedText = "";
            this.tbVerify.Size = new System.Drawing.Size(171, 22);
            this.tbVerify.TabIndex = 5;
            this.tbVerify.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbVerify.UseCustomForeColor = true;
            this.tbVerify.UseSelectable = true;
            this.tbVerify.UseStyleColors = true;
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.BackColor = System.Drawing.Color.Transparent;
            this.lblVerify.Location = new System.Drawing.Point(14, 165);
            this.lblVerify.Margin = new System.Windows.Forms.Padding(3);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(51, 19);
            this.lblVerify.TabIndex = 44;
            this.lblVerify.Text = "Verifier";
            this.lblVerify.UseCustomBackColor = true;
            this.lblVerify.UseStyleColors = true;
            // 
            // panelFBLogin
            // 
            this.panelFBLogin.Controls.Add(this.panelFBLogo);
            this.panelFBLogin.Controls.Add(this.lblpw);
            this.panelFBLogin.Controls.Add(this.btnDisconnect);
            this.panelFBLogin.Controls.Add(this.lblid);
            this.panelFBLogin.Controls.Add(this.tbid);
            this.panelFBLogin.Controls.Add(this.tbpw);
            this.panelFBLogin.Controls.Add(this.btnConnect);
            this.panelFBLogin.HorizontalScrollbarBarColor = true;
            this.panelFBLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFBLogin.HorizontalScrollbarSize = 10;
            this.panelFBLogin.Location = new System.Drawing.Point(55, 23);
            this.panelFBLogin.Name = "panelFBLogin";
            this.panelFBLogin.Size = new System.Drawing.Size(216, 273);
            this.panelFBLogin.TabIndex = 47;
            this.panelFBLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelFBLogin.VerticalScrollbarBarColor = true;
            this.panelFBLogin.VerticalScrollbarHighlightOnWheel = false;
            this.panelFBLogin.VerticalScrollbarSize = 10;
            // 
            // panelFBLogo
            // 
            this.panelFBLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelFBLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFBLogo.BackgroundImage")));
            this.panelFBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFBLogo.Location = new System.Drawing.Point(43, 33);
            this.panelFBLogo.Name = "panelFBLogo";
            this.panelFBLogo.Size = new System.Drawing.Size(135, 79);
            this.panelFBLogo.TabIndex = 36;
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.BackColor = System.Drawing.Color.Transparent;
            this.lblpw.Location = new System.Drawing.Point(29, 171);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(64, 19);
            this.lblpw.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblpw.TabIndex = 19;
            this.lblpw.Text = "Password";
            this.lblpw.UseCustomBackColor = true;
            this.lblpw.UseStyleColors = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AutoSize = true;
            this.btnDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.btnDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisconnect.Location = new System.Drawing.Point(80, 157);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(56, 33);
            this.btnDisconnect.TabIndex = 50;
            this.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Location = new System.Drawing.Point(29, 118);
            this.lblid.Margin = new System.Windows.Forms.Padding(3);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(126, 19);
            this.lblid.TabIndex = 38;
            this.lblid.Text = "Facebook Jabber ID";
            this.lblid.UseCustomBackColor = true;
            this.lblid.UseStyleColors = true;
            // 
            // tbid
            // 
            this.tbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbid.IconRight = true;
            this.tbid.Lines = new string[0];
            this.tbid.Location = new System.Drawing.Point(29, 143);
            this.tbid.MaxLength = 32767;
            this.tbid.Name = "tbid";
            this.tbid.PasswordChar = '\0';
            this.tbid.PromptText = "Jabber ID";
            this.tbid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbid.SelectedText = "";
            this.tbid.Size = new System.Drawing.Size(171, 22);
            this.tbid.TabIndex = 1;
            this.tbid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbid.UseCustomForeColor = true;
            this.tbid.UseSelectable = true;
            this.tbid.UseStyleColors = true;
            // 
            // tbpw
            // 
            this.tbpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbpw.IconRight = true;
            this.tbpw.Lines = new string[0];
            this.tbpw.Location = new System.Drawing.Point(29, 193);
            this.tbpw.MaxLength = 32767;
            this.tbpw.Name = "tbpw";
            this.tbpw.PasswordChar = '●';
            this.tbpw.PromptText = "Password";
            this.tbpw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpw.SelectedText = "";
            this.tbpw.Size = new System.Drawing.Size(171, 22);
            this.tbpw.TabIndex = 2;
            this.tbpw.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbpw.UseCustomForeColor = true;
            this.tbpw.UseSelectable = true;
            this.tbpw.UseStyleColors = true;
            this.tbpw.UseSystemPasswordChar = true;
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.DimGray;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConnect.Location = new System.Drawing.Point(144, 221);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 33);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnConnect.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage2.Controls.Add(this.panelContacts);
            this.metroTabPage2.Controls.Add(this.panelAuthenticate);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(586, 335);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Authentication";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panelContacts
            // 
            this.panelContacts.Controls.Add(this.lblCompleteInval);
            this.panelContacts.Controls.Add(this.lblAuthInval);
            this.panelContacts.Controls.Add(this.lblSendInval);
            this.panelContacts.Controls.Add(this.lblCompleteVal);
            this.panelContacts.Controls.Add(this.lblAuthVal);
            this.panelContacts.Controls.Add(this.lblSendVal);
            this.panelContacts.Controls.Add(this.metroLabel3);
            this.panelContacts.Controls.Add(this.metroLabel2);
            this.panelContacts.Controls.Add(this.metroLabel1);
            this.panelContacts.Controls.Add(this.cbxContacts);
            this.panelContacts.Controls.Add(this.lblContacts);
            this.panelContacts.HorizontalScrollbarBarColor = true;
            this.panelContacts.HorizontalScrollbarHighlightOnWheel = false;
            this.panelContacts.HorizontalScrollbarSize = 10;
            this.panelContacts.Location = new System.Drawing.Point(276, 19);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(254, 255);
            this.panelContacts.TabIndex = 52;
            this.panelContacts.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelContacts.VerticalScrollbarBarColor = true;
            this.panelContacts.VerticalScrollbarHighlightOnWheel = false;
            this.panelContacts.VerticalScrollbarSize = 10;
            // 
            // lblCompleteInval
            // 
            this.lblCompleteInval.Image = ((System.Drawing.Image)(resources.GetObject("lblCompleteInval.Image")));
            this.lblCompleteInval.Location = new System.Drawing.Point(178, 214);
            this.lblCompleteInval.Name = "lblCompleteInval";
            this.lblCompleteInval.Size = new System.Drawing.Size(21, 22);
            this.lblCompleteInval.TabIndex = 59;
            // 
            // lblAuthInval
            // 
            this.lblAuthInval.Image = ((System.Drawing.Image)(resources.GetObject("lblAuthInval.Image")));
            this.lblAuthInval.Location = new System.Drawing.Point(178, 186);
            this.lblAuthInval.Name = "lblAuthInval";
            this.lblAuthInval.Size = new System.Drawing.Size(21, 22);
            this.lblAuthInval.TabIndex = 58;
            // 
            // lblSendInval
            // 
            this.lblSendInval.Image = ((System.Drawing.Image)(resources.GetObject("lblSendInval.Image")));
            this.lblSendInval.Location = new System.Drawing.Point(178, 161);
            this.lblSendInval.Name = "lblSendInval";
            this.lblSendInval.Size = new System.Drawing.Size(21, 22);
            this.lblSendInval.TabIndex = 57;
            // 
            // lblCompleteVal
            // 
            this.lblCompleteVal.Image = ((System.Drawing.Image)(resources.GetObject("lblCompleteVal.Image")));
            this.lblCompleteVal.Location = new System.Drawing.Point(178, 214);
            this.lblCompleteVal.Name = "lblCompleteVal";
            this.lblCompleteVal.Size = new System.Drawing.Size(21, 22);
            this.lblCompleteVal.TabIndex = 56;
            this.lblCompleteVal.Visible = false;
            // 
            // lblAuthVal
            // 
            this.lblAuthVal.Image = ((System.Drawing.Image)(resources.GetObject("lblAuthVal.Image")));
            this.lblAuthVal.Location = new System.Drawing.Point(178, 186);
            this.lblAuthVal.Name = "lblAuthVal";
            this.lblAuthVal.Size = new System.Drawing.Size(21, 22);
            this.lblAuthVal.TabIndex = 55;
            this.lblAuthVal.Visible = false;
            // 
            // lblSendVal
            // 
            this.lblSendVal.Image = ((System.Drawing.Image)(resources.GetObject("lblSendVal.Image")));
            this.lblSendVal.Location = new System.Drawing.Point(178, 161);
            this.lblSendVal.Name = "lblSendVal";
            this.lblSendVal.Size = new System.Drawing.Size(21, 22);
            this.lblSendVal.TabIndex = 54;
            this.lblSendVal.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(6, 214);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 19);
            this.metroLabel3.TabIndex = 53;
            this.metroLabel3.Text = "Authentication Complete";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(6, 189);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(131, 19);
            this.metroLabel2.TabIndex = 52;
            this.metroLabel2.Text = "You\'re Authenticated";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(6, 164);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(166, 19);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Authentication request sent";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // cbxContacts
            // 
            this.cbxContacts.BackColor = System.Drawing.Color.Transparent;
            this.cbxContacts.DisplayFocus = true;
            this.cbxContacts.DropDownHeight = 100;
            this.cbxContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxContacts.ForeColor = System.Drawing.Color.Black;
            this.cbxContacts.FormattingEnabled = true;
            this.cbxContacts.IntegralHeight = false;
            this.cbxContacts.ItemHeight = 23;
            this.cbxContacts.Location = new System.Drawing.Point(4, 28);
            this.cbxContacts.MaxDropDownItems = 4;
            this.cbxContacts.Name = "cbxContacts";
            this.cbxContacts.PromptText = "Select Contacts";
            this.cbxContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxContacts.Size = new System.Drawing.Size(247, 29);
            this.cbxContacts.TabIndex = 1;
            this.cbxContacts.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxContacts.UseSelectable = true;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.BackColor = System.Drawing.Color.Transparent;
            this.lblContacts.Location = new System.Drawing.Point(3, 3);
            this.lblContacts.Margin = new System.Windows.Forms.Padding(3);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(76, 19);
            this.lblContacts.TabIndex = 49;
            this.lblContacts.Text = "Contact List";
            this.lblContacts.UseCustomBackColor = true;
            this.lblContacts.UseStyleColors = true;
            // 
            // panelAuthenticate
            // 
            this.panelAuthenticate.Controls.Add(this.btnSend);
            this.panelAuthenticate.Controls.Add(this.btnAuth);
            this.panelAuthenticate.Controls.Add(this.lblAuthenticateFriend);
            this.panelAuthenticate.Controls.Add(this.tbphone);
            this.panelAuthenticate.Controls.Add(this.tbpass);
            this.panelAuthenticate.Controls.Add(this.lblAuthenticateSelf);
            this.panelAuthenticate.Controls.Add(this.tbpass2);
            this.panelAuthenticate.Controls.Add(this.tbemail);
            this.panelAuthenticate.HorizontalScrollbarBarColor = true;
            this.panelAuthenticate.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAuthenticate.HorizontalScrollbarSize = 10;
            this.panelAuthenticate.Location = new System.Drawing.Point(36, 19);
            this.panelAuthenticate.Name = "panelAuthenticate";
            this.panelAuthenticate.Size = new System.Drawing.Size(234, 255);
            this.panelAuthenticate.TabIndex = 49;
            this.panelAuthenticate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelAuthenticate.VerticalScrollbarBarColor = true;
            this.panelAuthenticate.VerticalScrollbarHighlightOnWheel = false;
            this.panelAuthenticate.VerticalScrollbarSize = 10;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Transparent;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend.Location = new System.Drawing.Point(30, 112);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 33);
            this.btnSend.TabIndex = 5;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.MouseEnter += new System.EventHandler(this.btnSend_MouseEnter);
            this.btnSend.MouseLeave += new System.EventHandler(this.btnSend_MouseLeave);
            // 
            // btnAuth
            // 
            this.btnAuth.AutoSize = true;
            this.btnAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAuth.Enabled = false;
            this.btnAuth.FlatAppearance.BorderSize = 0;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuth.ForeColor = System.Drawing.Color.Transparent;
            this.btnAuth.Image = ((System.Drawing.Image)(resources.GetObject("btnAuth.Image")));
            this.btnAuth.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuth.Location = new System.Drawing.Point(30, 217);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(56, 33);
            this.btnAuth.TabIndex = 7;
            this.btnAuth.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            this.btnAuth.MouseEnter += new System.EventHandler(this.btnAuth_MouseEnter);
            this.btnAuth.MouseLeave += new System.EventHandler(this.btnAuth_MouseLeave);
            // 
            // lblAuthenticateFriend
            // 
            this.lblAuthenticateFriend.AutoSize = true;
            this.lblAuthenticateFriend.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthenticateFriend.Location = new System.Drawing.Point(30, 3);
            this.lblAuthenticateFriend.Margin = new System.Windows.Forms.Padding(3);
            this.lblAuthenticateFriend.Name = "lblAuthenticateFriend";
            this.lblAuthenticateFriend.Size = new System.Drawing.Size(149, 19);
            this.lblAuthenticateFriend.TabIndex = 41;
            this.lblAuthenticateFriend.Text = "Authenticate your friend";
            this.lblAuthenticateFriend.UseCustomBackColor = true;
            this.lblAuthenticateFriend.UseStyleColors = true;
            // 
            // tbphone
            // 
            this.tbphone.Enabled = false;
            this.tbphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbphone.IconRight = true;
            this.tbphone.Lines = new string[0];
            this.tbphone.Location = new System.Drawing.Point(30, 84);
            this.tbphone.MaxLength = 32767;
            this.tbphone.Name = "tbphone";
            this.tbphone.PasswordChar = '\0';
            this.tbphone.PromptText = "Receiver\'s phone/email";
            this.tbphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbphone.SelectedText = "";
            this.tbphone.Size = new System.Drawing.Size(171, 22);
            this.tbphone.TabIndex = 4;
            this.tbphone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbphone.UseCustomForeColor = true;
            this.tbphone.UseSelectable = true;
            this.tbphone.UseStyleColors = true;
            // 
            // tbpass
            // 
            this.tbpass.Enabled = false;
            this.tbpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbpass.IconRight = true;
            this.tbpass.Lines = new string[0];
            this.tbpass.Location = new System.Drawing.Point(30, 28);
            this.tbpass.MaxLength = 32767;
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '\0';
            this.tbpass.PromptText = "Your session passphrase";
            this.tbpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpass.SelectedText = "";
            this.tbpass.Size = new System.Drawing.Size(171, 22);
            this.tbpass.TabIndex = 2;
            this.tbpass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbpass.UseCustomForeColor = true;
            this.tbpass.UseSelectable = true;
            this.tbpass.UseStyleColors = true;
            this.tbpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpass_KeyPress);
            // 
            // lblAuthenticateSelf
            // 
            this.lblAuthenticateSelf.AutoSize = true;
            this.lblAuthenticateSelf.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthenticateSelf.Location = new System.Drawing.Point(30, 164);
            this.lblAuthenticateSelf.Margin = new System.Windows.Forms.Padding(3);
            this.lblAuthenticateSelf.Name = "lblAuthenticateSelf";
            this.lblAuthenticateSelf.Size = new System.Drawing.Size(130, 19);
            this.lblAuthenticateSelf.TabIndex = 43;
            this.lblAuthenticateSelf.Text = "Authenticate yourself";
            this.lblAuthenticateSelf.UseCustomBackColor = true;
            this.lblAuthenticateSelf.UseStyleColors = true;
            // 
            // tbpass2
            // 
            this.tbpass2.Enabled = false;
            this.tbpass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbpass2.IconRight = true;
            this.tbpass2.Lines = new string[0];
            this.tbpass2.Location = new System.Drawing.Point(30, 189);
            this.tbpass2.MaxLength = 32767;
            this.tbpass2.Name = "tbpass2";
            this.tbpass2.PasswordChar = '\0';
            this.tbpass2.PromptText = "Friend\'s session passphrase";
            this.tbpass2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpass2.SelectedText = "";
            this.tbpass2.Size = new System.Drawing.Size(171, 22);
            this.tbpass2.TabIndex = 6;
            this.tbpass2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbpass2.UseCustomForeColor = true;
            this.tbpass2.UseSelectable = true;
            this.tbpass2.UseStyleColors = true;
            this.tbpass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpass2_KeyPress);
            // 
            // tbemail
            // 
            this.tbemail.Enabled = false;
            this.tbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbemail.IconRight = true;
            this.tbemail.Lines = new string[0];
            this.tbemail.Location = new System.Drawing.Point(30, 56);
            this.tbemail.MaxLength = 32767;
            this.tbemail.Name = "tbemail";
            this.tbemail.PasswordChar = '\0';
            this.tbemail.PromptText = "Receiver\'s email address";
            this.tbemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbemail.SelectedText = "";
            this.tbemail.Size = new System.Drawing.Size(171, 22);
            this.tbemail.TabIndex = 3;
            this.tbemail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbemail.UseCustomForeColor = true;
            this.tbemail.UseSelectable = true;
            this.tbemail.UseStyleColors = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.Controls.Add(this.lblEncrypt);
            this.metroTabPage3.Controls.Add(this.btnEncrypt);
            this.metroTabPage3.Controls.Add(this.lblBuddy);
            this.metroTabPage3.Controls.Add(this.tbxInput);
            this.metroTabPage3.Controls.Add(this.tbLog);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(586, 335);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Chat";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.lblEncrypt.Location = new System.Drawing.Point(72, 313);
            this.lblEncrypt.Margin = new System.Windows.Forms.Padding(3);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(67, 19);
            this.lblEncrypt.TabIndex = 54;
            this.lblEncrypt.Text = "Encrypted";
            this.lblEncrypt.UseCustomBackColor = true;
            this.lblEncrypt.UseStyleColors = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.AutoSize = true;
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.Image")));
            this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEncrypt.Location = new System.Drawing.Point(27, 310);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(39, 30);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEncrypt_MouseClick);
            this.btnEncrypt.MouseEnter += new System.EventHandler(this.btnEncrypt_MouseEnter);
            this.btnEncrypt.MouseLeave += new System.EventHandler(this.btnEncrypt_MouseLeave);
            // 
            // lblBuddy
            // 
            this.lblBuddy.AutoSize = true;
            this.lblBuddy.BackColor = System.Drawing.Color.Transparent;
            this.lblBuddy.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBuddy.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBuddy.Location = new System.Drawing.Point(27, 11);
            this.lblBuddy.Margin = new System.Windows.Forms.Padding(3);
            this.lblBuddy.Name = "lblBuddy";
            this.lblBuddy.Size = new System.Drawing.Size(0, 0);
            this.lblBuddy.TabIndex = 53;
            this.lblBuddy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBuddy.UseCustomBackColor = true;
            this.lblBuddy.UseStyleColors = true;
            // 
            // tbxInput
            // 
            this.tbxInput.Enabled = false;
            this.tbxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbxInput.IconRight = true;
            this.tbxInput.Lines = new string[0];
            this.tbxInput.Location = new System.Drawing.Point(27, 282);
            this.tbxInput.MaxLength = 32767;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.PasswordChar = '\0';
            this.tbxInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxInput.SelectedText = "";
            this.tbxInput.Size = new System.Drawing.Size(536, 22);
            this.tbxInput.TabIndex = 1;
            this.tbxInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxInput.UseCustomForeColor = true;
            this.tbxInput.UseSelectable = true;
            this.tbxInput.UseStyleColors = true;
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbLog.Enabled = false;
            this.tbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.tbLog.Lines = new string[0];
            this.tbLog.Location = new System.Drawing.Point(27, 42);
            this.tbLog.MaxLength = 32767;
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.PasswordChar = '\0';
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.SelectedText = "";
            this.tbLog.Size = new System.Drawing.Size(536, 223);
            this.tbLog.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLog.TabIndex = 49;
            this.tbLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbLog.UseCustomForeColor = true;
            this.tbLog.UseSelectable = true;
            this.tbLog.UseStyleColors = true;
            // 
            // panelCurrentUser
            // 
            this.panelCurrentUser.Controls.Add(this.lblCurrentTwitter);
            this.panelCurrentUser.Controls.Add(this.lblCurrentFB);
            this.panelCurrentUser.Controls.Add(this.lblUser);
            this.panelCurrentUser.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCurrentUser.HorizontalScrollbarBarColor = true;
            this.panelCurrentUser.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCurrentUser.HorizontalScrollbarSize = 10;
            this.panelCurrentUser.Location = new System.Drawing.Point(293, 20);
            this.panelCurrentUser.Name = "panelCurrentUser";
            this.panelCurrentUser.Size = new System.Drawing.Size(207, 87);
            this.panelCurrentUser.TabIndex = 50;
            this.panelCurrentUser.UseCustomBackColor = true;
            this.panelCurrentUser.UseCustomForeColor = true;
            this.panelCurrentUser.UseStyleColors = true;
            this.panelCurrentUser.VerticalScrollbarBarColor = true;
            this.panelCurrentUser.VerticalScrollbarHighlightOnWheel = false;
            this.panelCurrentUser.VerticalScrollbarSize = 10;
            this.panelCurrentUser.Visible = false;
            // 
            // lblCurrentTwitter
            // 
            this.lblCurrentTwitter.AutoSize = true;
            this.lblCurrentTwitter.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTwitter.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCurrentTwitter.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCurrentTwitter.Location = new System.Drawing.Point(3, 55);
            this.lblCurrentTwitter.Margin = new System.Windows.Forms.Padding(3);
            this.lblCurrentTwitter.Name = "lblCurrentTwitter";
            this.lblCurrentTwitter.Size = new System.Drawing.Size(0, 0);
            this.lblCurrentTwitter.TabIndex = 48;
            this.lblCurrentTwitter.UseCustomBackColor = true;
            this.lblCurrentTwitter.UseStyleColors = true;
            // 
            // lblCurrentFB
            // 
            this.lblCurrentFB.AutoSize = true;
            this.lblCurrentFB.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentFB.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCurrentFB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCurrentFB.Location = new System.Drawing.Point(3, 28);
            this.lblCurrentFB.Margin = new System.Windows.Forms.Padding(3);
            this.lblCurrentFB.Name = "lblCurrentFB";
            this.lblCurrentFB.Size = new System.Drawing.Size(0, 0);
            this.lblCurrentFB.TabIndex = 47;
            this.lblCurrentFB.UseCustomBackColor = true;
            this.lblCurrentFB.UseStyleColors = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Location = new System.Drawing.Point(3, 3);
            this.lblUser.Margin = new System.Windows.Forms.Padding(3);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(141, 19);
            this.lblUser.TabIndex = 47;
            this.lblUser.Text = "Currently logged in as:";
            this.lblUser.UseCustomBackColor = true;
            this.lblUser.UseStyleColors = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(635, 503);
            this.Controls.Add(this.panelCurrentUser);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JointChat";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panelTwitterLogin.ResumeLayout(false);
            this.panelTwitterLogin.PerformLayout();
            this.panelFBLogin.ResumeLayout(false);
            this.panelFBLogin.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.panelContacts.ResumeLayout(false);
            this.panelContacts.PerformLayout();
            this.panelAuthenticate.ResumeLayout(false);
            this.panelAuthenticate.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.panelCurrentUser.ResumeLayout(false);
            this.panelCurrentUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimise;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panelFBLogo;
        private MetroFramework.Controls.MetroLabel lblpw;
        private MetroFramework.Controls.MetroLabel lblid;
        private System.Windows.Forms.Panel panelTwitterLogo;
        private MetroFramework.Controls.MetroTextBox tbid;
        private MetroFramework.Controls.MetroTextBox tbpw;
        private System.Windows.Forms.Button btnTwitterLogin;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button VerifyMe;
        private MetroFramework.Controls.MetroTextBox tbVerify;
        private MetroFramework.Controls.MetroLabel lblVerify;
        private MetroFramework.Controls.MetroTextBox tbphone;
        private MetroFramework.Controls.MetroTextBox tbemail;
        private MetroFramework.Controls.MetroTextBox tbpass2;
        private MetroFramework.Controls.MetroLabel lblAuthenticateSelf;
        private MetroFramework.Controls.MetroTextBox tbpass;
        private MetroFramework.Controls.MetroLabel lblAuthenticateFriend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAuth;
        private MetroFramework.Controls.MetroPanel panelAuthenticate;
        private MetroFramework.Controls.MetroLabel lblContacts;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox tbLog;
        private MetroFramework.Controls.MetroTextBox tbxInput;
        private MetroFramework.Controls.MetroLabel lblBuddy;
        private MetroFramework.Controls.MetroPanel panelCurrentUser;
        private MetroFramework.Controls.MetroLabel lblCurrentFB;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroPanel panelTwitterLogin;
        private MetroFramework.Controls.MetroPanel panelFBLogin;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnTwitterLogout;
        private MetroFramework.Controls.MetroLabel lblCurrentTwitter;
        private MetroFramework.Controls.MetroPanel panelContacts;
        private MetroFramework.Controls.MetroComboBox cbxContacts;
        private System.Windows.Forms.Label lblCompleteInval;
        private System.Windows.Forms.Label lblAuthInval;
        private System.Windows.Forms.Label lblSendInval;
        private System.Windows.Forms.Label lblCompleteVal;
        private System.Windows.Forms.Label lblAuthVal;
        private System.Windows.Forms.Label lblSendVal;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnEncrypt;
        private MetroFramework.Controls.MetroLabel lblEncrypt;
    }
}