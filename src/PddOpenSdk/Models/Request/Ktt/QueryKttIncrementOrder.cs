namespace PddOpenSdk.Models.Request.Ktt;
public partial class QueryKttIncrementOrder
{

    /// <summary>
    /// 团号
    /// </summary>
    [JsonPropertyName("activity_no")]
    public string ActivityNo { get; set; }

    /// <summary>
    /// 售后状态, 可选 0-未发起售后 1-退款中 2-退款成功 3-待处理 4-拒绝退款 6-待(顾客)退货 7-待(团长)确认退货 8-(顾客)撤销 9-(系统)关闭
    /// </summary>
    [JsonPropertyName("after_sales_status")]
    public int? AfterSalesStatus { get; set; }

    /// <summary>
    /// 取消状态, 可选 0-未取消 1-已取消
    /// </summary>
    [JsonPropertyName("cancel_status")]
    public int? CancelStatus { get; set; }

    /// <summary>
    /// 更新结束时间
    /// </summary>
    [JsonPropertyName("end_updated_at")]
    public long EndUpdatedAt { get; set; }

    /// <summary>
    /// 页码
    /// </summary>
    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 发货状态, 可选 0-未发货 1-已发货 2-部分发货 3-已收货
    /// </summary>
    [JsonPropertyName("shipping_status")]
    public int? ShippingStatus { get; set; }

    /// <summary>
    /// 更新起始时间
    /// </summary>
    [JsonPropertyName("start_updated_at")]
    public long StartUpdatedAt { get; set; }

    /// <summary>
    /// 核销状态, 可选 0-未核销 1-已核销 2-部分核销
    /// </summary>
    [JsonPropertyName("verification_status")]
    public int? VerificationStatus { get; set; }

}

