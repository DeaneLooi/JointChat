using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Facebook_Connection;
using TweetSharp;
using MetroFramework;

namespace JointChatApp
{
    public partial class UI : Form
    {
        //Move the form//
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Twitter Key Settings//
        private static string consumerKey = ConfigurationManager.AppSettings["consumerKey"];
        private static string consumerSecret = ConfigurationManager.AppSettings["consumerSecret"];
        private TwitterService service = new TwitterService(consumerKey, consumerSecret);
        private OAuthRequestToken requestToken;
        private OAuthAccessToken access;

        private FacebookChatClient client;
        private TwitterUser profile;

        //Timers//
        private Timer mytimer = new Timer();
        private Timer dbTimer = new Timer();
        private Timer expiredTimer = new Timer();
        private Timer msgTimer = new Timer();


        //Retrieve Twitter Messages//
        private List<TwitterDirectMessage> msg = new List<TwitterDirectMessage>();
        private List<long> duplicateMsg = new List<long>();
        private bool duplicate = false;
        private DateTime now;

        //Check for which account user logon with//
        private bool twitterLogon = false;
        private bool fbLogon = false;

        //Encryption toggle//
        private bool encrypt = true;
        private bool contactMsg;

        //Get current timezone//
        private TimeZone zone = TimeZone.CurrentTimeZone;

        public UI()
        {
            InitializeComponent();

            client = new FacebookChatClient();

            metroTabControl1.SelectedTab = metroTabPage1;

            //Twitter Query message interval
            msgTimer.Interval = 10000;
            msgTimer.Tick += new System.EventHandler(OnMsgEvent);

            //Authentication complete check//
            mytimer.Interval = 10000;
            mytimer.Tick += new System.EventHandler(OnTimerEvent);


            //Set expiration for passphrase in database//
            expiredTimer.Interval = 1800000;
            expiredTimer.Tick += new System.EventHandler(OnExpiredEvent);

            //Loaded when client login successfully//
            client.OnLoginResult = success =>
                {
                    fbLogon = true;
                    FacebookUser fbuser = client.GetUser(tbid.Text);

                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                            {

                                lblCurrentFB.Text = fbuser.name;
                                panelCurrentUser.Visible = true;
                                btnConnect.Visible = false;
                                lblid.Visible = false;
                                tbid.Visible = false;
                                lblpw.Visible = false;
                                tbpw.Visible = false;
                                btnConnect.Visible = false;
                                btnDisconnect.Visible = true;
                            }));
                    else
                    {
                        lblCurrentFB.Text = fbuser.name;
                        panelCurrentUser.Visible = true;
                        btnConnect.Visible = false;
                        lblid.Visible = false;
                        tbid.Visible = false;
                        lblpw.Visible = false;
                        tbpw.Visible = false;
                        btnConnect.Visible = false;
                        btnDisconnect.Visible = true;
                    }


                    if (twitterLogon)
                    {

                    }

                    else
                    {
                        if (this.InvokeRequired)
                            this.Invoke(new MethodInvoker(delegate
                            {
                                btnAuth.Enabled = true;
                                btnSend.Enabled = true;
                                tbphone.Enabled = true;
                                tbemail.Enabled = true;
                                tbpass.Enabled = true;
                                tbpass2.Enabled = true;
                                cbxContacts.Enabled = true;
                            }));
                        else
                        {
                            btnAuth.Enabled = true;
                            btnSend.Enabled = true;
                            tbphone.Enabled = true;
                            tbemail.Enabled = true;
                            tbpass.Enabled = true;
                            tbpass2.Enabled = true;
                            cbxContacts.Enabled = true;
                        }
                    }
                    MetroMessageBox.Show(this, "Successful Facebook Login", "JointChat", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate
                            {
                                metroTabControl1.SelectedTab = metroTabPage2;
                            }));
                    }

                    else
                    {
                        metroTabControl1.SelectedTab = metroTabPage2;
                    }

                };

            //Loaded when client logs off//
            client.OnLogout = () =>
                  {
                      if (twitterLogon)
                      {
                          cbxContacts.Items.Clear();
                          TwitterCursorList<TwitterUser> contacts = service.ListFriends(new ListFriendsOptions());
                          bool buddyName = true;
                          foreach (TwitterUser friends in contacts)
                          {
                              changeContactList(friends.ScreenName, true);
                          }
                          for (int i = 0; i < contacts.Count; i++)
                          {
                              TwitterUser friend = contacts[i];
                              if (lblBuddy.Text.Equals(friend.ScreenName))
                              {
                                  buddyName = false;
                                  break;
                              }
                              else
                              {
                                  buddyName = true;
                              }
                          }

                          if (buddyName)
                          {

                              tbLog.Clear();
                              cbxContacts.Items.Clear();
                              tbemail.Clear();
                              tbpass.Clear();
                              tbpass2.Clear();
                              tbphone.Clear();
                              tbid.Clear();
                              tbpw.Clear();

                              if (this.InvokeRequired)
                                  this.Invoke(new MethodInvoker(delegate
                                  {
                                      lblBuddy.Text = "";
                                      btnEncrypt.Enabled = false;
                                      tbxInput.Enabled = false;
                                      lblSendVal.Visible = false;
                                      lblSendInval.Visible = true;
                                      lblAuthVal.Visible = false;
                                      lblAuthInval.Visible = true;
                                      lblCompleteVal.Visible = false;
                                      lblCompleteInval.Visible = true;
                                      tbLog.Enabled = false;
                                      tbpass.Enabled = true;
                                      tbpass2.Enabled = true;
                                      cbxContacts.Enabled = true;
                                  }));
                              else
                              {
                                  lblBuddy.Text = "";
                                  btnEncrypt.Enabled = false;
                                  tbxInput.Enabled = false;
                                  lblSendVal.Visible = false;
                                  lblSendInval.Visible = true;
                                  lblAuthVal.Visible = false;
                                  lblAuthInval.Visible = true;
                                  lblCompleteVal.Visible = false;
                                  lblCompleteInval.Visible = true;
                                  tbLog.Enabled = false;
                                  tbpass.Enabled = true;
                                  tbpass2.Enabled = true;
                                  cbxContacts.Enabled = true;
                              }

                              foreach (TwitterUser friends in contacts)
                              {
                                  changeContactList(friends.ScreenName, true);
                              }
                              cbxContacts.PromptText = "Select Contacts";
                          }

                          else
                          {

                          }
                      }
                      else
                      {
                          tbLog.Clear();
                          cbxContacts.Items.Clear();
                          tbemail.Clear();
                          tbpass.Clear();
                          tbpass2.Clear();
                          tbphone.Clear();
                          tbid.Clear();
                          tbpw.Clear();

                          if (this.InvokeRequired)
                              this.Invoke(new MethodInvoker(delegate
                              {
                                  btnAuth.Enabled = false;
                                  btnSend.Enabled = false;
                                  btnEncrypt.Enabled = false;
                                  tbphone.Enabled = false;
                                  tbemail.Enabled = false;
                                  tbpass.Enabled = false;
                                  tbpass2.Enabled = false;
                                  tbxInput.Enabled = false;
                                  cbxContacts.Enabled = false;
                                  panelCurrentUser.Visible = false;
                                  lblSendVal.Visible = false;
                                  lblSendInval.Visible = true;
                                  lblAuthVal.Visible = false;
                                  lblAuthInval.Visible = true;
                                  lblCompleteVal.Visible = false;
                                  lblCompleteInval.Visible = true;
                                  tbLog.Enabled = false;
                              }));
                          else
                          {
                              btnAuth.Enabled = false;
                              btnSend.Enabled = false;
                              btnEncrypt.Enabled = false;
                              tbphone.Enabled = false;
                              tbemail.Enabled = false;
                              tbpass.Enabled = false;
                              tbpass2.Enabled = false;
                              tbxInput.Enabled = false;
                              cbxContacts.Enabled = false;
                              panelCurrentUser.Visible = false;
                              lblSendVal.Visible = false;
                              lblSendInval.Visible = true;
                              lblAuthVal.Visible = false;
                              lblAuthInval.Visible = true;
                              lblCompleteVal.Visible = false;
                              lblCompleteInval.Visible = true;
                              tbLog.Enabled = false;
                          }

                      }

                      if (this.InvokeRequired)
                          this.Invoke(new MethodInvoker(delegate
                          {
                              lblCurrentFB.Text = "";
                              btnConnect.Visible = true;
                              lblid.Visible = true;
                              tbid.Visible = true;
                              lblpw.Visible = true;
                              tbpw.Visible = true;
                              btnDisconnect.Visible = false;
                          }));
                      else
                      {
                          lblCurrentFB.Text = "";
                          btnConnect.Visible = true;
                          lblid.Visible = true;
                          tbid.Visible = true;
                          lblpw.Visible = true;
                          tbpw.Visible = true;
                          btnDisconnect.Visible = false;
                      }
                  };

            //Handle retrieved facebook messages
            client.OnMessageReceived = (msg, user) =>
            {
                if (!string.IsNullOrEmpty((string)cbxContacts.Items[cbxContacts.SelectedIndex]))
                {
                    string sender = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
                    if (user.name.Equals(sender))
                    {
                        if (!encrypt)
                        {
                            appendLog(DateTime.Now + " " + user.name + ":  " + msg.Body);
                        }
                        else
                        {
                            appendLog(DateTime.Now + " " + user.name + ":  " + msg.Body);
                            appendLog(DateTime.Now + " " + user.name + ":  " + MyCrypto.AESDecrypt(msg.Body, tbpass2.Text, 256, "CBC"));
                        }
                    }
                }

            };

            //Presence: notify buddy status
            client.OnUserAdded = user =>
            {
                string sender = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
                if (user.name.Equals(sender))
                {
                    appendLog("User " + user.name + " is now available for chat");
                    changeContactList(user.name, true);
                }
            };

            //Presence: Notify when buddy becomes offline
            client.OnUserRemoved = user =>
            {
                string sender = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
                if (user.name.Equals(sender))
                {
                    appendLog("User " + user.name + " is no longer available for chat");
                    changeContactList(user.name, false);
                }
            };

            tbxInput.KeyPress += new KeyPressEventHandler(tbxInput_KeyPress);
        }

        //Send chat messages//
        private void tbxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check for input from tbxInput
            if (e.KeyChar == '\r' && !string.IsNullOrEmpty(tbxInput.Text) && cbxContacts.SelectedItem != null)
            {

                //contactMsg = true means it's a twitter direct message
                if (contactMsg)
                {
                    TwitterUser receiver = new TwitterUser();

                    //Send unencrypted Twitter direct message
                    if (!encrypt)
                    {
                        receiver.ScreenName = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
                        var message = tbxInput.Text;
                        service.SendDirectMessage(new SendDirectMessageOptions { ScreenName = receiver.ScreenName, Text = message });
                    }

                    else
                    {
                        //Send encrypted Twitter direct message
                        receiver.ScreenName = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
                        var message = MyCrypto.AESEncrypt(tbxInput.Text, tbpass.Text, 256, "CBC");
                        service.SendDirectMessage(new SendDirectMessageOptions { ScreenName = receiver.ScreenName, Text = message });
                    }
                }

                else
                {
                    FacebookUser fbuser = client.GetUser(tbid.Text);
                    string user = fbuser.name;

                    if (!encrypt)
                    {
                        //Send unencrypted FB chat message
                        client.SendMessage(tbxInput.Text, (string)cbxContacts.Items[cbxContacts.SelectedIndex]);
                        appendLog(DateTime.Now + " " + user + ":  " + tbxInput.Text);
                    }
                    else
                    {
                        //Send encrypted FB chat message
                        client.SendMessage(
                            MyCrypto.AESEncrypt(tbxInput.Text, tbpass.Text, 256, "CBC"),
                            (string)cbxContacts.Items[cbxContacts.SelectedIndex]);
                        appendLog(DateTime.Now + " " + user + ":  " + tbxInput.Text);
                        appendLog(DateTime.Now + " " + user + ":  " + MyCrypto.AESEncrypt(tbxInput.Text, tbpass.Text, 256, "CBC"));
                    }
                }
                tbxInput.ResetText();
            }
        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            string name = "";
            
            //Twitter 
            if (contactMsg)
            {
                name = profile.ScreenName;
            }

            else
            {
                if (!string.IsNullOrEmpty(tbid.Text))
                {
                    FacebookUser fbuser = client.GetUser(tbid.Text);
                    name = fbuser.name;
                }
                else
                {
                    this.Close();
                }
            }
            //Delete everything related to user from database on exit//
            DBConnect db = new DBConnect();
            db.DeleteAllFromUser(name);
            this.Close();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnExit.ForeColor = ColorTranslator.FromHtml("#FF33B5E5");
                }));
            }

            else
            {
                btnExit.ForeColor = ColorTranslator.FromHtml("#FF33B5E5");
            }
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnExit.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                }));
            }

            else
            {
                btnExit.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnMinimise_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnMinimise.ForeColor = ColorTranslator.FromHtml("#FF33B5E5");
                }));
            }

            else
            {
                btnMinimise.ForeColor = ColorTranslator.FromHtml("#FF33B5E5");
            }
        }

        private void btnMinimise_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnMinimise.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                }));
            }

            else
            {
                btnMinimise.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbxContacts.Items[cbxContacts.SelectedIndex];
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbid.Text) && !string.IsNullOrEmpty(tbpw.Text))
                client.Logout();
        }

        private void btnConnect_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnConnect.BackColor = ColorTranslator.FromHtml("#FF353535");
                }));
            }

            else
            {
                btnConnect.BackColor = ColorTranslator.FromHtml("#FF353535");
            }
        }

        private void btnConnect_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnConnect.BackColor = ColorTranslator.FromHtml("#FF111111");
                }));
            }

            else
            {
                btnConnect.BackColor = ColorTranslator.FromHtml("#FF111111");
            }
        }

        private void VerifyMe_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    VerifyMe.BackColor = ColorTranslator.FromHtml("#FF353535");
                }));
            }

            else
            {
                VerifyMe.BackColor = ColorTranslator.FromHtml("#FF353535");
            }
        }

        private void VerifyMe_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    VerifyMe.BackColor = ColorTranslator.FromHtml("#FF111111");
                }));
            }

            else
            {
                VerifyMe.BackColor = ColorTranslator.FromHtml("#FF111111");
            }
        }

        private void btnLoginTwitter_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnTwitterLogin.BackColor = ColorTranslator.FromHtml("#FF353535");
                }));
            }

            else
            {
                btnTwitterLogin.BackColor = ColorTranslator.FromHtml("#FF353535");
            }
        }

        private void btnLoginTwitter_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnTwitterLogin.BackColor = ColorTranslator.FromHtml("#FF111111");
                }));
            }

            else
            {
                btnTwitterLogin.BackColor = ColorTranslator.FromHtml("#FF111111");
            }
        }

        private void btnSend_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnSend.BackColor = ColorTranslator.FromHtml("#FF353535");
                }));
            }

            else
            {
                btnSend.BackColor = ColorTranslator.FromHtml("#FF353535");
            }
        }

        private void btnSend_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnSend.BackColor = ColorTranslator.FromHtml("#FF111111");
                }));
            }

            else
            {
                btnSend.BackColor = ColorTranslator.FromHtml("#FF111111");
            }
        }

        private void btnAuth_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnAuth.BackColor = ColorTranslator.FromHtml("#FF353535");
                }));
            }

            else
            {
                btnAuth.BackColor = ColorTranslator.FromHtml("#FF353535");
            }
        }

        private void btnAuth_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnAuth.BackColor = ColorTranslator.FromHtml("#FF111111");
                }));
            }

            else
            {
                btnAuth.BackColor = ColorTranslator.FromHtml("#FF111111");
            }
        }

        private void btnDisconnect_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnDisconnect.BackColor = ColorTranslator.FromHtml("#FF353535");
                }));
            }

            else
            {
                btnDisconnect.BackColor = ColorTranslator.FromHtml("#FF353535");
            }
        }

        private void btnDisconnect_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnDisconnect.BackColor = ColorTranslator.FromHtml("#FF111111");
                }));
            }

            else
            {
                btnDisconnect.BackColor = ColorTranslator.FromHtml("#FF111111");
            }
        }

        private void btnTwitterLogout_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnTwitterLogout.BackColor = ColorTranslator.FromHtml("#FF353535");
                }));
            }

            else
            {
                btnTwitterLogout.BackColor = ColorTranslator.FromHtml("#FF353535");
            }
        }

        private void btnTwitterLogout_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnTwitterLogout.BackColor = ColorTranslator.FromHtml("#FF111111");
                }));
            }

            else
            {
                btnTwitterLogout.BackColor = ColorTranslator.FromHtml("#FF111111");
            }
        }

        private void btnEncrypt_MouseEnter(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnEncrypt.BackColor = ColorTranslator.FromHtml("#FF353535");
                }));
            }

            else
            {
                btnEncrypt.BackColor = ColorTranslator.FromHtml("#FF353535");
            }
        }

        private void btnEncrypt_MouseLeave(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnEncrypt.BackColor = ColorTranslator.FromHtml("#FF111111");
                }));
            }

            else
            {
                btnEncrypt.BackColor = ColorTranslator.FromHtml("#FF111111");
            }
        }

        private void btnEncrypt_MouseClick(object sender, MouseEventArgs e)
        {
            Image img;
            string text = "";
            if (encrypt)
            {
                img = (Image)(Properties.Resources.Lock_Open);
                text = "Unencrypted";
                encrypt = false;
            }

            else
            {
                img = (Image)(Properties.Resources.Lock_Closed);
                text = "Encrypted";
                encrypt = true;
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    btnEncrypt.Image = img;
                    lblEncrypt.Text = text;
                }));
            }

            else
            {
                btnEncrypt.Image = img;
                lblEncrypt.Text = text;
            }


        }

        private void appendLog(string msg)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate { this.appendLog(msg); }));
            else
            {
                tbLog.AppendText(msg + Environment.NewLine);
            }
        }

        private void changeContactList(string userName, bool add)
        {
            if (cbxContacts.Enabled)
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate { this.changeContactList(userName, add); }));
                else if (add)
                    cbxContacts.Items.Add(userName);
                else if (!add)
                    for (int i = 0; i < cbxContacts.Items.Count; i++)
                        if (cbxContacts.Items[i].ToString() == userName)
                        {
                            cbxContacts.Items.RemoveAt(i);
                            break;
                        }
            }
            else { }
        }

        //check whether both parties are authenticated//
        private void OnTimerEvent(object sender, EventArgs e)
        {
            string sID = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
            string rID = "";
            //check if contact is facebook user or twitter user
            if (contactMsg)//if true, contact is twitter user
            {
                rID = profile.ScreenName;
            }

            else// contact is fbuser
            {
                FacebookUser fbuser = client.GetUser(tbid.Text);
                rID = fbuser.name;
            }
            DBConnect db = new DBConnect();
            int urStatus = db.retrieveStatus(sID, rID);
            int buddyStatus = db.retrieveStatus(rID, sID);

            if (urStatus == 1 && buddyStatus == 1)
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                    {
                        tbpass2.Enabled = false;
                        tbxInput.Enabled = true;
                        tbLog.Enabled = true;
                        lblCompleteInval.Visible = false;
                        lblCompleteVal.Visible = true;
                        btnEncrypt.Enabled = true;
                        metroTabControl1.SelectedTab = metroTabPage3;
                    }));
                else
                {
                    tbpass2.Enabled = false;
                    tbxInput.Enabled = true;
                    tbLog.Enabled = true;
                    lblCompleteInval.Visible = false;
                    lblCompleteVal.Visible = true;
                    btnEncrypt.Enabled = true;
                    metroTabControl1.SelectedTab = metroTabPage3;

                }

                mytimer.Stop();
                dbTimer.Interval = 20000;
                dbTimer.Tick += new System.EventHandler(deleteDb);
                dbTimer.Start();
                if (contactMsg)
                {
                    now = zone.ToUniversalTime(DateTime.Now);
                    msgTimer.Start();
                }

            }

            else
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                    {
                        lblCompleteVal.Visible = false;
                        lblCompleteInval.Visible = true;
                        tbxInput.Enabled = false;
                        btnEncrypt.Enabled = false;
                    }));
                else
                {
                    lblCompleteVal.Visible = false;
                    lblCompleteInval.Visible = true;
                    tbxInput.Enabled = false;
                    btnEncrypt.Enabled = false;
                }

            }
        }

        private void OnExpiredEvent(object sender, EventArgs e)
        {
            string rID = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
            string sID = "";
            if (contactMsg)
            {
                sID = profile.ScreenName;
            }

            else
            {
                FacebookUser fbuser = client.GetUser(tbid.Text);
                sID = fbuser.name;
            }
            DBConnect db = new DBConnect();
            int status = db.retrieveStatus(sID, rID);

            if (status == 1)
            {
                expiredTimer.Stop();
            }

            else
            {
                db.Delete(sID, rID, tbpass.Text);
                MetroMessageBox.Show(this, "Session passphrase has expired! Please send again", "JointChat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                    {
                        tbpass.Enabled = true;
                        lblSendInval.Visible = true;
                        lblSendVal.Visible = false;
                    }));
                else
                {
                    tbpass.Enabled = true;
                    lblSendInval.Visible = true;
                    lblSendVal.Visible = false;
                }

                expiredTimer.Stop();
            }


        }

        //Query Twitter Message//
        private void OnMsgEvent(object sender, EventArgs e)
        {

            IEnumerable<TwitterDirectMessage> directMessages = service.ListDirectMessagesReceived(new ListDirectMessagesReceivedOptions());
            IEnumerable<TwitterDirectMessage> sentMessages = service.ListDirectMessagesSent(new ListDirectMessagesSentOptions());

            if (string.IsNullOrEmpty((string)cbxContacts.Items[cbxContacts.SelectedIndex]))
            {
                string name = "";

                name = profile.ScreenName;


                //Delete everything related to user from database//
                DBConnect db = new DBConnect();
                db.DeleteAllFromUser(name);
                btnTwitterLogout_Click(sender, e);
            }
            else
            {
                string receiver = (string)cbxContacts.Items[cbxContacts.SelectedIndex];

                if (directMessages != null && sentMessages != null)
                {
                    foreach (TwitterDirectMessage dm in directMessages)
                    {
                        if (now < dm.CreatedDate || now == dm.CreatedDate)
                        {
                            if (dm.SenderScreenName.Equals(receiver))
                            {
                                //Console.WriteLine(dm.Text);
                                for (int i = 0; i < duplicateMsg.Count; i++)
                                {
                                    if (dm.Id.Equals(duplicateMsg[i]))
                                    {
                                        duplicate = true;
                                        break;
                                    }

                                    else
                                    {
                                        continue;
                                    }
                                }

                                if (duplicate)
                                {
                                    continue;
                                }

                                else
                                {
                                    if (encrypt)
                                    {
                                        dm.Text = MyCrypto.AESDecrypt(dm.Text, tbpass2.Text, 256, "CBC");
                                    }
                                    msg.Add(dm);
                                    duplicateMsg.Add(dm.Id);
                                }

                            }

                        }

                    }

                    foreach (TwitterDirectMessage dm in sentMessages)
                    {
                        if (now < dm.CreatedDate || now == dm.CreatedDate)
                        {
                            if (dm.RecipientScreenName.Equals(receiver))
                            {
                                //Console.WriteLine(dm.Text);


                                for (int i = 0; i < duplicateMsg.Count; i++)
                                {
                                    if (dm.Id.Equals(duplicateMsg[i]))
                                    {
                                        duplicate = true;
                                        break;
                                    }

                                    else
                                    {
                                        continue;
                                    }
                                }

                                if (duplicate)
                                {
                                    continue;
                                }

                                else
                                {
                                    if (encrypt)
                                    {
                                        dm.Text = MyCrypto.AESDecrypt(dm.Text, tbpass.Text, 256, "CBC");
                                    }
                                    msg.Add(dm);
                                    duplicateMsg.Add(dm.Id);
                                }

                            }

                        }

                    }

                }

                msg.Sort((ps1, ps2) => DateTime.Compare(ps1.CreatedDate, ps2.CreatedDate));
                for (int i = 0; i < msg.Count; i++)
                {
                    TwitterDirectMessage dm = msg[i];
                    appendLog(dm.CreatedDate + " " + dm.SenderScreenName + ":  " + dm.Text);
                }

                msg.Clear();
                now = zone.ToUniversalTime(DateTime.Now);
            }
        }

        private void deleteDb(object sender, EventArgs e)
        {
            string sID = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
            string rID = "";
            if (contactMsg)
            {
                rID = profile.ScreenName;
            }

            else
            {
                FacebookUser fbuser = client.GetUser(tbid.Text);
                rID = fbuser.name;
            }
            DBConnect db = new DBConnect();
            db.Delete(sID, rID, tbpass2.Text);
            dbTimer.Stop();

        }

        private void btnLoginTwitter_Click(object sender, EventArgs e)
        {
            // Step 1 - Retrieve an OAuth Request Token
            requestToken = service.GetRequestToken();
            // Step 2 - Redirect to the OAuth Authorization URL
            Uri uri = service.GetAuthorizationUri(requestToken);
            Process.Start(uri.ToString());
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbid.Text) && !string.IsNullOrEmpty(tbpw.Text))
                client.Login(tbid.Text, tbpw.Text);
        }

        private void VerifyMe_Click(object sender, EventArgs e)
        {
            //Step 3 - Exchange the Request Token for an Access Token
            if (!string.IsNullOrEmpty(tbVerify.Text))
            {
                string verifier = (string)tbVerify.Text; // <-- This is input into your application by your user
                try
                {
                    access = service.GetAccessToken(requestToken, verifier);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MetroMessageBox.Show(this, "Unsuccessful Twitter Login", "JointChat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Step 4 - User authenticates using the Access Token
                service.AuthenticateWith(access.Token, access.TokenSecret);
                profile = service.GetUserProfile(new GetUserProfileOptions());
                twitterLogon = true;

                if (profile == null)
                {
                    MetroMessageBox.Show(this, "Unsuccessful Twitter Login. Please get another pin!", "JointChat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                        {
                            lblCurrentTwitter.Text = profile.ScreenName;
                            panelCurrentUser.Visible = true;
                            btnTwitterLogin.Visible = false;
                            lblVerify.Visible = false;
                            tbVerify.Visible = false;
                            VerifyMe.Visible = false;
                            btnTwitterLogout.Visible = true;
                        }));
                else
                {
                    lblCurrentTwitter.Text = profile.ScreenName;
                    panelCurrentUser.Visible = true;
                    btnTwitterLogin.Visible = false;
                    lblVerify.Visible = false;
                    tbVerify.Visible = false;
                    VerifyMe.Visible = false;
                    btnTwitterLogout.Visible = true;
                }

                if (fbLogon)
                {

                }

                else
                {
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            btnAuth.Enabled = true;
                            btnSend.Enabled = true;
                            tbphone.Enabled = true;
                            tbemail.Enabled = true;
                            tbpass.Enabled = true;
                            tbpass2.Enabled = true;
                            cbxContacts.Enabled = true;

                        }));
                    else
                    {
                        btnAuth.Enabled = true;
                        btnSend.Enabled = true;
                        tbphone.Enabled = true;
                        tbemail.Enabled = true;
                        tbpass.Enabled = true;
                        tbpass2.Enabled = true;
                        cbxContacts.Enabled = true;
                    }
                }


                MetroMessageBox.Show(this, "Successful Twitter Login", "JointChat", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TwitterCursorList<TwitterUser> contacts = service.ListFriends(new ListFriendsOptions());

                foreach (TwitterUser friends in contacts)
                {
                    changeContactList(friends.ScreenName, true);
                }

                metroTabControl1.SelectedTab = metroTabPage2;


            }

            else
            {
                MetroMessageBox.Show(this, "Please enter your pin", "JointChat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnTwitterLogout_Click(object sender, EventArgs e)
        {

            if (fbLogon)
            {
                TwitterCursorList<TwitterUser> contacts = service.ListFriends(new ListFriendsOptions());
                bool buddyName = false;
                foreach (TwitterUser friends in contacts)
                {
                    changeContactList(friends.ScreenName, false);
                }
                for (int i = 0; i < contacts.Count; i++)
                {
                    TwitterUser friend = contacts[i];
                    if (lblBuddy.Text.Equals(friend.ScreenName))
                    {
                        buddyName = true;
                        break;
                    }
                    else
                    {
                        buddyName = false;
                    }
                }

                if (buddyName)
                {
                    tbLog.Clear();
                    cbxContacts.Items.Clear();
                    tbemail.Clear();
                    tbpass.Clear();
                    tbpass2.Clear();
                    tbphone.Clear();
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            lblBuddy.Text = "";
                            btnEncrypt.Enabled = false;
                            tbxInput.Enabled = false;
                            lblSendVal.Visible = false;
                            lblSendInval.Visible = true;
                            lblAuthVal.Visible = false;
                            lblAuthInval.Visible = true;
                            lblCompleteVal.Visible = false;
                            lblCompleteInval.Visible = true;
                            tbLog.Enabled = false;
                            tbpass.Enabled = true;
                            tbpass2.Enabled = true;
                            cbxContacts.Enabled = true;
                        }));
                    else
                    {
                        lblBuddy.Text = "";
                        btnEncrypt.Enabled = false;
                        tbxInput.Enabled = false;
                        lblSendVal.Visible = false;
                        lblSendInval.Visible = true;
                        lblAuthVal.Visible = false;
                        lblAuthInval.Visible = true;
                        lblCompleteVal.Visible = false;
                        lblCompleteInval.Visible = true;
                        tbLog.Enabled = false;
                        tbpass.Enabled = true;
                        tbpass2.Enabled = true;
                        cbxContacts.Enabled = true;
                    }

                    msgTimer.Stop();

                }

                else
                {

                }
            }
            else
            {
                tbLog.Clear();
                cbxContacts.Items.Clear();
                tbemail.Clear();
                tbpass.Clear();
                tbpass2.Clear();
                tbphone.Clear();

                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                    {
                        btnAuth.Enabled = false;
                        btnSend.Enabled = false;
                        btnEncrypt.Enabled = false;
                        tbphone.Enabled = false;
                        tbemail.Enabled = false;
                        tbpass.Enabled = false;
                        tbpass2.Enabled = false;
                        tbxInput.Enabled = false;
                        cbxContacts.Enabled = false;
                        panelCurrentUser.Visible = false;
                        lblSendVal.Visible = false;
                        lblSendInval.Visible = true;
                        lblAuthVal.Visible = false;
                        lblAuthInval.Visible = true;
                        lblCompleteVal.Visible = false;
                        lblCompleteInval.Visible = true;
                        tbLog.Enabled = false;
                    }));
                else
                {
                    btnAuth.Enabled = false;
                    btnSend.Enabled = false;
                    btnEncrypt.Enabled = false;
                    tbphone.Enabled = false;
                    tbemail.Enabled = false;
                    tbpass.Enabled = false;
                    tbpass2.Enabled = false;
                    tbxInput.Enabled = false;
                    cbxContacts.Enabled = false;
                    panelCurrentUser.Visible = false;
                    lblSendVal.Visible = false;
                    lblSendInval.Visible = true;
                    lblAuthVal.Visible = false;
                    lblAuthInval.Visible = true;
                    lblCompleteVal.Visible = false;
                    lblCompleteInval.Visible = true;
                    tbLog.Enabled = false;
                }

            }

            tbVerify.Clear();
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate
                {
                    lblCurrentTwitter.Text = "";
                    btnTwitterLogin.Visible = true;
                    lblVerify.Visible = true;
                    tbVerify.Visible = true;
                    VerifyMe.Visible = true;
                    btnTwitterLogout.Visible = false;
                }));
            else
            {
                lblCurrentTwitter.Text = "";
                btnTwitterLogin.Visible = true;
                lblVerify.Visible = true;
                tbVerify.Visible = true;
                VerifyMe.Visible = true;
                btnTwitterLogout.Visible = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Get passphrase & Split into two parts before sending

            if (cbxContacts.SelectedItem != null && !string.IsNullOrEmpty(tbpass.Text) && !string.IsNullOrEmpty(tbemail.Text) && !string.IsNullOrEmpty(tbphone.Text))
            {

                String pass1;
                String pass2;
                String passphrase = tbpass.Text;
                if (passphrase.Length > 2)
                {

                    String name = "";
                    string selected = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
                    int passlength = passphrase.Length;
                    if ((passlength % 2) == 0)
                    {
                        int half = passlength / 2;
                        pass1 = passphrase.Substring(0, half);
                        pass2 = passphrase.Substring(half, half);
                        Console.WriteLine(pass1 + " " + pass2);
                    }
                    else
                    {
                        int half = (passlength + 1) / 2;
                        pass1 = passphrase.Substring(0, half);
                        pass2 = passphrase.Substring(half, half - 1);
                        Console.WriteLine(pass1 + " " + pass2);
                    }

                    if (twitterLogon && fbLogon)
                    {
                        TwitterCursorList<TwitterUser> contacts = service.ListFriends(new ListFriendsOptions());
                        bool check = false;
                        for (int i = 0; i < contacts.Count; i++)
                        {
                            TwitterUser twitteruser = contacts[i];
                            if (selected.Equals(twitteruser.ScreenName))
                            {
                                check = true;
                                break;
                            }

                            else
                            {
                                continue;
                            }
                        }

                        if (check)
                        {
                            name = profile.ScreenName;
                            contactMsg = true;
                        }

                        else
                        {
                            FacebookUser fbuser = client.GetUser(tbid.Text);
                            name = fbuser.name;
                            contactMsg = false;
                        }
                    }
                    else if (twitterLogon && !fbLogon)
                    {
                        name = profile.ScreenName;
                        contactMsg = true;
                    }

                    else if (!twitterLogon && fbLogon)
                    {
                        FacebookUser fbuser = client.GetUser(tbid.Text);
                        name = fbuser.name;
                        contactMsg = false;
                    }

                    try
                    {
                        //Send 1st part
                        MailMessage message1 = new MailMessage();
                        message1.To.Add(tbemail.Text);
                        message1.Subject = "Hi! This is an authentication request from " + name;
                        message1.From = new MailAddress("jointchat1749@gmail.com");
                        message1.Body = "Please enter this as the first part of the passphrase: " + pass1;
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential("jointchat1749@gmail.com", "jointchat123");
                        smtp.Send(message1);

                        Match match = Regex.Match(tbphone.Text, @"[@]");
                        if (match.Success)
                        {
                            //Send 2nd part
                            MailMessage message2 = new MailMessage();
                            message2.To.Add(tbphone.Text);
                            message2.Subject = "Hi! This is an authentication request from " + name;
                            message2.From = new MailAddress("jointchat1749@gmail.com");
                            message2.Body = "Please enter this as the second part of the passphrase: " + pass2;
                            smtp.Send(message2);
                        }

                        else
                        {
                            //Send 2nd part (Phone)
                            FBChatterApp.SmsSender.SendSMS("d408b513", "f2441919", "JointChat", tbphone.Text, "Hi! This is an authentication request from " + name + "\n" + "Please enter this as the second part of the passphrase: " + pass2);
                        }


                        //store passphrase in database
                        DBConnect db = new DBConnect();
                        db.Insert(name, selected, passphrase);
                        //db.Backup();

                        if (this.InvokeRequired)
                            this.Invoke(new MethodInvoker(delegate
                            {
                                cbxContacts.Enabled = false;
                                tbpass.Enabled = false;
                                lblSendInval.Visible = false;
                                lblSendVal.Visible = true;
                            }));
                        else
                        {
                            cbxContacts.Enabled = false;
                            tbpass.Enabled = false;
                            lblSendInval.Visible = false;
                            lblSendVal.Visible = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);


                        if (this.InvokeRequired)
                            this.Invoke(new MethodInvoker(delegate
                            {
                                lblSendInval.Visible = true;
                                lblSendVal.Visible = false;
                            }));
                        else
                        {
                            lblSendInval.Visible = true;
                            lblSendVal.Visible = false;
                        }

                    }
                }

                else
                {
                    MetroMessageBox.Show(this, "Please enter at least more than 3 letters for your passphrase.", "JointChat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Please enter required fields. Remember to select a Contact.", "JointChat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((string)cbxContacts.Items[cbxContacts.SelectedIndex]))
            {
                string selected = (string)cbxContacts.Items[cbxContacts.SelectedIndex];
                string name = "";

                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                    {
                        lblBuddy.Text = selected;
                    }));
                else
                {
                    lblBuddy.Text = selected;
                }

                if (twitterLogon && fbLogon)
                {
                    TwitterCursorList<TwitterUser> contacts = service.ListFriends(new ListFriendsOptions());
                    bool check = false;
                    for (int i = 0; i < contacts.Count; i++)
                    {
                        TwitterUser twitteruser = contacts[i];
                        if (selected.Equals(twitteruser.ScreenName))
                        {
                            check = true;
                            break;
                        }

                        else
                        {
                            continue;
                        }
                    }

                    if (check)
                    {
                        name = profile.ScreenName;
                    }

                    else
                    {
                        FacebookUser fbuser = client.GetUser(tbid.Text);
                        name = fbuser.name;
                    }
                }
                else if (twitterLogon && !fbLogon)
                {
                    name = profile.ScreenName;
                }

                else if (!twitterLogon && fbLogon)
                {
                    FacebookUser fbuser = client.GetUser(tbid.Text);
                    name = fbuser.name;
                }

                DBConnect db = new DBConnect();
                string dbPassphrase = db.retrievePass(selected, name);

                if (dbPassphrase.Equals(tbpass2.Text))
                {
                    db.Update(selected, name);
                    mytimer.Start();

                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            lblAuthInval.Visible = false;
                            lblAuthVal.Visible = true;
                        }));
                    else
                    {
                        lblAuthInval.Visible = false;
                        lblAuthVal.Visible = true;
                    }
                }

                else
                {
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            lblAuthInval.Visible = true;
                            lblAuthVal.Visible = false;
                        }));
                    else
                    {
                        lblAuthInval.Visible = true;
                        lblAuthVal.Visible = false;
                    }
                }

            }
        }

        //Make sure no empty spaces between passphrase//
        private void tbpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        //Make sure no empty spaces between passphrase//
        private void tbpass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }
    }
}
