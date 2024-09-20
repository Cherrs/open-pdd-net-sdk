namespace PddOpenSdk.Models.Response.Order;
public partial class OrderOrderSearchResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("search_order_response")]
    public SearchOrderResponseResponse SearchOrderResponse { get; set; }
    public partial class SearchOrderResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 检索出的订单号列表。按照下单时间倒序，最多返回最近的100笔订单
        /// </summary>
        [JsonPropertyName("order_sn_list")]
        public List<string> OrderSnList { get; set; }

    }

}

