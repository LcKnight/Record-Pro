using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Record_Pro
{
    class UserFaces
    {

        //        [
        //  {
        //    "id": 0,
        //    "filepath": "string",
        //    "gender": 0,
        //    "smile": 0,
        //    "age": 0,
        //    "emotion": "string",
        //    "beauty": "string",
        //    "skinstatus": "string",
        //    "datetime": "2020-05-27T11:20:06.565Z",
        //    "facetoken": "string",
        //    "userid": 0
        //  }
        //]
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("filepath")]
        public string filepath { get; set; }

        [JsonProperty("gender")]
        public int gender { get; set; }

        [JsonProperty("smile")]
        public int smile { get; set; }

        [JsonProperty("age")]
        public int age { get; set; }

        [JsonProperty("emotion")]
        public string emotion { get; set; }

        [JsonProperty("beauty")]
        public string beauty { get; set; }

        [JsonProperty("skinstatus")]
        public string skinstatus { get; set; }

        [JsonProperty("datetime")]
        public DateTime datetime { get; set; }

        [JsonProperty("facetoken")]
        public string facetoken { get; set; }

        [JsonProperty("userid")]
        public int userid { get; set; }

    }
}
