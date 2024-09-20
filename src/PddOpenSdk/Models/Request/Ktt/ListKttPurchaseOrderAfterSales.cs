namespace PddOpenSdk.Models.Request.Ktt;
public partial class ListKttPurchaseOrderAfterSales
{

    /// <summary>
    /// 售后状态：不传 -全部，1-待供货商处理，2-已退款，3-已同意退款，待入账，4-待团长处理，5-已同意退货，待团长退货，6-团长已退货，待供货商确认收货，7-已撤销，8-已驳回，9-退款失败
    /// </summary>
    [JsonPropertyName("open_after_sales_status")]
    public int? OpenAfterSalesStatus { get; set; }

    /// <summary>
    /// 页码
    /// </summary>
    [JsonPropertyName("page_no")]
    public int PageNo { get; set; }

    /// <summary>
    /// 分页大小（1-50）
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 父单号
    /// </summary>
    [JsonPropertyName("parent_order_sn")]
    public string ParentOrderSn { get; set; }

}

