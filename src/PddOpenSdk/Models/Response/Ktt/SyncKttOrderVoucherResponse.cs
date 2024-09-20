namespace PddOpenSdk.Models.Response.Ktt;
public partial class SyncKttOrderVoucherResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 新增的券码个数
            /// </summary>
            [JsonPropertyName("created_number")]
            public int? CreatedNumber { get; set; }

            /// <summary>
            /// 更新的券码个数
            /// </summary>
            [JsonPropertyName("updated_number")]
            public int? UpdatedNumber { get; set; }

        }

    }

}

