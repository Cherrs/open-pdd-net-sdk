namespace PddOpenSdk.Models.Request.Order;
public partial class GroupOrderMergeShipOrder
{

    /// <summary>
    /// 订单列表，最多支持100个
    /// </summary>
    [JsonPropertyName("order_list")]
    public List<OrderListModel> OrderList { get; set; }
    public partial class OrderListModel
    {

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

    }

}

