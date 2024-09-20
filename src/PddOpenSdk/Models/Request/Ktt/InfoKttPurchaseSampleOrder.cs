namespace PddOpenSdk.Models.Request.Ktt;
public partial class InfoKttPurchaseSampleOrder
{

    /// <summary>
    /// 请求参数
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

    }

}

