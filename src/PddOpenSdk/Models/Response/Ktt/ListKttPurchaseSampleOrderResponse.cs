namespace PddOpenSdk.Models.Response.Ktt;
public partial class ListKttPurchaseSampleOrderResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
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
            /// 结果集
            /// </summary>
            [JsonPropertyName("result")]
            public List<ResultResponse> Result { get; set; }

            /// <summary>
            /// 总数
            /// </summary>
            [JsonPropertyName("total")]
            public int? Total { get; set; }
            public partial class ResultResponse : PddResponseModel
            {

                /// <summary>
                /// 下单团长信息
                /// </summary>
                [JsonPropertyName("activity_user_info")]
                public ActivityUserInfoResponse ActivityUserInfo { get; set; }

                /// <summary>
                /// 收货信息
                /// </summary>
                [JsonPropertyName("address_info")]
                public AddressInfoResponse AddressInfo { get; set; }

                /// <summary>
                /// 售后信息
                /// </summary>
                [JsonPropertyName("after_sale_info")]
                public AfterSaleInfoResponse AfterSaleInfo { get; set; }

                /// <summary>
                /// 是否可以申请退款
                /// </summary>
                [JsonPropertyName("can_apply_refund")]
                public bool? CanApplyRefund { get; set; }

                /// <summary>
                /// 是否有售后
                /// </summary>
                [JsonPropertyName("has_after_sales")]
                public bool? HasAfterSales { get; set; }

                /// <summary>
                /// 子项列表
                /// </summary>
                [JsonPropertyName("order_item_list")]
                public List<OrderItemListResponse> OrderItemList { get; set; }

                /// <summary>
                /// 订单号
                /// </summary>
                [JsonPropertyName("order_sn")]
                public string OrderSn { get; set; }

                /// <summary>
                /// 0-待支付 1-支付中 2-已支付 3-已发货 4-已取消
                /// </summary>
                [JsonPropertyName("order_status")]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// 支付时间
                /// </summary>
                [JsonPropertyName("pay_at")]
                public string PayAt { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [JsonPropertyName("remark")]
                public string Remark { get; set; }

                /// <summary>
                /// 发货状态 0-未发货 1-已发货
                /// </summary>
                [JsonPropertyName("shipping_status")]
                public int? ShippingStatus { get; set; }

                /// <summary>
                /// 总商品金额
                /// </summary>
                [JsonPropertyName("total_goods_amount")]
                public long? TotalGoodsAmount { get; set; }

                /// <summary>
                /// 总商品数量
                /// </summary>
                [JsonPropertyName("total_goods_number")]
                public int? TotalGoodsNumber { get; set; }

                /// <summary>
                /// 总订单金额
                /// </summary>
                [JsonPropertyName("total_order_amount")]
                public long? TotalOrderAmount { get; set; }

                /// <summary>
                /// 物流信息
                /// </summary>
                [JsonPropertyName("trace_info_list")]
                public List<TraceInfoListResponse> TraceInfoList { get; set; }

                /// <summary>
                /// 创建时间
                /// </summary>
                [JsonPropertyName("created_at")]
                public long? CreatedAt { get; set; }

                /// <summary>
                /// 更新时间
                /// </summary>
                [JsonPropertyName("updated_at")]
                public long? UpdatedAt { get; set; }
                public partial class ActivityUserInfoResponse : PddResponseModel
                {

                    /// <summary>
                    /// 下单团长头像
                    /// </summary>
                    [JsonPropertyName("avatar")]
                    public string Avatar { get; set; }

                    /// <summary>
                    /// 下单团长昵称
                    /// </summary>
                    [JsonPropertyName("nick_name")]
                    public string NickName { get; set; }

                    /// <summary>
                    /// 下单团长备注
                    /// </summary>
                    [JsonPropertyName("remark")]
                    public string Remark { get; set; }

                }
                public partial class AddressInfoResponse : PddResponseModel
                {

                    /// <summary>
                    /// 收货地址（市）
                    /// </summary>
                    [JsonPropertyName("city_name")]
                    public string CityName { get; set; }

                    /// <summary>
                    /// 收货地址（区）
                    /// </summary>
                    [JsonPropertyName("district_name")]
                    public string DistrictName { get; set; }

                    /// <summary>
                    /// 收件人电话
                    /// </summary>
                    [JsonPropertyName("mobile")]
                    public string Mobile { get; set; }

                    /// <summary>
                    /// 收货地址（省）
                    /// </summary>
                    [JsonPropertyName("province_name")]
                    public string ProvinceName { get; set; }

                    /// <summary>
                    /// 收货人姓名
                    /// </summary>
                    [JsonPropertyName("receive_name")]
                    public string ReceiveName { get; set; }

                    /// <summary>
                    /// 收件人地址
                    /// </summary>
                    [JsonPropertyName("shipping_address")]
                    public string ShippingAddress { get; set; }

                }
                public partial class AfterSaleInfoResponse : PddResponseModel
                {

                    /// <summary>
                    /// 是否已全部取消
                    /// </summary>
                    [JsonPropertyName("is_all_canceled")]
                    public bool? IsAllCanceled { get; set; }

                    /// <summary>
                    /// 是否已全额退款
                    /// </summary>
                    [JsonPropertyName("is_all_refund")]
                    public bool? IsAllRefund { get; set; }

                    /// <summary>
                    /// 最新的退款成功时间
                    /// </summary>
                    [JsonPropertyName("latest_refund_success_at")]
                    public string LatestRefundSuccessAt { get; set; }

                    /// <summary>
                    /// 最新的售后状态 1-待团长退货 10-待供货商处理 11-已退货，待供货商处理 20-退款中 30-退款成功 31-已撤销 32-已驳回
                    /// </summary>
                    [JsonPropertyName("latest_status")]
                    public int? LatestStatus { get; set; }

                    /// <summary>
                    /// 拍样订单号
                    /// </summary>
                    [JsonPropertyName("order_sn")]
                    public string OrderSn { get; set; }

                    /// <summary>
                    /// 退款金额汇总（已退款+退款中）
                    /// </summary>
                    [JsonPropertyName("refund_amount")]
                    public long? RefundAmount { get; set; }

                    /// <summary>
                    /// 商品退款金额汇总
                    /// </summary>
                    [JsonPropertyName("refund_goods_amount")]
                    public long? RefundGoodsAmount { get; set; }

                    /// <summary>
                    /// 运费退款金额汇总
                    /// </summary>
                    [JsonPropertyName("refund_shipping_amount")]
                    public long? RefundShippingAmount { get; set; }

                    /// <summary>
                    /// 退款中金额汇总
                    /// </summary>
                    [JsonPropertyName("refunding_amount")]
                    public long? RefundingAmount { get; set; }

                    /// <summary>
                    /// 取消件数汇总
                    /// </summary>
                    [JsonPropertyName("supplier_cancel_number")]
                    public int? SupplierCancelNumber { get; set; }

                }
                public partial class OrderItemListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 商品金额
                    /// </summary>
                    [JsonPropertyName("goods_amount")]
                    public long? GoodsAmount { get; set; }

                    /// <summary>
                    /// 商品ID
                    /// </summary>
                    [JsonPropertyName("goods_id")]
                    public long? GoodsId { get; set; }

                    /// <summary>
                    /// 商品名
                    /// </summary>
                    [JsonPropertyName("goods_name")]
                    public string GoodsName { get; set; }

                    /// <summary>
                    /// 购买数量
                    /// </summary>
                    [JsonPropertyName("goods_number")]
                    public int? GoodsNumber { get; set; }

                    /// <summary>
                    /// 商品下单单价
                    /// </summary>
                    [JsonPropertyName("goods_price")]
                    public long? GoodsPrice { get; set; }

                    /// <summary>
                    /// 商品主图
                    /// </summary>
                    [JsonPropertyName("goods_thumb_url")]
                    public string GoodsThumbUrl { get; set; }

                    /// <summary>
                    /// skuId
                    /// </summary>
                    [JsonPropertyName("sku_id")]
                    public long? SkuId { get; set; }

                    /// <summary>
                    /// 规格列表
                    /// </summary>
                    [JsonPropertyName("spec_list")]
                    public List<SpecListResponse> SpecList { get; set; }
                    public partial class SpecListResponse : PddResponseModel
                    {

                        /// <summary>
                        /// 规格名，如红色
                        /// </summary>
                        [JsonPropertyName("name")]
                        public string Name { get; set; }

                        /// <summary>
                        /// 父规格名，如颜色
                        /// </summary>
                        [JsonPropertyName("parent_name")]
                        public string ParentName { get; set; }

                    }

                }
                public partial class TraceInfoListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 物流公司名称
                    /// </summary>
                    [JsonPropertyName("shipping_company")]
                    public string ShippingCompany { get; set; }

                    /// <summary>
                    /// 物流单号
                    /// </summary>
                    [JsonPropertyName("track_no")]
                    public string TrackNo { get; set; }

                }

            }

        }

    }

}

