namespace PddOpenSdk.Models.Request.Ktt;
public partial class CreateKttOrderLogistic
{

    /// <summary>
    /// 物流公司编码
    /// </summary>
    [JsonPropertyName("logisticsId")]
    public int? LogisticsId { get; set; }

    /// <summary>
    /// 物流公司名称
    /// </summary>
    [JsonPropertyName("logisticsName")]
    public string LogisticsName { get; set; }

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("orderSn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 发货子单号列表，无子单号视为整单发货
    /// </summary>
    [JsonPropertyName("subOrderSnList")]
    public List<string> SubOrderSnList { get; set; }

    /// <summary>
    /// 运单号
    /// </summary>
    [JsonPropertyName("waybillNo")]
    public string WaybillNo { get; set; }

}

