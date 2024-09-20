namespace PddOpenSdk.Models.Request.Ktt;
public partial class DeliveryKttPurchaseOrder
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
    /// 发货子单列表，无子单号视为整单发货
    /// </summary>
    [JsonPropertyName("sub_order_sn_list")]
    public List<string> SubOrderSnList { get; set; }

    /// <summary>
    /// 物流单号
    /// </summary>
    [JsonPropertyName("waybill_no")]
    public string WaybillNo { get; set; }

}

