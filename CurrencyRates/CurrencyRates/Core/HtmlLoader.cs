using CurrencyRates.core;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;

namespace CurrencyRates.bank
{
    class HtmlLoader
    {
        readonly WebClient client;
        string url;

        public string URL { get => url; set { url = value; } }
        public HtmlLoader(IParserSettings settings)
        {
            client = new WebClient();
            url = $"{settings.URLtoParse}";
        }

        public string GetPage ()
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                    StreamReader stream = new StreamReader(response.GetResponseStream());

                    string sourse = stream.ReadToEnd();

                    response.Close();
                    stream.Close();
                    return sourse;
                }
            }
            catch { }
            return null;
        }
        public string GetPage(string url)
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                    StreamReader stream = new StreamReader(response.GetResponseStream());

                    string sourse = stream.ReadToEnd();

                    response.Close();
                    stream.Close();
                    return sourse;
                }
            }
            catch { }
            return null;
        }
    }
}
