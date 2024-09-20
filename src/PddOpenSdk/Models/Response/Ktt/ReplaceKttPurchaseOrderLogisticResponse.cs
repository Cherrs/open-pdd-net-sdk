namespace PddOpenSdk.Models.Response.Ktt;
public partial class ReplaceKttPurchaseOrderLogisticResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("ktt_purchase_order_logistics_replace_response")]
    public KttPurchaseOrderLogisticsReplaceResponseResponse KttPurchaseOrderLogisticsReplaceResponse { get; set; }
    public partial class KttPurchaseOrderLogisticsReplaceResponseResponse : PddResponseModel
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
            [JsonPropertyName("is_all_success")]
            public bool? IsAllSuccess { get; set; }

        }

    }

}

