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
        [JsonProperty("password")]
        private string Password{get;set;}

        [JsonProperty("username")]
        private string Username { get; set; }

        public UserInfo(string password,string username)
        {
            this.Password = password;
            this.Username = username;
        }
    }
}
