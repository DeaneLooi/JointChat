namespace Facebook_Connection
{
    public class FacebookUser
    {
        public string jid { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string gender { get; set; }
        public string locale { get; set; }
        public bool isTyping = false;
    }
}