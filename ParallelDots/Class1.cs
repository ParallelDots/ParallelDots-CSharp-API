using System;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.IO;

namespace ParallelDots
{
    public class paralleldots
    {
        string api_key;
        public string host = "https://apis.paralleldots.com/v4/";
        
        public paralleldots(string api_key)
        {
            this.api_key = api_key;
        }

        public string abuse(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "abuse";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "abuse_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "custom_classifier";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("category", category);
                request.AddHeader("cache-control", "no-cache");
               // request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "emotion";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", "en");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "emotion";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", lang_code);
                Console.WriteLine(text,this.api_key);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content.ToString());
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
                var url = host + "emotion_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", "yhdP8m39eFkuVeAR6flcrpeki3dAzzVIKNzA9OUGyiU");
                request.AddParameter("text", text_list);
                request.AddParameter("lang_code", "en");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "emotion_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                    var url = host + "facial_emotion";
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    request.AddParameter("api_key", this.api_key);
                    request.AddHeader("cache-control", "no-cache");
                    //request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
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
                var url = host + "facial_emotion";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("url", url_image);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "intent";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "intent_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "keywords";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "keywords_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "language_detection";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "language_detection_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "multilang_keywords";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "ner";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "ner_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string ner(string text,string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "ner";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else {
                return "{ \"Error\": \"API key does not exist\" }";
            }            
        }

        public string ner_batch(JArray text_list,string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "ner_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                    var url = host + "nsfw";
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    request.AddParameter("api_key", this.api_key);
                    request.AddHeader("cache-control", "no-cache");
                    //request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
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
                var url = host + "nsfw";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("url", url_image);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                    var url = host + "object_recognizer";
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    request.AddParameter("api_key", this.api_key);
                    request.AddHeader("cache-control", "no-cache");
                    //request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
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
                var url = host + "object_recognizer";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("url", url_image);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "phrase_extractor";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "phrase_extractor_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                    var url = host + "popularity";
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    request.AddParameter("api_key", this.api_key);
                    request.AlwaysMultipartFormData = true;
                    request.AddHeader("cache-control", "no-cache");
                    //request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
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
                var url = host + "popularity";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("url", url_image);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "sentiment";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", "en");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "sentiment";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "sentiment_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddParameter("lang_code", "en");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "sentiment_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string sarcasm(string text)
        {
            if (this.api_key != null)
            {
                var url = host + "sarcasm";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", "en");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string sarcasm(string text, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "sarcasm";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string sarcasm_batch(JArray text_list)
        {
            if (this.api_key != null)
            {
                var url = host + "sarcasm_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddParameter("lang_code", "en");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string sarcasm_batch(JArray text_list, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "sarcasm_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string target_sentiment(string text,string entity)
        {
            if (this.api_key != null)
            {
                var url = host + "target/sentiment";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("entity", entity);
                request.AddParameter("lang_code", "en");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string target_sentiment(string text,string entity, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "target/sentiment";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddParameter("lang_code", lang_code);
                request.AddParameter("entity", entity);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string target_sentiment_batch(JArray text_list,string entity)
        {
            if (this.api_key != null)
            {
                var url = host + "target/sentiment_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddParameter("entity", entity);
                request.AddParameter("lang_code", "en");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("source", "c#wrapper");
                IRestResponse response = client.Execute(request);
                return response.Content.ToString();
            }
            else
            {
                return "{ \"Error\": \"API key does not exist\" }";
            }
        }

        public string target_sentiment_batch(JArray text_list, string entity, string lang_code)
        {
            if (this.api_key != null)
            {
                var url = host + "target/sentiment_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("entity", entity);
                request.AddParameter("text", text_list);
                request.AddParameter("lang_code", lang_code);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "similarity";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text_1", text_1);
                request.AddParameter("text_2", text_2);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "taxonomy";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "taxonomy_batch";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text_list);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = host + "text_parser";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddParameter("text", text);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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
                var url = "https://apis.paralleldots.com/usage";
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddParameter("api_key", this.api_key);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("Content-Type", "multipart/form-data");
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

