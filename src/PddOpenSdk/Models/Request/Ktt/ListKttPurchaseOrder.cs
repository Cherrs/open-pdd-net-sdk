namespace PddOpenSdk.Models.Request.Ktt;
public partial class ListKttPurchaseOrder
{

    /// <summary>
    /// 售后状态：0-未发起售后，1-待供货商处理，2-已退款，3-已同意退款，待入账，4-待团长处理，5-已同意退货，待团长退货，6-团长已退货，待供货商确认收货，7-已撤销，8-已驳回，9-退款失败
    /// </summary>
    [JsonPropertyName("after_sales_status")]
    public int? AfterSalesStatus { get; set; }

    /// <summary>
    /// 取消状态（0：未取消，1：已取消）
    /// </summary>
    [JsonPropertyName("cancel_status")]
    public int? CancelStatus { get; set; }

    /// <summary>
    /// 截止更新时间（含）（毫秒）
    /// </summary>
    [JsonPropertyName("end_updated_time")]
    public long EndUpdatedTime { get; set; }

    /// <summary>
    /// 页码
    /// </summary>
    [JsonPropertyName("page_no")]
    public int PageNo { get; set; }

    /// <summary>
    /// 分页size（1-20）
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 发货状态（0：未发货+部分发货 1：已发货 2：未发货 3：部分发货）
    /// </summary>
    [JsonPropertyName("shipping_status")]
    public int? ShippingStatus { get; set; }

    /// <summary>
    /// 起始更新时间（含）（毫秒）
    /// </summary>
    [JsonPropertyName("start_update_time")]
    public long StartUpdateTime { get; set; }

}

