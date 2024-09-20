namespace PddOpenSdk.Models.Request.Ktt;
public partial class DeleteKttOrderLogistic
{

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("orderSn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 子单号列表，无子单号视为整单删除物流
    /// </summary>
    [JsonPropertyName("subOrderSnList")]
    public List<string> SubOrderSnList { get; set; }

    /// <summary>
    /// 运单号
    /// </summary>
    [JsonPropertyName("waybillNo")]
    public string WaybillNo { get; set; }

}

