using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using Newtonsoft.Json;


namespace TakipWeb.Service.Core
{
    public static class Operations
    {
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {

            NullValueHandling = NullValueHandling.Ignore,
            Error = (s, e) => { e.ErrorContext.Handled = true; }

        };
        private static readonly Encoding Encoding = Encoding.UTF8;
        private const string Accept = "application/json";

        public static T GetResponse<T>(string url)
        {
            using (var client = new WebClient())
            {
                var model = default(T);
                try
                {
                    var json = client.DownloadString(url);
                    List<string> deseralizeMsg;
                    model = JsonConvert.DeserializeObject<T>(json, GetSerializeSettings(out deseralizeMsg));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                return model;
            }
        }

        public static T PostJson<T>(string url, T myClass)
        {
            var data = JsonConvert.SerializeObject(myClass, JsonSerializerSettings);
            var bytes = Encoding.UTF8.GetBytes(data);

            using (var client = new WebClient())
            {
                ServicePointManager.ServerCertificateValidationCallback +=
                    (sender, certificate, chain, sslPolicyErrors) => true;

                client.Encoding = Encoding;
                client.Headers["Accept"] = Accept;
                client.Headers.Add("Content-Type", Accept);
                T model;

                try
                {
                    var json = Encoding.UTF8.GetString(client.UploadData(url, "POST", bytes));
                    List<string> deseralizeMsg;
                    model = JsonConvert.DeserializeObject<T>(json, GetSerializeSettings(out deseralizeMsg));
                }
                catch (Exception ex)
                {
                    //TODO: log eklenecek.
                    Debug.WriteLine(ex.Message);
                    throw;
                }

                return model;
            }
        }

        private static JsonSerializerSettings GetSerializeSettings(out List<string> deseralizeMsg)
        {
            var messages = new List<string>();

            var settings = new JsonSerializerSettings
            {
                Error = (s, e) =>
                {
                    messages.Add($"Object:{e.ErrorContext.Member}  Message:{e.ErrorContext.Error.Message}");

                    e.ErrorContext.Handled = true;
                }
            };

            deseralizeMsg = messages;

            return settings;
        }
    }
}