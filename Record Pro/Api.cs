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
        //User-Information
        //用于用户的登入注册
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
        //UserBills
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



        //UserNotes
        public List<UserNotes> GetUserNotesAsync(string token, int days)
        {
            List<UserNotes> usernotes = null;
            try
            {
                HttpResponseMessage x = HttpClient.GetAsync("https://yuh.ziqiang.net.cn/api/UserNotes?token=" + token + "&days=" + days).Result;
                string tempdata = x.Content.ReadAsStringAsync().Result;
                usernotes = JsonConvert.DeserializeObject<List<UserNotes>>(tempdata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return usernotes;

        }
        public string PostUserNotesAsync(UserPostNotes postnote)
        {

            string json = JsonConvert.SerializeObject(postnote);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage x = HttpClient.PostAsync(baseurl + "/api/UserNotes?", content).Result;
            return x.StatusCode.ToString();
        }
        public string DeleteUserNotesAsync(string token, int id)
        {
            HttpResponseMessage x = HttpClient.DeleteAsync(baseurl + "/api/UserNotes?" + "id=" + id + "&token=" + token).Result;
            return x.StatusCode.ToString();

        }
        public string PutUserNotesAsync(string token, int id, UserPutNotes postnotes)
        {

            string json = JsonConvert.SerializeObject(postnotes);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage x = HttpClient.PutAsync(baseurl + "/api/UserNotes?" + "id=" + id + "&token=" + token, content).Result;
            return x.StatusCode.ToString();
        }





        //UserFaces
        public List<UserFaces> GetUserFacesAsync(string token, int days)
        {
            List<UserFaces> userfaces = null;
            try
            {
                HttpResponseMessage x = HttpClient.GetAsync("https://yuh.ziqiang.net.cn/api/UserFaces?token=" + token + "&days=" + days).Result;
                string tempdata = x.Content.ReadAsStringAsync().Result;
                userfaces = JsonConvert.DeserializeObject<List<UserFaces>>(tempdata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return userfaces;

        }
        public string DeleteUserFacesAsync(string token, int id)
        {
            HttpResponseMessage x = HttpClient.DeleteAsync(baseurl + "/api/UserFaces?" + "id=" + id + "&token=" + token).Result;
            return x.StatusCode.ToString();

        }
        public string PostUserFacesAsync(byte[] img)
        {


            HttpContent content = new ByteArrayContent(img);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("multipart/form-data,");
            HttpResponseMessage x = HttpClient.PostAsync(baseurl + "/api/UserFaces?", content).Result;
            return x.StatusCode.ToString();
        }

    }
}
