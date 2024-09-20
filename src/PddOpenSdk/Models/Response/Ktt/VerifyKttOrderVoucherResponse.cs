namespace PddOpenSdk.Models.Response.Ktt;
public partial class VerifyKttOrderVoucherResponse : PddResponseModel
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
            /// 
            /// </summary>
            [JsonPropertyName("refund_times")]
            public int? RefundTimes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("total_verification_times")]
            public int? TotalVerificationTimes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("verified_times")]
            public int? VerifiedTimes { get; set; }

        }

    }

}

