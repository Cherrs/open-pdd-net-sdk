namespace PddOpenSdk.Models.Response.Ktt;
public partial class QueryKttIncrementOrderResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("ktt_increment_order_query_response")]
    public KttIncrementOrderQueryResponseResponse KttIncrementOrderQueryResponse { get; set; }
    public partial class KttIncrementOrderQueryResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 订单信息列表
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
            /// 售后状态, 可选 0-未发起售后 1-退款中 2-退款成功 3-待处理 4-拒绝退款 6-待(顾客)退货 7-待(团长)确认退货 8-(顾客)撤销 9-(系统)关闭
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
            /// 取消状态 0-未取消 1-已取消
            /// </summary>
            [JsonPropertyName("cancel_status")]
            public int? CancelStatus { get; set; }

            /// <summary>
            /// 成交时间，毫秒时间戳
            /// </summary>
            [JsonPropertyName("confirm_at")]
            public long? ConfirmAt { get; set; }

            /// <summary>
            /// 自定义项列表
            /// </summary>
            [JsonPropertyName("custom_item_list")]
            public List<CustomItemListResponse> CustomItemList { get; set; }

            /// <summary>
            /// 优惠金额(分)
            /// </summary>
            [JsonPropertyName("discount_amount")]
            public long? DiscountAmount { get; set; }

            /// <summary>
            /// 外部活动编号
            /// </summary>
            [JsonPropertyName("external_event_sn")]
            public string ExternalEventSn { get; set; }

            /// <summary>
            /// 赠品列表
            /// </summary>
            [JsonPropertyName("gift_order_list")]
            public List<GiftOrderListResponse> GiftOrderList { get; set; }

            /// <summary>
            /// 帮卖团长昵称
            /// </summary>
            [JsonPropertyName("help_sell_nickname")]
            public string HelpSellNickname { get; set; }

            /// <summary>
            /// 帮卖团长openId
            /// </summary>
            [JsonPropertyName("help_sell_open_id")]
            public string HelpSellOpenId { get; set; }

            /// <summary>
            /// 内部支付流水号（Xp单号）
            /// </summary>
            [JsonPropertyName("inner_transaction_id")]
            public string InnerTransactionId { get; set; }

            /// <summary>
            /// 当前用户是否供货团长
            /// </summary>
            [JsonPropertyName("is_supplier")]
            public bool? IsSupplier { get; set; }

            /// <summary>
            /// 物流列表
            /// </summary>
            [JsonPropertyName("logistics_list")]
            public List<LogisticsListResponse> LogisticsList { get; set; }

            /// <summary>
            /// 物流方式 0-无需物流 10-普通快递 20-自提 30-同城配送
            /// </summary>
            [JsonPropertyName("logistics_type")]
            public int? LogisticsType { get; set; }

            /// <summary>
            /// 订单来源 0-普通团 1-店铺 2-积分商城
            /// </summary>
            [JsonPropertyName("mall_activity_type")]
            public int? MallActivityType { get; set; }

            /// <summary>
            /// 团员昵称
            /// </summary>
            [JsonPropertyName("nick_name")]
            public string NickName { get; set; }

            /// <summary>
            /// 团员openId
            /// </summary>
            [JsonPropertyName("open_id")]
            public string OpenId { get; set; }

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
            /// 平台优惠金额(分)
            /// </summary>
            [JsonPropertyName("platform_discount_amount")]
            public long? PlatformDiscountAmount { get; set; }

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
            /// 已退运费/配送费总额
            /// </summary>
            [JsonPropertyName("refund_shipping_amount")]
            public long? RefundShippingAmount { get; set; }

            /// <summary>
            /// 剩余可退运费/配送费总额（分）
            /// </summary>
            [JsonPropertyName("refundable_shipping_amount")]
            public long? RefundableShippingAmount { get; set; }

            /// <summary>
            /// 私密备注
            /// </summary>
            [JsonPropertyName("secret_remark")]
            public string SecretRemark { get; set; }

            /// <summary>
            /// 自提点编号
            /// </summary>
            [JsonPropertyName("self_pick_site_no")]
            public string SelfPickSiteNo { get; set; }

            /// <summary>
            /// 自提点详细地址
            /// </summary>
            [JsonPropertyName("self_pick_up_address")]
            public string SelfPickUpAddress { get; set; }

            /// <summary>
            /// 自提点联系电话
            /// </summary>
            [JsonPropertyName("self_pick_up_contact_mobile")]
            public string SelfPickUpContactMobile { get; set; }

            /// <summary>
            /// 自提点联系人名称
            /// </summary>
            [JsonPropertyName("self_pick_up_contact_name")]
            public string SelfPickUpContactName { get; set; }

            /// <summary>
            /// 自提点名称
            /// </summary>
            [JsonPropertyName("self_pick_up_site_name")]
            public string SelfPickUpSiteName { get; set; }

            /// <summary>
            /// 同城配送费
            /// </summary>
            [JsonPropertyName("service_amount")]
            public long? ServiceAmount { get; set; }

            /// <summary>
            /// 运费金额(分)
            /// </summary>
            [JsonPropertyName("shipping_amount")]
            public long? ShippingAmount { get; set; }

            /// <summary>
            /// 发货状态 0-未发货 1-已发货 2-部分发货 3-已收货
            /// </summary>
            [JsonPropertyName("shipping_status")]
            public int? ShippingStatus { get; set; }

            /// <summary>
            /// 团购子类型 6-本地生活团
            /// </summary>
            [JsonPropertyName("sub_activity_type")]
            public int? SubActivityType { get; set; }

            /// <summary>
            /// 购买商品列表
            /// </summary>
            [JsonPropertyName("sub_order_list")]
            public List<SubOrderListResponse> SubOrderList { get; set; }

            /// <summary>
            /// 供货团号，当isSupplier为true且复制帮卖团时给出
            /// </summary>
            [JsonPropertyName("supply_activity_no")]
            public string SupplyActivityNo { get; set; }

            /// <summary>
            /// 帮卖接龙号
            /// </summary>
            [JsonPropertyName("supply_participate_no")]
            public int? SupplyParticipateNo { get; set; }

            /// <summary>
            /// 退款金额(商家同意退款的金额, 分)
            /// </summary>
            [JsonPropertyName("theoretical_refund_amount")]
            public long? TheoreticalRefundAmount { get; set; }

            /// <summary>
            /// 支付流水号
            /// </summary>
            [JsonPropertyName("transaction_id")]
            public string TransactionId { get; set; }

            /// <summary>
            /// 更新时间，毫秒时间戳
            /// </summary>
            [JsonPropertyName("updated_at")]
            public long? UpdatedAt { get; set; }

            /// <summary>
            /// 核销状态 0-未核销 1-已核销 2-部分核销
            /// </summary>
            [JsonPropertyName("verification_status")]
            public int? VerificationStatus { get; set; }
            public partial class CustomItemListResponse : PddResponseModel
            {

                /// <summary>
                /// 自定义项名称
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; }

                /// <summary>
                /// 自定义项value
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; }

            }
            public partial class GiftOrderListResponse : PddResponseModel
            {

                /// <summary>
                /// 外部编码
                /// </summary>
                [JsonPropertyName("external_sku_id")]
                public string ExternalSkuId { get; set; }

                /// <summary>
                /// goodsId
                /// </summary>
                [JsonPropertyName("goods_id")]
                public long? GoodsId { get; set; }

                /// <summary>
                /// 赠品名
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 购买数量
                /// </summary>
                [JsonPropertyName("goods_number")]
                public int? GoodsNumber { get; set; }

                /// <summary>
                /// 宿主子订单号
                /// </summary>
                [JsonPropertyName("host_sub_order_sn")]
                public string HostSubOrderSn { get; set; }

                /// <summary>
                /// skuId
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

                /// <summary>
                /// 缩略图
                /// </summary>
                [JsonPropertyName("thumb_url")]
                public string ThumbUrl { get; set; }

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
                /// 取消状态
                /// </summary>
                [JsonPropertyName("cancel_status")]
                public int? CancelStatus { get; set; }

                /// <summary>
                /// 商品分类
                /// </summary>
                [JsonPropertyName("category_name")]
                public string CategoryName { get; set; }

                /// <summary>
                /// 外部编码
                /// </summary>
                [JsonPropertyName("external_sku_id")]
                public string ExternalSkuId { get; set; }

                /// <summary>
                /// 商品金额(分)
                /// </summary>
                [JsonPropertyName("goods_amount")]
                public long? GoodsAmount { get; set; }

                /// <summary>
                /// 商品佣金(分)
                /// </summary>
                [JsonPropertyName("goods_commission_amount")]
                public long? GoodsCommissionAmount { get; set; }

                /// <summary>
                /// 商品供货价(分)
                /// </summary>
                [JsonPropertyName("goods_cost_price")]
                public long? GoodsCostPrice { get; set; }

                /// <summary>
                /// 商品id
                /// </summary>
                [JsonPropertyName("goods_id")]
                public long? GoodsId { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 购买数量
                /// </summary>
                [JsonPropertyName("goods_number")]
                public int? GoodsNumber { get; set; }

                /// <summary>
                /// 商品单价(分)
                /// </summary>
                [JsonPropertyName("goods_price")]
                public long? GoodsPrice { get; set; }

                /// <summary>
                /// 商品成本价(分) 未设置成本价时没有该字段
                /// </summary>
                [JsonPropertyName("goods_purchase_price")]
                public long? GoodsPurchasePrice { get; set; }

                /// <summary>
                /// 商品规格
                /// </summary>
                [JsonPropertyName("goods_specification")]
                public string GoodsSpecification { get; set; }

                /// <summary>
                /// 分佣金额
                /// </summary>
                [JsonPropertyName("help_sell_amount")]
                public long? HelpSellAmount { get; set; }

                /// <summary>
                /// 当前用户是否供货团长
                /// </summary>
                [JsonPropertyName("is_supplier")]
                public bool? IsSupplier { get; set; }

                /// <summary>
                /// 商品分摊的商家优惠金额（分）
                /// </summary>
                [JsonPropertyName("merchant_discount_amount")]
                public long? MerchantDiscountAmount { get; set; }

                /// <summary>
                /// 待核销件数
                /// </summary>
                [JsonPropertyName("need_verification_number")]
                public int? NeedVerificationNumber { get; set; }

                /// <summary>
                /// 实收商品金额（分）
                /// </summary>
                [JsonPropertyName("real_goods_amount")]
                public long? RealGoodsAmount { get; set; }

                /// <summary>
                /// 已退商品金额
                /// </summary>
                [JsonPropertyName("refund_goods_amount")]
                public long? RefundGoodsAmount { get; set; }

                /// <summary>
                /// 剩余可退款的商品金额
                /// </summary>
                [JsonPropertyName("refundable_goods_amount")]
                public long? RefundableGoodsAmount { get; set; }

                /// <summary>
                /// 子单发货状态，0-未发货 1-已发货
                /// </summary>
                [JsonPropertyName("shipping_status")]
                public int? ShippingStatus { get; set; }

                /// <summary>
                /// sku_id
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

                /// <summary>
                /// 子单号
                /// </summary>
                [JsonPropertyName("sub_order_sn")]
                public string SubOrderSn { get; set; }

                /// <summary>
                /// 理论退款金额（分）= 退款成功 + 退款中
                /// </summary>
                [JsonPropertyName("theoretically_refund_amount")]
                public long? TheoreticallyRefundAmount { get; set; }

                /// <summary>
                /// 缩略图
                /// </summary>
                [JsonPropertyName("thumb_url")]
                public string ThumbUrl { get; set; }

                /// <summary>
                /// 核销件数
                /// </summary>
                [JsonPropertyName("verification_number")]
                public int? VerificationNumber { get; set; }

                /// <summary>
                /// 订单券码
                /// </summary>
                [JsonPropertyName("voucher_list")]
                public List<VoucherListResponse> VoucherList { get; set; }
                public partial class VoucherListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 过期时间
                    /// </summary>
                    [JsonPropertyName("expire_date")]
                    public string ExpireDate { get; set; }

                    /// <summary>
                    /// 已退款次数
                    /// </summary>
                    [JsonPropertyName("refund_times")]
                    public int? RefundTimes { get; set; }

                    /// <summary>
                    /// 总可核销次数
                    /// </summary>
                    [JsonPropertyName("valid_verification_times")]
                    public int? ValidVerificationTimes { get; set; }

                    /// <summary>
                    /// 已核销次数
                    /// </summary>
                    [JsonPropertyName("verified_times")]
                    public int? VerifiedTimes { get; set; }

                    /// <summary>
                    /// 券码id
                    /// </summary>
                    [JsonPropertyName("voucher_id")]
                    public string VoucherId { get; set; }

                    /// <summary>
                    /// 券码编号
                    /// </summary>
                    [JsonPropertyName("voucher_sn")]
                    public string VoucherSn { get; set; }

                }

            }

        }

    }

}

