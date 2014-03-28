using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using agsXMPP;
using agsXMPP.Collections;
using agsXMPP.protocol.client;
using Newtonsoft.Json;
 
namespace Facebook_Connection
{
    public class FacebookChatClient
    {
        private Dictionary<string, FacebookUser> _contacts = new Dictionary<string, FacebookUser>();
        public Dictionary<string, FacebookUser> Contacts { get { return _contacts; } }
        private bool _loggedIn = false;
        public bool LoggedIn { get { return _loggedIn; } }
        private string _clientNick = string.Empty;
        public string ClientNick { get { return _clientNick; } }
        private WebClient wc = new WebClient();
        private XmppClientConnection xcc;
 
        public Action<FacebookUser> OnUserAdded;
        public Action<FacebookUser> OnUserRemoved;
        public Action<Message, FacebookUser> OnMessageReceived;
        public Action<bool> OnLoginResult;
        public Action OnLogout;
        public Action<FacebookUser> OnUserIsTyping;
 
        public void Login(string nick, string pass)
        {
            if (!_loggedIn)
                try
                {
                    xcc = new XmppClientConnection("chat.facebook.com");
                    xcc.OnPresence += new PresenceHandler(UpdateUserList);
                    xcc.OnLogin += new ObjectHandler(OnLogin);
                    xcc.Open(nick, pass);
                }
                catch
                {
                    if (OnLoginResult != null)
                        OnLoginResult(false);
                }
        }
        public void SendMessage(string msg, string receiverName) { xcc.Send(new Message(new Jid(_contacts.First(x => x.Value.name == receiverName).Key), MessageType.chat, msg)); }
        public void Logout() { xcc.Close(); _loggedIn = false; OnLogout(); }
 
        private void UpdateUserList(object sender, Presence pres)
        {
            FacebookUser User = GetUser(pres.From.User);
            User.jid = pres.From.Bare;
            if (pres.Type == PresenceType.available && !Contacts.ContainsKey(pres.From.Bare))
            {
                Contacts.Add(pres.From.Bare, User);
                xcc.MesagageGrabber.Add(new Jid(pres.From.Bare), new BareJidComparer(), new MessageCB(MessageReceived), null);
                if (OnUserAdded != null)
                    OnUserAdded(User);
            }
            else if (pres.Type == PresenceType.unavailable && Contacts.ContainsKey(pres.From.Bare))
            {
                xcc.MesagageGrabber.Remove(new Jid(pres.From.Bare));
                Contacts.Remove(pres.From.Bare);
                if (OnUserRemoved != null)
                    OnUserRemoved(GetUser(pres.From.User));
            }
        }
        private FacebookUser GetUser(string ID)
        {
            ID = ID.Replace("-", string.Empty);
            string jsonResponse = wc.DownloadString("https://graph.facebook.com/" + ID);
            FacebookUser User = JsonConvert.DeserializeObject<FacebookUser>(jsonResponse);
            return User;
        }
        private void OnLogin(object sender)
        {
            _loggedIn = true;
            if (OnLoginResult != null)
                OnLoginResult(true);
            xcc.OnPresence += new PresenceHandler(UpdateUserList);
            Presence p = new Presence(ShowType.chat, "Online");
            p.Type = PresenceType.available;
            xcc.Send(p);
        }
        private void MessageReceived(object sender, Message msg, object data)
        {
            if (string.IsNullOrEmpty(msg.Body) && OnUserIsTyping != null)
            {
                Contacts[msg.From.Bare].isTyping = !Contacts[msg.From.Bare].isTyping;
                OnUserIsTyping(Contacts[msg.From.Bare]);
            }
            else if (OnMessageReceived != null)
            {
                Contacts.First(contact => contact.Key == msg.From.Bare).Value.isTyping = false;
                OnMessageReceived(msg, Contacts.First(contact => contact.Key == msg.From.Bare).Value);
            }
        }
    }
}