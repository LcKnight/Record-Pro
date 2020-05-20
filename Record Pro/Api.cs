using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
namespace Record_Pro
{
    class Api
    {
        public const string baseurl = "http://yuh.ziqiang.net.cn/api/";
        public const string APIKey = "INSERT_API_KEY_HERE";
        public string jsonRaw;
        private static readonly HttpClient HttpClient;
        //HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
        static Api()
        {
            HttpClient = new HttpClient();
        }
        public Api()
        {

        }



    }
}
