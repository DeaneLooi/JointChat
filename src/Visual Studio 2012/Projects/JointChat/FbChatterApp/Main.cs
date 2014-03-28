using Facebook_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JointChatApp;
using System.Text.RegularExpressions;

namespace JointChatApp
{
    public partial class Main : Form
    {
        private FacebookChatClient client;
        private string selected;
        private Timer mytimer = new Timer();
        private Timer dbTimer = new Timer();
        private Timer expiredTimer = new Timer();


        public Main()
        {
            InitializeComponent();

            mytimer.Interval = 10000;
            mytimer.Tick += new System.EventHandler(OnTimerEvent);

            expiredTimer.Interval = 1800000;
            expiredTimer.Tick += new System.EventHandler(OnExpiredEvent);

            client = new FacebookChatClient();

            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate { checkBoxEncryptChannel.Checked = true; }));
            else
            {
                checkBoxEncryptChannel.Checked = true;
            }

            client.OnLoginResult = success =>
            {
                appendLog("Connection to Facebook established!");
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                    {
                        btnAuth.Enabled = true;
                        btnSend.Enabled = true;
                        tbphone.Enabled = true;
                        tbemail.Enabled = true;
                        tbpass.Enabled = true;
                        tbpass2.Enabled = true;
                        lbLogVal.Text = "*Successfully logged in!";
                        lbLogVal.ForeColor = Color.Green;
                    }));
                else
                {
                    btnAuth.Enabled = true;
                    btnSend.Enabled = true;
                    tbphone.Enabled = true;
                    tbemail.Enabled = true;
                    tbpass.Enabled = true;
                    tbpass2.Enabled = true;
                    lbLogVal.Text = "*Successfully logged in!";
                    lbLogVal.ForeColor = Color.Green;
                }
            };

            client.OnLogout = () =>
                {

                    string sID = (string)lbxContacts.Items[lbxContacts.SelectedIndex];
                    FacebookUser fbuser = client.GetUser(tbid.Text);
                    string rID = fbuser.name;
                    DBConnect db = new DBConnect();
                    db.Delete(sID, rID, tbpass2.Text);
                    db.Delete(rID, sID, tbpass.Text);

                    db.Delete(rID, sID, tbpass.Text);
                    appendLog("Client logged out");
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            btnAuth.Enabled = false;
                            btnSend.Enabled = false;
                            tbphone.Enabled = false;
                            tbemail.Enabled = false;
                            tbpass.Enabled = false;
                            tbpass2.Enabled = false;
                            tbemail.Clear();
                            tbpass.Clear();
                            tbpass2.Clear();
                            tbphone.Clear();
                            tbpw.Clear();
                            tbid.Clear();
                            lbLogVal.Text = "*Please login!";
                            lbLogVal.ForeColor = Color.Red;
                            lbSendVal.Visible = false;
                            lbAuthVal.Visible = false;
                            lbStatusVal.Visible = false;
                            lbxContacts.Enabled = true;
                        }));
                    else
                    {
                        btnAuth.Enabled = false;
                        btnSend.Enabled = false;
                        tbphone.Enabled = false;
                        tbemail.Enabled = false;
                        tbpass.Enabled = false;
                        tbpass2.Enabled = false;
                        tbemail.Clear();
                        tbpass.Clear();
                        tbpass2.Clear();
                        tbphone.Clear();
                        tbpw.Clear();
                        tbid.Clear();
                        lbLogVal.Text = "*Please login!";
                        lbLogVal.ForeColor = Color.Red;
                        lbSendVal.Visible = false;
                        lbAuthVal.Visible = false;
                        lbStatusVal.Visible = false;
                        lbxContacts.Enabled = true;
                    }
                };

            client.OnMessageReceived = (msg, user) =>
          {
              string sender = (string)lbxContacts.Items[lbxContacts.SelectedIndex];
              if (user.name.Equals(sender))
              {
                  if (!checkBoxEncryptChannel.Checked)
                  {
                      appendLog(DateTime.Now + " " + user.name + ":  " + msg.Body);
                  }
                  else
                  {
                      appendLog(DateTime.Now + " " + user.name + ":  " + msg.Body);
                      appendLog(DateTime.Now + " " + user.name + ":  " + MyCrypto.AESDecrypt(msg.Body, tbpass2.Text, 256, "CBC"));
                  }
              }

          };

            client.OnUserIsTyping = user => appendLog("The user " + user.name + " " + (user.isTyping ? "started typing" : "stopped typing"));

            client.OnUserAdded = user =>
            {
                appendLog("User " + user.name + " is now available for chat");
                changeContactList(user.name, true);
            };

            client.OnUserRemoved = user =>
            {
                appendLog("User " + user.name + " is no longer available for chat");
                changeContactList(user.name, false);
            };

            tbxInput.KeyPress += new KeyPressEventHandler(tbxInput_KeyPress);
        }

        void tbxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && !string.IsNullOrEmpty(tbxInput.Text) && lbxContacts.SelectedItem != null)
            {
                FacebookUser fbuser = client.GetUser(tbid.Text);
                string user = fbuser.name;

                if (!checkBoxEncryptChannel.Checked)
                {
                    client.SendMessage(tbxInput.Text, (string)lbxContacts.Items[lbxContacts.SelectedIndex]);
                    appendLog(DateTime.Now + " " + user + ":  " + tbxInput.Text);
                }
                else
                {
                    client.SendMessage(
                        MyCrypto.AESEncrypt(tbxInput.Text, tbpass.Text, 256, "CBC"),
                        (string)lbxContacts.Items[lbxContacts.SelectedIndex]);
                    appendLog(DateTime.Now + " " + user + ":  " + tbxInput.Text);
                    appendLog(DateTime.Now + " " + user + ":  " + MyCrypto.AESEncrypt(tbxInput.Text, tbpass.Text, 256, "CBC"));
                }
                tbxInput.ResetText();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbid.Text) && !string.IsNullOrEmpty(tbpw.Text))
                client.Login(tbid.Text, tbpw.Text);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbid.Text) && !string.IsNullOrEmpty(tbpw.Text))
                tbLog.Clear();
            lbxContacts.Items.Clear();
            client.Logout();
        }

        private void changeContactList(string userName, bool add)
        {
            if (lbxContacts.Enabled)
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate { this.changeContactList(userName, add); }));
                else if (add)
                    lbxContacts.Items.Add(userName);
                else if (!add)
                    for (int i = 0; i <= lbxContacts.Items.Count; i++)
                        if (lbxContacts.Items[i].ToString() == userName)
                        {
                            lbxContacts.Items.RemoveAt(i);
                            break;
                        }
            }

            else { }
        }

        private void appendLog(string msg)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate { this.appendLog(msg); }));
            else
            {
                tbLog.AppendText(msg + Environment.NewLine);
                //tbLog.SelectionStart = tbLog.Text.Length;
                //tbLog.ScrollToCaret();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Get passphrase & Split into two parts before sending

            if (lbxContacts.SelectedItem != null && !string.IsNullOrEmpty(tbpass.Text) && !string.IsNullOrEmpty(tbemail.Text) && !string.IsNullOrEmpty(tbphone.Text))
            {
                FacebookUser fbuser = client.GetUser(tbid.Text);
                String pass1;
                String pass2;
                String passphrase = tbpass.Text;
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

                try
                {
                    //Send 1st part
                    MailMessage message1 = new MailMessage();
                    message1.To.Add(tbemail.Text);
                    message1.Subject = "Hi! This is an authentication request from " + fbuser.name;
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
                        message2.Subject = "Hi! This is an authentication request from " + fbuser.name;
                        message2.From = new MailAddress("jointchat1749@gmail.com");
                        message2.Body = "Please enter this as the second part of the passphrase: " + pass2;
                        smtp.Send(message2);
                    }

                    else
                    {
                        //Send 2nd part (Phone)
                        FBChatterApp.SmsSender.SendSMS("d408b513", "f2441919", "JointChat", tbphone.Text, "Hi! This is an authentication request from " + fbuser.name + "\n" + "Please enter this as the second part of the passphrase: " + pass2);
                    }


                    //store passphrase in database
                    DBConnect db = new DBConnect();
                    selected = (string)lbxContacts.Items[lbxContacts.SelectedIndex];
                    db.Insert(fbuser.name, selected, passphrase);
                    //db.Backup();

                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            tbpass.Enabled = false;
                            lbSendVal.Text = "*Passphrase Sent!";
                            lbSendVal.ForeColor = Color.Green;
                            lbSendVal.Visible = true;
                        }));
                    else
                    {
                        tbpass.Enabled = false;
                        lbSendVal.Text = "*Passphrase Sent!";
                        lbSendVal.ForeColor = Color.Green;
                        lbSendVal.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);

                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                            {
                                lbSendVal.Text = "*Error sending passphrase! Please try again!";
                                lbSendVal.ForeColor = Color.Red;
                                lbSendVal.Visible = true;
                            }));
                    else
                    {
                        lbSendVal.Text = "*Error sending passphrase! Please try again!";
                        lbSendVal.ForeColor = Color.Red;
                        lbSendVal.Visible = true;
                    }

                }
            }
        }
        private void tbpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        private void tbpass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (lbxContacts.SelectedItem != null)
            {

                string sID = (string)lbxContacts.Items[lbxContacts.SelectedIndex];
                FacebookUser fbuser = client.GetUser(tbid.Text);
                string rID = fbuser.name;
                DBConnect db = new DBConnect();
                string dbPassphrase = db.retrievePass(sID, rID);

                if (dbPassphrase.Equals(tbpass2.Text))
                {
                    db.Update(sID, rID);
                    mytimer.Start();
                    //db.Delete(sID, rID, dbPassphrase);
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                            {

                                lbAuthVal.Text = "*You're authenticated!";
                                lbAuthVal.ForeColor = Color.Green;
                                lbAuthVal.Visible = true;
                                lbxContacts.Enabled = false;
                            }));
                    else
                    {
                        lbAuthVal.Text = "*You're authenticated!";
                        lbAuthVal.ForeColor = Color.Green;
                        lbAuthVal.Visible = true;
                        lbxContacts.Enabled = false;
                    }
                }
                else
                {
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            lbAuthVal.Text = "*Wrong Passphrase! Please try again!";
                            lbAuthVal.ForeColor = Color.Red;
                            lbAuthVal.Visible = true;
                        }));
                    else
                    {
                        lbAuthVal.Text = "*Wrong Passphrase! Please try again!";
                        lbAuthVal.ForeColor = Color.Red;
                        lbAuthVal.Visible = true;
                    }
                }
            }
        }


        private void OnTimerEvent(object sender, EventArgs e)
        {
            string sID = (string)lbxContacts.Items[lbxContacts.SelectedIndex];
            FacebookUser fbuser = client.GetUser(tbid.Text);
            string rID = fbuser.name;
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
                        lbStatusVal.Text = "*Authentication complete!";
                        lbStatusVal.ForeColor = Color.Green;
                        lbStatusVal.Visible = true;
                    }));
                else
                {
                    tbpass2.Enabled = false;
                    tbxInput.Enabled = true;
                    lbStatusVal.Text = "*Authentication complete!";
                    lbStatusVal.ForeColor = Color.Green;
                    lbStatusVal.Visible = true;
                }

                mytimer.Stop();
                dbTimer.Interval = 10000;
                dbTimer.Tick += new System.EventHandler(deleteDb);
                dbTimer.Start();
            }

            else
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                    {
                        lbStatusVal.Text = "*Incomplete authentication!";
                        lbStatusVal.ForeColor = Color.Red;
                        tbxInput.Enabled = false;
                        lbStatusVal.Visible = true;
                    }));
                else
                {
                    lbStatusVal.Text = "*Incomplete authentication!";
                    lbStatusVal.ForeColor = Color.Red;
                    tbxInput.Enabled = true;
                    lbStatusVal.Visible = true;
                }

            }
        }

        private void OnExpiredEvent(object sender, EventArgs e)
        {
            string rID = (string)lbxContacts.Items[lbxContacts.SelectedIndex];
            FacebookUser fbuser = client.GetUser(tbid.Text);
            string sID = fbuser.name;
            DBConnect db = new DBConnect();
            int status = db.retrieveStatus(sID, rID);

            if (status == 1)
            {
                expiredTimer.Stop();
            }

            else
            {
                db.Delete(sID, rID, tbpass.Text);
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(delegate
                    {
                        tbpass.Enabled = true;
                        lbSendVal.Text = "Session passphrase has expired, please send again";
                    }));
                else
                {
                    tbpass.Enabled = true;
                    lbSendVal.Text = "Session passphrase has expired, please send again";
                }

                expiredTimer.Stop();
            }


        }

        private void deleteDb(object sender, EventArgs e)
        {
            string sID = (string)lbxContacts.Items[lbxContacts.SelectedIndex];
            FacebookUser fbuser = client.GetUser(tbid.Text);
            string rID = fbuser.name;
            DBConnect db = new DBConnect();
            db.Delete(sID, rID, tbpass2.Text);
            dbTimer.Stop();

        }

        private void Main_FormClosing(object sender, FormClosedEventArgs e)
        {
            string sID = (string)lbxContacts.Items[lbxContacts.SelectedIndex];
            FacebookUser fbuser = client.GetUser(tbid.Text);
            string rID = fbuser.name;
            DBConnect db = new DBConnect();
            db.Delete(sID, rID, tbpass2.Text);
            db.Delete(rID, sID, tbpass.Text);
        }
    }
}

