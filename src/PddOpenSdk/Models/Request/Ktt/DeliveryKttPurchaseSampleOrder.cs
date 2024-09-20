namespace PddOpenSdk.Models.Request.Ktt;
public partial class DeliveryKttPurchaseSampleOrder
{

    /// <summary>
    /// 请求信息
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 物流公司id
        /// </summary>
        [JsonPropertyName("logistics_id")]
        public int? LogisticsId { get; set; }

        /// <summary>
        /// 物流公司名
        /// </summary>
        [JsonPropertyName("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("waybill_no")]
        public string WaybillNo { get; set; }

    }

}

