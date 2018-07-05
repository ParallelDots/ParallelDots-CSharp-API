using System;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.IO;

namespace ParallelDots
{
    public class paralleldots
    {
        string api_key;
        string host = "https://apis.paralleldots.com/v3/";
        
        public paralleldots(string api_key)
        {
            this.api_key = api_key;
        }

        public string abuse(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "abuse?api_key=" + this.api_key + "&text=" + text;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string abuse_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "abuse_batch?api_key=" + this.api_key + "&text=" + text_list;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string custom_classifier(string text, JObject category)
        {
            if (this.api_key != null)
            {
                var url = host + "custom_classifier?api_key=" + this.api_key + "&text=" + text + "&category=" + category;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string emotion(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "emotion?api_key=" + this.api_key + "&text=" + text + "&lang_code=en";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string emotion(string text, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "emotion?api_key=" + this.api_key + "&text=" + text + "&lang_code=" + lang_code;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string emotion_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "emotion_batch?api_key=" + this.api_key + "&text=" + text_list + "&lang_code=en";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string emotion_batch(JArray text_list, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "emotion_batch?api_key=" + this.api_key + "&text=" + text_list + "&lang_code=" + lang_code;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string facial_emotion(string path)
        {
            if (File.Exists(path))
            {
                if (this.api_key != null)
                {
                    var url = host + "facial_emotion?api_key=" + this.api_key;
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
                    request.AddHeader("source", "c#wrapper");
                    request.AddFile("file", path);
                    request.AlwaysMultipartFormData = true;
                    IRestResponse response = client.Execute(request);
                    return response.Content.ToString();
                }
                else
                {
                    return "{ \"Error\": \"API key does not exist\" }";
                }
            }
            else
            {
                return "{ \"Error\": \"File does not exist\" }";
            }
        }

        public string facial_emotion_url(String url_image)
        {
            if (this.api_key != null)
            {
                var url = host + "facial_emotion?api_key=" + this.api_key + "&url=" + url_image;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string intent(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "intent?api_key=" + this.api_key + "&text=" + text;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string intent_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "intent_batch?api_key=" + this.api_key + "&text=" + text_list;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string keywords(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "keywords?api_key=" + this.api_key + "&text=" + text;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string keywords_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "keywords_batch?api_key=" + this.api_key + "&text=" + text_list;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string language_detection(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "language_detection?api_key=" + this.api_key + "&text=" + text;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string language_detection_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "language_detection_batch?api_key=" + this.api_key + "&text=" + text_list;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string multilang_keywords(string text, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "multilang_keywords?api_key=" + this.api_key + "&text=" + text + "&lang_code=" + lang_code;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string ner(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "ner?api_key=" + this.api_key + "&text=" + text;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string ner_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "ner_batch?api_key=" + this.api_key + "&text=" + text_list;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string nsfw(string path)
        {
            if (File.Exists(path))
            {
                if (this.api_key != null)
                {
                    var url = host + "nsfw?api_key=" + this.api_key;
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);                    
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
                    request.AddHeader("source", "c#wrapper");
                    request.AddFile("file", path);
                    request.AlwaysMultipartFormData = true;
                    IRestResponse response = client.Execute(request);
                    return response.Content.ToString();
                }
                else
                {
                    return "{ \"Error\": \"API key does not exist\" }";
                }
            }
            else
            {
                return "{ \"Error\": \"File does not exist\" }";
            }
        }

        public string nsfw_url (String url_image)
        {
            if (this.api_key != null)
            {
                var url = host + "nsfw?api_key=" + this.api_key +"&url=" +url_image;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string object_recognizer(string path)
        {
            if (File.Exists(path))
            {
                if (this.api_key != null)
                {
                    var url = host + "object_recognizer?api_key=" + this.api_key;
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
                    request.AddHeader("source", "c#wrapper");
                    request.AddFile("file", path);
                    request.AlwaysMultipartFormData = true;
                    IRestResponse response = client.Execute(request);
                    return response.Content.ToString();
                }
                else
                {
                    return "{ \"Error\": \"API key does not exist\" }";
                }
            }
            else
            {
                return "{ \"Error\": \"File does not exist\" }";
            }
        }

        public string object_recognizer_url(String url_image)
        {
            if (this.api_key != null)
            {
                var url = host + "object_recognizer?api_key=" + this.api_key + "&url=" + url_image;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string phrase_extractor(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "phrase_extractor?api_key=" + this.api_key + "&text=" + text;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string phrase_extractor_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "phrase_extractor_batch?api_key=" + this.api_key + "&text=" + text_list;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string popularity(string path)
        {
            if (File.Exists(path))
            {
                if (this.api_key != null)
                {
                    var url = host + "popularity?api_key=" + this.api_key;
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    request.AlwaysMultipartFormData = true;
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
                    request.AddHeader("source", "c#wrapper");
                    request.AddFile("file", path);
                    IRestResponse response = client.Execute(request);
                    return response.Content.ToString();
                }
                else
                {
                    return "{ \"Error\": \"API key does not exist\" }";
                }
            }
            else {
                return "{ \"Error\": \"File does not exist\" }";
            }                        
        }

        public string popularity_url(string url_image)
        {
            if (this.api_key != null)
            {
                var url = host + "popularity?api_key=" + this.api_key + "&url=" + url_image;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string sentiment(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "sentiment?api_key=" + this.api_key + "&text=" + text + "&lang_code=en";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string sentiment(string text, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "sentiment?api_key=" + this.api_key + "&text=" + text + "&lang_code=" + lang_code;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string sentiment_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "sentiment_batch?api_key=" + this.api_key + "&text=" + text_list + "&lang_code=en";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string sentiment_batch(JArray text_list, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "sentiment_batch?api_key=" + this.api_key + "&text=" + text_list + "&lang_code=" + lang_code;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string similarity(string text_1, string text_2)
        {
            if (this.api_key != null)
            {
                var url = host + "similarity?api_key=" + this.api_key+ "&text_1=" + text_1 + "&text_2=" + text_2;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }      

        public string taxonomy(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "taxonomy?api_key=" + this.api_key + "&text=" + text;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string taxonomy_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "taxonomy_batch?api_key=" + this.api_key + "&text=" + text_list;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string text_parser(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "text_parser?api_key=" + this.api_key + "&text=" + text;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string usage()
	    {
            if (this.api_key != null)
            {
                var url = "https://apis.paralleldots.com/usage?api_key=" + this.api_key;
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }		    
	    }        
    }
}
