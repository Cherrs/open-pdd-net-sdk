namespace PddOpenSdk.Models.Request.Ktt;
public partial class InfoKttPurchaseSupplierGoods
{

    /// <summary>
    /// 列表请求信息
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 商品前台状态 1：在售中 2：已下架 3：发布中 4：已驳回 5：未发布
        /// </summary>
        [JsonPropertyName("goods_front_status")]
        public int? GoodsFrontStatus { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

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

    }

}

