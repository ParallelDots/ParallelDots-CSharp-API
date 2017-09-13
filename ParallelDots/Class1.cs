using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;

namespace ParallelDots
{
    public class api
    {
        string api_key;
        public api(string api_key)
        {
            this.api_key = api_key;
        }
        public string sentiment(string text)
        {
            var url = "https://apis.paralleldots.com/v2/sentiment?text=" + text + "&api_key=" + this.api_key;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }
        public string similarity(string text_1, string text_2)
        {
            var url = "https://apis.paralleldots.com/v2/similarity?text_1=" + text_1 + "&text_2=" + text_2 + "&api_key=" + this.api_key;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }

        public string ner(string text)
        {
            var url = "https://apis.paralleldots.com/v2/ner?text=" + text + "&api_key=" + this.api_key;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }
        public string keywords(string text)
        {
            var url = "https://apis.paralleldots.com/v2/keywords?text=" + text + "&api_key=" + this.api_key;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }

        public string taxonomy(string text)
        {
            var url = "https://apis.paralleldots.com/v2/taxonomy?text=" + text + "&api_key=" + this.api_key;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }
        public string emotion(string text)
        {
            var url = "https://apis.paralleldots.com/v2/emotion?text=" + text + "&api_key=" + this.api_key;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }
        public string intent(string text)
        {
            var url = "https://apis.paralleldots.com/v2/intent?text=" + text + "&api_key=" + this.api_key;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }
        public string multilang(string text, string lang_code)
        {
            var url = "https://apis.paralleldots.com/v2/multilang?text=" + text + "&api_key=" + this.api_key + "&lang_code=" + lang_code;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }
        public string abuse(string text)
        {
            var url = "https://apis.paralleldots.com/v2/abuse?text=" + text + "&api_key=" + this.api_key;
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                var response = client.UploadValues(url, values);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
        }
    }
}

