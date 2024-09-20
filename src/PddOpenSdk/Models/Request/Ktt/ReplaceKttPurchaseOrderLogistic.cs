namespace PddOpenSdk.Models.Request.Ktt;
public partial class ReplaceKttPurchaseOrderLogistic
{

    /// <summary>
    /// 新物流公司id（与物流公司名两者至少填一）
    /// </summary>
    [JsonPropertyName("new_logistics_id")]
    public int? NewLogisticsId { get; set; }

    /// <summary>
    /// 新物流公司名（与物流公司id两者至少填一）
    /// </summary>
    [JsonPropertyName("new_logistics_name")]
    public string NewLogisticsName { get; set; }

    /// <summary>
    /// 新运单号
    /// </summary>
    [JsonPropertyName("new_waybill_no")]
    public string NewWaybillNo { get; set; }

    /// <summary>
    /// 旧运单号
    /// </summary>
    [JsonPropertyName("old_waybill_no")]
    public string OldWaybillNo { get; set; }

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

}

