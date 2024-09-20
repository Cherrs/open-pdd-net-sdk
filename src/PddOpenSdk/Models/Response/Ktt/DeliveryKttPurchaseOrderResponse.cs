namespace PddOpenSdk.Models.Response.Ktt;
public partial class DeliveryKttPurchaseOrderResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("pdd_ktt_purchase_order_delivery_response")]
    public PddKttPurchaseOrderDeliveryResponseResponse PddKttPurchaseOrderDeliveryResponse { get; set; }
    public partial class PddKttPurchaseOrderDeliveryResponseResponse : PddResponseModel
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

