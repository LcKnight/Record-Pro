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
        public const string baseurl = "http://yuh.ziqiang.net.cn/api/";
        public const string APIKey = "INSERT_API_KEY_HERE";
        //public string jsonRaw;
        private static HttpClient HttpClient;
        private static Regex rx;
        public Api()
        {
            HttpClient = new HttpClient();
            string pattern;
            pattern = @"token"":""<token>""}";
            rx = new Regex(pattern, RegexOptions.Compiled);
        }
        
        public async Task<bool> SignUpUserAsync(HttpContent content)
        {
            HttpResponseMessage x = await HttpClient.PostAsync(baseurl + "/register", content);
            if(x.StatusCode.Equals(409))
            {
                return false;
            }
            else if(x.StatusCode.Equals(200))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<string> SignIn(HttpContent content)
        {
            HttpResponseMessage x = await HttpClient.PostAsync(baseurl + "/login?", content);
            if(x.IsSuccessStatusCode)
            {
                Match a = rx.Match(x.ToString());
                return a.Groups["token"].Value;
            }
            else
            {
                return null;
            }
        }
        public async Task<List<UserBills>> GetUserBillsAsync(string token,int days)
        {
            List<UserBills> userbills = null;
            try
            {
                HttpResponseMessage x = await HttpClient.GetAsync("https://yuh.ziqiang.net.cn/api/UserBills?token=" + token + "&days=" + days);
                string tempdata = await x.Content.ReadAsStringAsync();
                userbills = JsonConvert.DeserializeObject<List<UserBills>>(tempdata);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return userbills;

        }
        public async Task<bool> PostUserBillsAsync(HttpContent content)
        {
            HttpResponseMessage x = await HttpClient.PostAsync(baseurl + "/UserBills?", content);
            if (x.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> DeleteUserBillsAsync(string token,int id)
        {
            HttpResponseMessage x = await HttpClient.DeleteAsync(baseurl + "/UserBills?" + "id=" + id + "&token=" + token);
            if (x.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> PutUserBillsAsync(string token, int id, HttpContent content)
        {
            HttpResponseMessage x = await HttpClient.PutAsync(baseurl + "/UserBills?" + "id=" + id + "&token=" + token, content);
            if (x.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
