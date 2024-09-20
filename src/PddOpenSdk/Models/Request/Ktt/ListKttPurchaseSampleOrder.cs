namespace PddOpenSdk.Models.Request.Ktt;
public partial class ListKttPurchaseSampleOrder
{

    /// <summary>
    /// 请求信息
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// -1-未发起售后 1-待团长退货 10-待供货商处理 11-已退货，待供货商处理 20-退款中 30-退款成功 31-已撤销 32-已驳回
        /// </summary>
        [JsonPropertyName("after_sales_status")]
        public int? AfterSalesStatus { get; set; }

        /// <summary>
        /// 取消状态 0-未取消 1-已取消
        /// </summary>
        [JsonPropertyName("cancel_status")]
        public int? CancelStatus { get; set; }

        /// <summary>
        /// 截止更新时间（含）
        /// </summary>
        [JsonPropertyName("end_update_time")]
        public string EndUpdateTime { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public int PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 0- 未发货 1-已发货 （不包含已取消订单）
        /// </summary>
        [JsonPropertyName("shipping_status")]
        public int? ShippingStatus { get; set; }

        /// <summary>
        /// 起始更新时间（含）
        /// </summary>
        [JsonPropertyName("start_updated_time")]
        public string StartUpdatedTime { get; set; }

    }

}

