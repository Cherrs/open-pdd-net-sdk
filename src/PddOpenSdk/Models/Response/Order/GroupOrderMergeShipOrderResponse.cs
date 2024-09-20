namespace PddOpenSdk.Models.Response.Order;
public partial class GroupOrderMergeShipOrderResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("merge_ship_order_group_response")]
    public MergeShipOrderGroupResponseResponse MergeShipOrderGroupResponse { get; set; }
    public partial class MergeShipOrderGroupResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 订单分组结果
        /// </summary>
        [JsonPropertyName("order_group_list")]
        public List<OrderGroupListResponse> OrderGroupList { get; set; }
        public partial class OrderGroupListResponse : PddResponseModel
        {

            /// <summary>
            /// 可以合并发货的订单号列表。不同列表之间不能合并发货
            /// </summary>
            [JsonPropertyName("order_sn_list")]
            public List<string> OrderSnList { get; set; }

        }

    }

}

