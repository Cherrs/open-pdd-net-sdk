namespace PddOpenSdk.Models.Request.Order;
public partial class GetOrderPromotion
{

    /// <summary>
    /// 订单号列表，最多10个
    /// </summary>
    [JsonPropertyName("order_sn_list")]
    public List<string> OrderSnList { get; set; }

}

