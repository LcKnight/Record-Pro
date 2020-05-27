using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Record_Pro
{
    class UserNotes
    {
        //        [
        //  {
        //    "id": 0,
        //    "content": "string",
        //    "wordcount": 0,
        //    "sentiment": 0,
        //    "tags": "string",
        //    "dateTime": "2020-05-27T11:14:34.579Z",
        //    "userid": 0
        //  }
        //]


        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("content")]
        public string content { get; set; }

        [JsonProperty("wordcount")]
        public int wordcount { get; set; }

        [JsonProperty("sentiment")]
        public int sentiment { get; set; }

        [JsonProperty("tags")]
        public string tags { get; set; }

        [JsonProperty("dateTime")]
        public DateTime dateTime { get; set; }

        [JsonProperty("userid")]
        public int userid { get; set; }
    }
    class UserPostNotes
    {
        //        {
        //  "content": "string",
        //  "wordcount": 0,
        //  "dateTime": "2020-05-27T11:17:35.329Z",
        //  "token": "string"
        //}

        [JsonProperty("content")]
        public string content { get; set; }

        [JsonProperty("wordcount")]
        public int wordcount { get; set; }

        [JsonProperty("dateTime")]
        public DateTime dateTime { get; set; }

        [JsonProperty("token")]
        public string token { get; set; }
    }
    class UserPutNotes
    {
        //        {
        //  "content": "string",
        //  "wordcount": 0,
        //  "dateTime": "2020-05-27T11:17:35.329Z",
        //  "token": "string"
        //}

        [JsonProperty("content")]
        public string content { get; set; }

        [JsonProperty("wordcount")]
        public int wordcount { get; set; }

        [JsonProperty("dateTime")]
        public DateTime dateTime { get; set; }

        [JsonProperty("token")]
        public string token { get; set; }
    }


}
