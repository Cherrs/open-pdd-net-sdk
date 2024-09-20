namespace PddOpenSdk.Models.Request.Ktt;
public partial class GetKttOrder
{

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

}

