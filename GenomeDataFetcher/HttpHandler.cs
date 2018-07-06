//using MicShared.Log;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace GenomeDataFetcher
{
    public class Result
    {
        public bool status { get; set; }
        public string data { get; set; }
    }
    public static class HttpHandler
    {
        private static Object _locker;
        static HttpHandler()
        {
            _locker = new Object();
        }
        public static async Task<Result> Get(string api, string action)
        {
            using (var client = new HttpClient())
            {
                ServicePointManager.UseNagleAlgorithm = true;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.CheckCertificateRevocationList = true;
                ServicePointManager.DefaultConnectionLimit = 1000;

                client.BaseAddress = new Uri(api);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(action).ConfigureAwait(false);
                var result = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    return new Result { status = true, data = result };
                }
                else
                    return new Result { status = false, data = result };
            }
        }

        public static async Task<Result> Post<T>(string api, string action, T messagebody)
        {
            using (var client = new HttpClient())
            {
                ServicePointManager.UseNagleAlgorithm = true;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.CheckCertificateRevocationList = true;
                ServicePointManager.DefaultConnectionLimit = 1000;

                client.BaseAddress = new Uri(api);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync(action, messagebody).ConfigureAwait(false);
                var result = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    return new Result { status = true, data = result };
                }
                else
                {
                    return new Result { status = false, data = result };
                }
            }

        }
    }
}
