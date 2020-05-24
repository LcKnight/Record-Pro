using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.RegularExpressions;
namespace Record_Pro
{
    class Api
    {
        public enum StatusCode
        {
            Created,                  //表明创建成功
            Conflict,                 //表明创建重复
            OK,                       //200
        }
        public const string baseurl = "https://yuh.ziqiang.net.cn/";
        public const string APIKey = "INSERT_API_KEY_HERE";
        //public string jsonRaw;
        private static HttpClient HttpClient;
        private static Regex rx;
        public string Token;
        static Api()
        {
            HttpClient = new HttpClient();
            string pattern;
            pattern = @"token"":""(.*)""}";
            rx = new Regex(pattern, RegexOptions.Compiled);
            
        }
        
        public string SignUpUserAsync(UserBase user)
        {
            //HttpResponseMessage x = await HttpClient.PostAsync(baseurl + "register?"+user, content);
            HttpContent content = new StringContent(" ");
            var x = HttpClient.PostAsync(baseurl + "register?"+user.ToString(), content).Result;
            return x.StatusCode.ToString();
        }
        public bool SignIn(UserBase user)
        {
            HttpContent content = new StringContent(" ");
            var x = HttpClient.PostAsync(baseurl + "login?" + user.ToString(), content).Result;
            if (x.StatusCode.ToString() == "OK")
            {
                Token = rx.Match(x.Content.ReadAsStringAsync().Result).Groups[1].Value;
;
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<UserBills> GetUserBillsAsync(string token,int days)
        {
            List<UserBills> userbills = null;
            try
            {
                HttpResponseMessage x = HttpClient.GetAsync("https://yuh.ziqiang.net.cn/api/UserBills?token=" + token + "&days=" + days).Result;
                string tempdata = x.Content.ReadAsStringAsync().Result;
                userbills = JsonConvert.DeserializeObject<List<UserBills>>(tempdata);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return userbills;

        }
        public string PostUserBillsAsync(PostBill postbill)
        {

            string json = JsonConvert.SerializeObject(postbill);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage x = HttpClient.PostAsync(baseurl + "/api/UserBills?", content).Result;
            return x.StatusCode.ToString();
        }
        public string DeleteUserBillsAsync(string token,int id)
        {
            HttpResponseMessage x = HttpClient.DeleteAsync(baseurl + "/api/UserBills?" + "id=" + id + "&token=" + token).Result;
            return x.StatusCode.ToString();

        }
        public string PutUserBillsAsync(string token, int id, PostBill postbill)
        {
            
            string json = JsonConvert.SerializeObject(postbill);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage x = HttpClient.PutAsync(baseurl + "/api/UserBills?" + "id=" + id + "&token=" + token, content).Result;
            return x.StatusCode.ToString(); 
        }



    }
}
