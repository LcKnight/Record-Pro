using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Record_Pro
{
    //    {
    //id integer($int32)
    //账单ID

    //category    string
    //nullable: true
    //账单分类

    //type    boolean
    //支出类型，true表示指出，false表示收入

    //amount  number($float)
    //金额

    //remark  string
    //nullable: true
    //备注

    //date    string
    //nullable: true
    //格式化日期

    //userid  integer($int32)
    //用户ID

    //}
    class UserBills
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("category")]
        public string category { get; set; }

        [JsonProperty("type")]
        public bool Type { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("datetime")]
        public DateTime Date { get; set; }

        [JsonProperty("userid")]
        public int UserId { get; set; }
    }
    class PostBill
    {
        [JsonProperty("category")]
        public string category { get; set; }

        [JsonProperty("type")]
        public bool Type { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("datetime")]
        public DateTime Date { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
    
}
