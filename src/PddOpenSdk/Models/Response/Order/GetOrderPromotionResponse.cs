namespace PddOpenSdk.Models.Response.Order;
public partial class GetOrderPromotionResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("order_promotion_get_response")]
    public OrderPromotionGetResponseResponse OrderPromotionGetResponse { get; set; }
    public partial class OrderPromotionGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 订单优惠信息列表
        /// </summary>
        [JsonPropertyName("order_promotion_list")]
        public List<OrderPromotionListResponse> OrderPromotionList { get; set; }
        public partial class OrderPromotionListResponse : PddResponseModel
        {

            /// <summary>
            /// 订单号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 商家优惠信息
            /// </summary>
            [JsonPropertyName("seller_discount_details")]
            public List<SellerDiscountDetailsResponse> SellerDiscountDetails { get; set; }
            public partial class SellerDiscountDetailsResponse : PddResponseModel
            {

                /// <summary>
                /// 优惠金额。单位：元
                /// </summary>
                [JsonPropertyName("discount")]
                public double? Discount { get; set; }

                /// <summary>
                /// 优惠描述
                /// </summary>
                [JsonPropertyName("discount_desc")]
                public string DiscountDesc { get; set; }

            }

        }

    }

}

