namespace PddOpenSdk.Models.Response.Ktt;
public partial class ListKttPurchaseOrderResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("ktt_purchase_order_response")]
    public KttPurchaseOrderResponseResponse KttPurchaseOrderResponse { get; set; }
    public partial class KttPurchaseOrderResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("order_list")]
            public List<OrderListResponse> OrderList { get; set; }

            /// <summary>
            /// 总数
            /// </summary>
            [JsonPropertyName("total_count")]
            public long? TotalCount { get; set; }
            public partial class OrderListResponse : PddResponseModel
            {

                /// <summary>
                /// 团号
                /// </summary>
                [JsonPropertyName("activity_no")]
                public string ActivityNo { get; set; }

                /// <summary>
                /// 团标题
                /// </summary>
                [JsonPropertyName("activity_title")]
                public string ActivityTitle { get; set; }

                /// <summary>
                /// 售后状态0-未发起售后，1-待供货商处理，2-已退款，3-已同意退款，待入账，4-待团长处理，5-已同意退货，待团长退货，6-团长已退货，待供货商确认收货，7-已撤销，8-已驳回，9-退款失败
                /// </summary>
                [JsonPropertyName("after_sales_status")]
                public int? AfterSalesStatus { get; set; }

                /// <summary>
                /// 团长备注
                /// </summary>
                [JsonPropertyName("business_note")]
                public string BusinessNote { get; set; }

                /// <summary>
                /// 团员备注
                /// </summary>
                [JsonPropertyName("buyer_memo")]
                public string BuyerMemo { get; set; }

                /// <summary>
                /// 取消状态：0-未取消，1-已取消
                /// </summary>
                [JsonPropertyName("cancel_status")]
                public int? CancelStatus { get; set; }

                /// <summary>
                /// 创单时间
                /// </summary>
                [JsonPropertyName("create_time")]
                public long? CreateTime { get; set; }

                /// <summary>
                /// 自定义项列表
                /// </summary>
                [JsonPropertyName("custom_item_list")]
                public List<CustomItemListResponse> CustomItemList { get; set; }

                /// <summary>
                /// 赠品列表
                /// </summary>
                [JsonPropertyName("gift_order_list")]
                public List<GiftOrderListResponse> GiftOrderList { get; set; }

                /// <summary>
                /// 物流列表(汇总)
                /// </summary>
                [JsonPropertyName("logistics_list")]
                public List<LogisticsListResponse> LogisticsList { get; set; }

                /// <summary>
                /// 团员昵称
                /// </summary>
                [JsonPropertyName("nick_name")]
                public string NickName { get; set; }

                /// <summary>
                /// 支付金额(分)
                /// </summary>
                [JsonPropertyName("order_amount")]
                public long? OrderAmount { get; set; }

                /// <summary>
                /// 订单号
                /// </summary>
                [JsonPropertyName("order_sn")]
                public string OrderSn { get; set; }

                /// <summary>
                /// 接龙号
                /// </summary>
                [JsonPropertyName("participate_no")]
                public int? ParticipateNo { get; set; }

                /// <summary>
                /// 支付状态（0：未支付已确认，1：已支付，2：未支付待确认，3：待结算，4-已关闭）
                /// </summary>
                [JsonPropertyName("pay_status")]
                public int? PayStatus { get; set; }

                /// <summary>
                /// 支付时间
                /// </summary>
                [JsonPropertyName("pay_time")]
                public long? PayTime { get; set; }

                /// <summary>
                /// 收货人地址(市)
                /// </summary>
                [JsonPropertyName("receiver_address_city")]
                public string ReceiverAddressCity { get; set; }

                /// <summary>
                /// 收货人地址(详细地址)
                /// </summary>
                [JsonPropertyName("receiver_address_detail")]
                public string ReceiverAddressDetail { get; set; }

                /// <summary>
                /// 收货人地址(区)
                /// </summary>
                [JsonPropertyName("receiver_address_district")]
                public string ReceiverAddressDistrict { get; set; }

                /// <summary>
                /// 收货人地址(省)
                /// </summary>
                [JsonPropertyName("receiver_address_province")]
                public string ReceiverAddressProvince { get; set; }

                /// <summary>
                /// 收货人电话
                /// </summary>
                [JsonPropertyName("receiver_mobile")]
                public string ReceiverMobile { get; set; }

                /// <summary>
                /// 收货人名称
                /// </summary>
                [JsonPropertyName("receiver_name")]
                public string ReceiverName { get; set; }

                /// <summary>
                /// 退款金额（分）
                /// </summary>
                [JsonPropertyName("refund_amount")]
                public long? RefundAmount { get; set; }

                /// <summary>
                /// 运费
                /// </summary>
                [JsonPropertyName("shipping_amount")]
                public long? ShippingAmount { get; set; }

                /// <summary>
                /// 发货状态（0：未发货 1：已发货 3：部分发货）
                /// </summary>
                [JsonPropertyName("shipping_status")]
                public int? ShippingStatus { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("sub_order_list")]
                public List<SubOrderListResponse> SubOrderList { get; set; }

                /// <summary>
                /// 供货商备注
                /// </summary>
                [JsonPropertyName("supplier_remark")]
                public string SupplierRemark { get; set; }

                /// <summary>
                /// 团长昵称
                /// </summary>
                [JsonPropertyName("supply_nick_name")]
                public string SupplyNickName { get; set; }

                /// <summary>
                /// 团长昵称备注
                /// </summary>
                [JsonPropertyName("supply_nick_name_remark")]
                public string SupplyNickNameRemark { get; set; }

                /// <summary>
                /// 更新时间
                /// </summary>
                [JsonPropertyName("updated_at")]
                public long? UpdatedAt { get; set; }
                public partial class CustomItemListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 标题
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                    /// <summary>
                    /// 值
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; }

                }
                public partial class GiftOrderListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 赠品外部编码
                    /// </summary>
                    [JsonPropertyName("external_sku_id")]
                    public string ExternalSkuId { get; set; }

                    /// <summary>
                    /// 赠品名
                    /// </summary>
                    [JsonPropertyName("goods_name")]
                    public string GoodsName { get; set; }

                    /// <summary>
                    /// 赠品数量
                    /// </summary>
                    [JsonPropertyName("goods_number")]
                    public int? GoodsNumber { get; set; }

                    /// <summary>
                    /// 宿主子订单号
                    /// </summary>
                    [JsonPropertyName("host_sub_order_sn")]
                    public string HostSubOrderSn { get; set; }

                }
                public partial class LogisticsListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 物流公司
                    /// </summary>
                    [JsonPropertyName("shipping_company")]
                    public string ShippingCompany { get; set; }

                    /// <summary>
                    /// 物流单号
                    /// </summary>
                    [JsonPropertyName("shipping_no")]
                    public string ShippingNo { get; set; }

                    /// <summary>
                    /// 若为子单发货，返回发货的子单列表
                    /// </summary>
                    [JsonPropertyName("sub_order_sn_list")]
                    public List<string> SubOrderSnList { get; set; }

                }
                public partial class SubOrderListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 取消件数
                    /// </summary>
                    [JsonPropertyName("already_cancel_number")]
                    public int? AlreadyCancelNumber { get; set; }

                    /// <summary>
                    /// 取消状态：0-未取消，1-已取消
                    /// </summary>
                    [JsonPropertyName("cancel_status")]
                    public int? CancelStatus { get; set; }

                    /// <summary>
                    /// 商品编号
                    /// </summary>
                    [JsonPropertyName("external_sku_id")]
                    public string ExternalSkuId { get; set; }

                    /// <summary>
                    /// 商品总价
                    /// </summary>
                    [JsonPropertyName("goods_amount")]
                    public long? GoodsAmount { get; set; }

                    /// <summary>
                    /// 商品供货价(分)
                    /// </summary>
                    [JsonPropertyName("goods_cost_price")]
                    public long? GoodsCostPrice { get; set; }

                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonPropertyName("goods_id")]
                    public long? GoodsId { get; set; }

                    /// <summary>
                    /// 商品名
                    /// </summary>
                    [JsonPropertyName("goods_name")]
                    public string GoodsName { get; set; }

                    /// <summary>
                    /// 商品数量
                    /// </summary>
                    [JsonPropertyName("goods_number")]
                    public int? GoodsNumber { get; set; }

                    /// <summary>
                    /// 下单价
                    /// </summary>
                    [JsonPropertyName("goods_price")]
                    public long? GoodsPrice { get; set; }

                    /// <summary>
                    /// 商品规格描述
                    /// </summary>
                    [JsonPropertyName("goods_specification")]
                    public string GoodsSpecification { get; set; }

                    /// <summary>
                    /// 退款金额（分）
                    /// </summary>
                    [JsonPropertyName("refund_amount")]
                    public long? RefundAmount { get; set; }

                    /// <summary>
                    /// 
                    /// </summary>
                    [JsonPropertyName("sku_id")]
                    public long? SkuId { get; set; }

                    /// <summary>
                    /// 子单号
                    /// </summary>
                    [JsonPropertyName("sub_order_sn")]
                    public string SubOrderSn { get; set; }

                }

            }

        }

    }

}

