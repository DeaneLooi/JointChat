using System.Collections.Generic;
using System.Net;

namespace FBChatterApp
{
    class SmsSender
    {
        public static void SendSMS(string apikey, string secret, string from, string to, string text)
        {
            string uri = string.Format("http://rest.nexmo.com/sms/json?api_key={0}&api_secret={1}&from={2}&to={3}&text={4}", apikey, secret, from, to, text);
            var json = new WebClient().DownloadString(uri);
        }

        public static void SendTestSMS()
        {
            string uri = string.Format("https://rest.nexmo.com/sms/json?api_key=d408b513&api_secret=f2441919&from=JointChat&to=6596553581&text=Welcome+to+JointChat");
            var json = new WebClient().DownloadString(uri);
        }

    }

    public class Message
    {
        public string To { get; set; }
        public string Messageprice { get; set; }
        public string Status { get; set; }
        public string MessageId { get; set; }
        public string RemainingBalance { get; set; }



    }



}