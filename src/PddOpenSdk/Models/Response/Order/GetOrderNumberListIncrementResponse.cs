namespace PddOpenSdk.Models.Response.Order;
public partial class GetOrderNumberListIncrementResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("order_sn_increment_get_response")]
    public OrderSnIncrementGetResponseResponse OrderSnIncrementGetResponse { get; set; }
    public partial class OrderSnIncrementGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [JsonPropertyName("has_next")]
        public bool? HasNext { get; set; }

        /// <summary>
        /// 订单列表对象
        /// </summary>
        [JsonPropertyName("order_sn_list")]
        public List<OrderSnListResponse> OrderSnList { get; set; }

        /// <summary>
        /// 返回订单的总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
        public partial class OrderSnListResponse : PddResponseModel
        {

            /// <summary>
            /// 收件详细地址
            /// </summary>
            [JsonPropertyName("address")]
            public string Address { get; set; }

            /// <summary>
            /// 详细地址（打码）
            /// </summary>
            [JsonPropertyName("address_mask")]
            public string AddressMask { get; set; }

            /// <summary>
            /// 售后状态 0：无售后 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款，待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处理，退款失败 13：买家逾期，超过有效期 14：换货补寄待商家处理 15：换货补寄待用户处理 16：换货补寄成功 17：换货补寄失败 18：换货补寄待用户确认完成 21：待商家同意维修 22：待用户确认发货 24：维修关闭 25：维修成功 27：待用户确认收货 31：已同意拒收退款，待用户拒收 32：补寄待商家发货 33：同意召回后退款，待商家召回
            /// </summary>
            [JsonPropertyName("after_sales_status")]
            public int? AfterSalesStatus { get; set; }

            /// <summary>
            /// 保税仓名称
            /// </summary>
            [JsonPropertyName("bonded_warehouse")]
            public string BondedWarehouse { get; set; }

            /// <summary>
            /// 买家留言信息
            /// </summary>
            [JsonPropertyName("buyer_memo")]
            public string BuyerMemo { get; set; }

            /// <summary>
            /// 团长免单优惠金额，只在团长免单活动中才会返回优惠金额
            /// </summary>
            [JsonPropertyName("capital_free_discount")]
            public double? CapitalFreeDiscount { get; set; }

            /// <summary>
            /// 卡号信息列表
            /// </summary>
            [JsonPropertyName("card_info_list")]
            public List<CardInfoListResponse> CardInfoList { get; set; }

            /// <summary>
            /// 商品一级分类
            /// </summary>
            [JsonPropertyName("cat_id_1")]
            public long? CatId1 { get; set; }

            /// <summary>
            /// 商品二级分类
            /// </summary>
            [JsonPropertyName("cat_id_2")]
            public long? CatId2 { get; set; }

            /// <summary>
            /// 商品三级分类
            /// </summary>
            [JsonPropertyName("cat_id_3")]
            public long? CatId3 { get; set; }

            /// <summary>
            /// 商品四级分类
            /// </summary>
            [JsonPropertyName("cat_id_4")]
            public long? CatId4 { get; set; }

            /// <summary>
            /// 收件地城市
            /// </summary>
            [JsonPropertyName("city")]
            public string City { get; set; }

            /// <summary>
            /// 城市编码
            /// </summary>
            [JsonPropertyName("city_id")]
            public int? CityId { get; set; }

            /// <summary>
            /// 成交状态：0：未成交、1：已成交、2：已取消
            /// </summary>
            [JsonPropertyName("confirm_status")]
            public int? ConfirmStatus { get; set; }

            /// <summary>
            /// 成交时间
            /// </summary>
            [JsonPropertyName("confirm_time")]
            public string ConfirmTime { get; set; }

            /// <summary>
            /// 集运信息
            /// </summary>
            [JsonPropertyName("consolidate_info")]
            public ConsolidateInfoResponse ConsolidateInfo { get; set; }

            /// <summary>
            /// 收件地国家或地区
            /// </summary>
            [JsonPropertyName("country")]
            public string Country { get; set; }

            /// <summary>
            /// 国家或地区编码
            /// </summary>
            [JsonPropertyName("country_id")]
            public int? CountryId { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [JsonPropertyName("created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// 送货入户费用 单位：元
            /// </summary>
            [JsonPropertyName("delivery_home_value")]
            public double? DeliveryHomeValue { get; set; }

            /// <summary>
            /// 送货入户并安装费用 单位：元
            /// </summary>
            [JsonPropertyName("delivery_install_value")]
            public double? DeliveryInstallValue { get; set; }

            /// <summary>
            /// 是否当日发货，1-是，0-否
            /// </summary>
            [JsonPropertyName("delivery_one_day")]
            public int? DeliveryOneDay { get; set; }

            /// <summary>
            /// 折扣金额（元），折扣金额=平台优惠+商家优惠+团长免单优惠金额
            /// </summary>
            [JsonPropertyName("discount_amount")]
            public double? DiscountAmount { get; set; }

            /// <summary>
            /// 多多支付立减金额，单位：元
            /// </summary>
            [JsonPropertyName("duo_duo_pay_reduction")]
            public double? DuoDuoPayReduction { get; set; }

            /// <summary>
            /// 是否多多批发，1-是，0-否
            /// </summary>
            [JsonPropertyName("duoduo_wholesale")]
            public int? DuoduoWholesale { get; set; }

            /// <summary>
            /// 订单多包裹发货时使用的其他发货快递信息
            /// </summary>
            [JsonPropertyName("extra_delivery_list")]
            public List<ExtraDeliveryListResponse> ExtraDeliveryList { get; set; }

            /// <summary>
            /// 是否顺丰包邮，1-是 0-否
            /// </summary>
            [JsonPropertyName("free_sf")]
            public int? FreeSf { get; set; }

            /// <summary>
            /// 赠品额外运单列表
            /// </summary>
            [JsonPropertyName("gift_delivery_list")]
            public List<GiftDeliveryListResponse> GiftDeliveryList { get; set; }

            /// <summary>
            /// 赠品列表
            /// </summary>
            [JsonPropertyName("gift_list")]
            public List<GiftListResponse> GiftList { get; set; }

            /// <summary>
            /// 商品金额（元），商品金额=商品销售价格*商品数量-订单改价折扣金额
            /// </summary>
            [JsonPropertyName("goods_amount")]
            public double? GoodsAmount { get; set; }

            /// <summary>
            /// 团id
            /// </summary>
            [JsonPropertyName("group_order_id")]
            public long? GroupOrderId { get; set; }

            /// <summary>
            /// 团身份。0-团员，1-团长
            /// </summary>
            [JsonPropertyName("group_role")]
            public int? GroupRole { get; set; }

            /// <summary>
            /// 成团状态：0：拼团中、1：已成团、2：团失败
            /// </summary>
            [JsonPropertyName("group_status")]
            public int? GroupStatus { get; set; }

            /// <summary>
            /// 送货入户并安装服务 0-不支持送货，1-送货入户不安装，2-送货入户并安装
            /// </summary>
            [JsonPropertyName("home_delivery_type")]
            public int? HomeDeliveryType { get; set; }

            /// <summary>
            /// 上门安装费用 单位：元
            /// </summary>
            [JsonPropertyName("home_install_value")]
            public double? HomeInstallValue { get; set; }

            /// <summary>
            /// 支付申报订单号（多多国际清关请使用此字段，单号以XP开头）
            /// </summary>
            [JsonPropertyName("inner_transaction_id")]
            public string InnerTransactionId { get; set; }

            /// <summary>
            /// 发票申请,1代表有 0代表无
            /// </summary>
            [JsonPropertyName("invoice_status")]
            public int? InvoiceStatus { get; set; }

            /// <summary>
            /// 是否抽奖订单，1-非抽奖订单，2-抽奖订单
            /// </summary>
            [JsonPropertyName("is_lucky_flag")]
            public int? IsLuckyFlag { get; set; }

            /// <summary>
            /// 是否为预售商品 1表示是 0表示否
            /// </summary>
            [JsonPropertyName("is_pre_sale")]
            public int? IsPreSale { get; set; }

            /// <summary>
            /// 是否缺货 0-无缺货处理 1： 有缺货处理
            /// </summary>
            [JsonPropertyName("is_stock_out")]
            public int? IsStockOut { get; set; }

            /// <summary>
            /// 商品规格对象
            /// </summary>
            [JsonPropertyName("item_list")]
            public List<ItemListResponse> ItemList { get; set; }

            /// <summary>
            /// 订单承诺发货时间
            /// </summary>
            [JsonPropertyName("last_ship_time")]
            public string LastShipTime { get; set; }

            /// <summary>
            /// 快递公司编号
            /// </summary>
            [JsonPropertyName("logistics_id")]
            public long? LogisticsId { get; set; }

            /// <summary>
            /// 市场业务类型，0-普通订单，1-拼内购订单
            /// </summary>
            [JsonPropertyName("mkt_biz_type")]
            public int? MktBizType { get; set; }

            /// <summary>
            /// 只换不修，1:是，0:否
            /// </summary>
            [JsonPropertyName("only_support_replace")]
            public int? OnlySupportReplace { get; set; }

            /// <summary>
            /// 合单ID
            /// </summary>
            [JsonPropertyName("open_address_id")]
            public string OpenAddressId { get; set; }

            /// <summary>
            /// 订单改价折扣金额，单位元
            /// </summary>
            [JsonPropertyName("order_change_amount")]
            public double? OrderChangeAmount { get; set; }

            /// <summary>
            /// 仓库信息
            /// </summary>
            [JsonPropertyName("order_depot_info")]
            public OrderDepotInfoResponse OrderDepotInfo { get; set; }

            /// <summary>
            /// 订单号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 发货状态，枚举值：1：待发货，2：已发货待签收，3：已签收
            /// </summary>
            [JsonPropertyName("order_status")]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// 订单标签列表，no_trace_delivery=无痕发货，only_support_replace=只换不修，duoduo_wholesale=多多批发，return_freight_payer=退货包运费，free_sf=顺丰包邮，support_nationwide_warranty=全国联保，self_contained=门店自提，delivery_one_day=当日发货，oversea_tracing=全球购溯源，distributional_sale=分销订单，open_in_festival=不打烊，region_black_delay_shipping=发货时间可延迟，same_city_distribution=同城配送，has_subsidy_postage=补贴运费红包，has_sf_express_service=顺丰加价，community_group=小区团购，has_ship_additional=加运费发顺丰，ship_additional_order=加运费补差价订单，conso_order=集运订单，allergy_refund=过敏包退，professional_appraisal=专业鉴定，ship_hold=暂停发货，home_delivery_door=送货上门，direct_mail_activity=直邮活动，local_depot=本地仓订单
            /// </summary>
            [JsonPropertyName("order_tag_list")]
            public List<OrderTagListResponse> OrderTagList { get; set; }

            /// <summary>
            /// 支付金额（元），支付金额=商品金额-折扣金额+邮费+服务费
            /// </summary>
            [JsonPropertyName("pay_amount")]
            public double? PayAmount { get; set; }

            /// <summary>
            /// 支付单号
            /// </summary>
            [JsonPropertyName("pay_no")]
            public string PayNo { get; set; }

            /// <summary>
            /// 支付时间
            /// </summary>
            [JsonPropertyName("pay_time")]
            public string PayTime { get; set; }

            /// <summary>
            /// 支付方式，枚举值：QQ,WEIXIN,ALIPAY,LIANLIANPAY
            /// </summary>
            [JsonPropertyName("pay_type")]
            public string PayType { get; set; }

            /// <summary>
            /// 平台优惠金额
            /// </summary>
            [JsonPropertyName("platform_discount")]
            public double? PlatformDiscount { get; set; }

            /// <summary>
            /// 邮费
            /// </summary>
            [JsonPropertyName("postage")]
            public double? Postage { get; set; }

            /// <summary>
            /// 预售时间
            /// </summary>
            [JsonPropertyName("pre_sale_time")]
            public string PreSaleTime { get; set; }

            /// <summary>
            /// 承诺送达时间
            /// </summary>
            [JsonPropertyName("promise_delivery_time")]
            public string PromiseDeliveryTime { get; set; }

            /// <summary>
            /// 优惠券信息
            /// </summary>
            [JsonPropertyName("promotion_detail_list")]
            public List<PromotionDetailListResponse> PromotionDetailList { get; set; }

            /// <summary>
            /// 收件地省份
            /// </summary>
            [JsonPropertyName("province")]
            public string Province { get; set; }

            /// <summary>
            /// 省份编码
            /// </summary>
            [JsonPropertyName("province_id")]
            public int? ProvinceId { get; set; }

            /// <summary>
            /// 确认收货时间
            /// </summary>
            [JsonPropertyName("receive_time")]
            public string ReceiveTime { get; set; }

            /// <summary>
            /// 收件人地址，不拼接省市区。订单状态为待发货状态，且订单未被风控打标的情况下返回密文数据；其余情况返回空字符串。
            /// </summary>
            [JsonPropertyName("receiver_address")]
            public string ReceiverAddress { get; set; }

            /// <summary>
            /// 收件人地址（打码）
            /// </summary>
            [JsonPropertyName("receiver_address_mask")]
            public string ReceiverAddressMask { get; set; }

            /// <summary>
            /// 收件人姓名。订单状态为待发货状态，且订单未被风控打标的情况下返回密文数据；其余情况返回空字符串。
            /// </summary>
            [JsonPropertyName("receiver_name")]
            public string ReceiverName { get; set; }

            /// <summary>
            /// 收件人姓名（打码）
            /// </summary>
            [JsonPropertyName("receiver_name_mask")]
            public string ReceiverNameMask { get; set; }

            /// <summary>
            /// 收件人电话。订单状态为待发货状态，且订单未被风控打标的情况下返回密文数据；其余情况返回空字符串。
            /// </summary>
            [JsonPropertyName("receiver_phone")]
            public string ReceiverPhone { get; set; }

            /// <summary>
            /// 收件人手机号（打码）
            /// </summary>
            [JsonPropertyName("receiver_phone_mask")]
            public string ReceiverPhoneMask { get; set; }

            /// <summary>
            /// 退款状态，枚举值：1：无售后或售后关闭，2：售后处理中，3：退款中，4： 退款成功
            /// </summary>
            [JsonPropertyName("refund_status")]
            public int? RefundStatus { get; set; }

            /// <summary>
            /// 商家订单备注
            /// </summary>
            [JsonPropertyName("remark")]
            public string Remark { get; set; }

            /// <summary>
            /// 订单备注标记，1-红色，2-黄色，3-绿色，4-蓝色，5-紫色
            /// </summary>
            [JsonPropertyName("remark_tag")]
            public int? RemarkTag { get; set; }

            /// <summary>
            /// 订单备注标记名称
            /// </summary>
            [JsonPropertyName("remark_tag_name")]
            public string RemarkTagName { get; set; }

            /// <summary>
            /// 补寄额外运单列表
            /// </summary>
            [JsonPropertyName("resend_delivery_list")]
            public List<ResendDeliveryListResponse> ResendDeliveryList { get; set; }

            /// <summary>
            /// 退货包运费，1:是，0:否
            /// </summary>
            [JsonPropertyName("return_freight_payer")]
            public int? ReturnFreightPayer { get; set; }

            /// <summary>
            /// 订单审核状态（0-正常订单， 1-审核中订单）
            /// </summary>
            [JsonPropertyName("risk_control_status")]
            public int? RiskControlStatus { get; set; }

            /// <summary>
            /// 是否门店自提，1-是，0-否
            /// </summary>
            [JsonPropertyName("self_contained")]
            public int? SelfContained { get; set; }

            /// <summary>
            /// 店铺优惠金额
            /// </summary>
            [JsonPropertyName("seller_discount")]
            public double? SellerDiscount { get; set; }

            /// <summary>
            /// 服务费明细列表，sf_express_fee=顺丰加价服务，install_fee=上门安装服务，store_install_fee=到店安装服务，take_to_store_install_fee=携货到店安装，dismantle_and_home_install_fee=拆旧+上门安装
            /// </summary>
            [JsonPropertyName("service_fee_detail")]
            public List<ServiceFeeDetailResponse> ServiceFeeDetail { get; set; }

            /// <summary>
            /// 关联的加运费发顺丰的补差价订单
            /// </summary>
            [JsonPropertyName("ship_additional_link_order")]
            public string ShipAdditionalLinkOrder { get; set; }

            /// <summary>
            /// 加运费补差价订单的原单
            /// </summary>
            [JsonPropertyName("ship_additional_origin_order")]
            public string ShipAdditionalOriginOrder { get; set; }

            /// <summary>
            /// 发货时间
            /// </summary>
            [JsonPropertyName("shipping_time")]
            public string ShippingTime { get; set; }

            /// <summary>
            /// 创建交易时的物流方式(1-预约配送，2-1小时达，3-消费者预约送达)
            /// </summary>
            [JsonPropertyName("shipping_type")]
            public int? ShippingType { get; set; }

            /// <summary>
            /// 定金订单信息，非定金订单为null
            /// </summary>
            [JsonPropertyName("step_order_info")]
            public StepOrderInfoResponse StepOrderInfo { get; set; }

            /// <summary>
            /// 缺货处理状态，-1:无缺货处理 0: 缺货待处理 1缺货已处理
            /// </summary>
            [JsonPropertyName("stock_out_handle_status")]
            public int? StockOutHandleStatus { get; set; }

            /// <summary>
            /// 全国联保，1:是，0:否
            /// </summary>
            [JsonPropertyName("support_nationwide_warranty")]
            public int? SupportNationwideWarranty { get; set; }

            /// <summary>
            /// 收件地区县
            /// </summary>
            [JsonPropertyName("town")]
            public string Town { get; set; }

            /// <summary>
            /// 区县编码
            /// </summary>
            [JsonPropertyName("town_id")]
            public int? TownId { get; set; }

            /// <summary>
            /// 快递运单号
            /// </summary>
            [JsonPropertyName("tracking_number")]
            public string TrackingNumber { get; set; }

            /// <summary>
            /// 订单类型：0-普通订单、1-定金订单
            /// </summary>
            [JsonPropertyName("trade_type")]
            public int? TradeType { get; set; }

            /// <summary>
            /// 订单最近一次更新时间
            /// </summary>
            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// 催发货时间
            /// </summary>
            [JsonPropertyName("urge_shipping_time")]
            public string UrgeShippingTime { get; set; }

            /// <summary>
            /// 预约配送日期
            /// </summary>
            [JsonPropertyName("yyps_date")]
            public string YypsDate { get; set; }

            /// <summary>
            /// 预约配送时段
            /// </summary>
            [JsonPropertyName("yyps_time")]
            public string YypsTime { get; set; }
            public partial class CardInfoListResponse : PddResponseModel
            {

                /// <summary>
                /// 卡号
                /// </summary>
                [JsonPropertyName("card_no")]
                public string CardNo { get; set; }

                /// <summary>
                /// 卡密
                /// </summary>
                [JsonPropertyName("mask_password")]
                public string MaskPassword { get; set; }

            }
            public partial class ConsolidateInfoResponse : PddResponseModel
            {

                /// <summary>
                /// 集运类型 0-中国香港集运、1-中国新疆中转、2-哈萨克斯坦集运、3-中国西藏中转、5-日本集运、6-中国台湾集运、7-韩国集运、8-新加坡集运、9-马来西亚集运、10-泰国集运、11-越南集运、12-吉尔吉斯斯坦集运、13-乌兹别克斯坦集运、14-中国甘肃中转、15-中国内蒙古中转、16-中国宁夏中转、17-中国青海中转、18-中国澳门集运、19-柬埔寨集运、20-老挝集运、21-塔吉克斯坦集运、22-亚美尼亚集运、23-格鲁吉亚集运
                /// </summary>
                [JsonPropertyName("consolidate_type")]
                public int? ConsolidateType { get; set; }

            }
            public partial class ExtraDeliveryListResponse : PddResponseModel
            {

                /// <summary>
                /// 快递公司编号
                /// </summary>
                [JsonPropertyName("logistics_id")]
                public int? LogisticsId { get; set; }

                /// <summary>
                /// 快递运单号
                /// </summary>
                [JsonPropertyName("tracking_number")]
                public string TrackingNumber { get; set; }

            }
            public partial class GiftDeliveryListResponse : PddResponseModel
            {

                /// <summary>
                /// 快递ID
                /// </summary>
                [JsonPropertyName("logistics_id")]
                public int? LogisticsId { get; set; }

                /// <summary>
                /// 运单号
                /// </summary>
                [JsonPropertyName("tracking_number")]
                public string TrackingNumber { get; set; }

            }
            public partial class GiftListResponse : PddResponseModel
            {

                /// <summary>
                /// 赠品数量
                /// </summary>
                [JsonPropertyName("goods_count")]
                public int? GoodsCount { get; set; }

                /// <summary>
                /// 赠品id
                /// </summary>
                [JsonPropertyName("goods_id")]
                public long? GoodsId { get; set; }

                /// <summary>
                /// 赠品图片
                /// </summary>
                [JsonPropertyName("goods_img")]
                public string GoodsImg { get; set; }

                /// <summary>
                /// 赠品名称
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 赠品销售价格
                /// </summary>
                [JsonPropertyName("goods_price")]
                public double? GoodsPrice { get; set; }

                /// <summary>
                /// 赠品规格
                /// </summary>
                [JsonPropertyName("goods_spec")]
                public string GoodsSpec { get; set; }

                /// <summary>
                /// 商家外部商品编码
                /// </summary>
                [JsonPropertyName("outer_goods_id")]
                public string OuterGoodsId { get; set; }

                /// <summary>
                /// 商家外部sku编码
                /// </summary>
                [JsonPropertyName("outer_id")]
                public string OuterId { get; set; }

                /// <summary>
                /// 赠品规格编码
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

            }
            public partial class ItemListResponse : PddResponseModel
            {

                /// <summary>
                /// 商品数量
                /// </summary>
                [JsonPropertyName("goods_count")]
                public long? GoodsCount { get; set; }

                /// <summary>
                /// 商品编号
                /// </summary>
                [JsonPropertyName("goods_id")]
                public long? GoodsId { get; set; }

                /// <summary>
                /// 商品图片
                /// </summary>
                [JsonPropertyName("goods_img")]
                public string GoodsImg { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 商品销售价格
                /// </summary>
                [JsonPropertyName("goods_price")]
                public double? GoodsPrice { get; set; }

                /// <summary>
                /// 商品规格，使用（规格值1,规格值2）组合作为sku的表示，中间以英文逗号隔开
                /// </summary>
                [JsonPropertyName("goods_spec")]
                public string GoodsSpec { get; set; }

                /// <summary>
                /// 商家外部编码（商品），注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
                /// </summary>
                [JsonPropertyName("outer_goods_id")]
                public string OuterGoodsId { get; set; }

                /// <summary>
                /// 商家外部编码（sku），注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
                /// </summary>
                [JsonPropertyName("outer_id")]
                public string OuterId { get; set; }

                /// <summary>
                /// 商品规格编码
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

            }
            public partial class OrderDepotInfoResponse : PddResponseModel
            {

                /// <summary>
                /// 仓库编码
                /// </summary>
                [JsonPropertyName("depot_code")]
                public string DepotCode { get; set; }

                /// <summary>
                /// 仓库id
                /// </summary>
                [JsonPropertyName("depot_id")]
                public string DepotId { get; set; }

                /// <summary>
                /// 仓库名称
                /// </summary>
                [JsonPropertyName("depot_name")]
                public string DepotName { get; set; }

                /// <summary>
                /// 仓库类型，1：自有仓 2：订阅仓 两者都不是则传空
                /// </summary>
                [JsonPropertyName("depot_type")]
                public int? DepotType { get; set; }

                /// <summary>
                /// 货品id
                /// </summary>
                [JsonPropertyName("ware_id")]
                public string WareId { get; set; }

                /// <summary>
                /// 货品名称
                /// </summary>
                [JsonPropertyName("ware_name")]
                public string WareName { get; set; }

                /// <summary>
                /// 货品编码
                /// </summary>
                [JsonPropertyName("ware_sn")]
                public string WareSn { get; set; }

                /// <summary>
                /// 子货品列表（组合货品才会有子货品信息）
                /// </summary>
                [JsonPropertyName("ware_sub_info_list")]
                public List<WareSubInfoListResponse> WareSubInfoList { get; set; }

                /// <summary>
                /// 货品类型（0：普通货品:1：组合货品）
                /// </summary>
                [JsonPropertyName("ware_type")]
                public int? WareType { get; set; }
                public partial class WareSubInfoListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 子货品1id
                    /// </summary>
                    [JsonPropertyName("ware_id")]
                    public long? WareId { get; set; }

                    /// <summary>
                    /// 子货品名称
                    /// </summary>
                    [JsonPropertyName("ware_name")]
                    public string WareName { get; set; }

                    /// <summary>
                    /// 子货品数量
                    /// </summary>
                    [JsonPropertyName("ware_quantity")]
                    public long? WareQuantity { get; set; }

                    /// <summary>
                    /// 子货品编码
                    /// </summary>
                    [JsonPropertyName("ware_sn")]
                    public string WareSn { get; set; }

                }

            }
            public partial class OrderTagListResponse : PddResponseModel
            {

                /// <summary>
                /// 标签名称
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; }

                /// <summary>
                /// 是否有标签：0=无标签，1=有标签
                /// </summary>
                [JsonPropertyName("value")]
                public int? Value { get; set; }

            }
            public partial class PromotionDetailListResponse : PddResponseModel
            {

                /// <summary>
                /// 优惠金额（元）
                /// </summary>
                [JsonPropertyName("discount_amount")]
                public double? DiscountAmount { get; set; }

                /// <summary>
                /// 优惠券类型。30-以旧换新优惠（优惠金额已包含平台优惠金额里）
                /// </summary>
                [JsonPropertyName("promotion_type")]
                public int? PromotionType { get; set; }

            }
            public partial class ResendDeliveryListResponse : PddResponseModel
            {

                /// <summary>
                /// 快递ID
                /// </summary>
                [JsonPropertyName("logistics_id")]
                public int? LogisticsId { get; set; }

                /// <summary>
                /// 运单号
                /// </summary>
                [JsonPropertyName("tracking_number")]
                public string TrackingNumber { get; set; }

            }
            public partial class ServiceFeeDetailResponse : PddResponseModel
            {

                /// <summary>
                /// 服务费金额，单位：元
                /// </summary>
                [JsonPropertyName("service_fee")]
                public double? ServiceFee { get; set; }

                /// <summary>
                /// 服务费类型
                /// </summary>
                [JsonPropertyName("service_name")]
                public string ServiceName { get; set; }

            }
            public partial class StepOrderInfoResponse : PddResponseModel
            {

                /// <summary>
                /// 分阶段已付定金 单位：元
                /// </summary>
                [JsonPropertyName("advanced_paid_fee")]
                public double? AdvancedPaidFee { get; set; }

                /// <summary>
                /// 膨胀金额 单位：元
                /// </summary>
                [JsonPropertyName("step_discount_amount")]
                public double? StepDiscountAmount { get; set; }

                /// <summary>
                /// 分阶段已付金额 单位：元
                /// </summary>
                [JsonPropertyName("step_paid_fee")]
                public double? StepPaidFee { get; set; }

                /// <summary>
                /// 定金订单状态：0-定金未付尾款未付、1-定金已付尾款未付、2-定金已付尾款已付
                /// </summary>
                [JsonPropertyName("step_trade_status")]
                public int? StepTradeStatus { get; set; }

            }

        }

    }

}

