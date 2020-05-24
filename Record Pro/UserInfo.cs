using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Record_Pro
{
    class UserInfo
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("password")]
        public string Password{get;set;}

        [JsonProperty("name")]
        public string Username { get; set; }

        //public UserInfo(string password,string username)
        //{
        //    this.Id = 0;
        //    this.Password = password;
        //    this.Username = username;
        //    this.Token = "";
        //}
        //public UserInfo(string password, string username,int id,string token)
        //{
        //    this.Id = id;
        //    this.Password = password;
        //    this.Username = username;
        //    this.Token = token;
        //}

    }
    class UserBase
    {
        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
        public UserBase()
        {

        }
        public override string ToString()
        {
            return "username=" + this.Username + "&" + "password=" + this.Password;
        }
        public UserBase(string username, string password)
        {
            
            this.Password = password;
            this.Username = username;
            
        }
    }
}
