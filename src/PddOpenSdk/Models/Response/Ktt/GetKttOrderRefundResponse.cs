namespace PddOpenSdk.Models.Response.Ktt;
public partial class GetKttOrderRefundResponse : PddResponseModel
{

    /// <summary>
    /// 返回值
    /// </summary>
    [JsonPropertyName("ktt_refund_get_response")]
    public KttRefundGetResponseResponse KttRefundGetResponse { get; set; }
    public partial class KttRefundGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [JsonPropertyName("has_next")]
        public bool? HasNext { get; set; }

        /// <summary>
        /// 售后单列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListResponse> List { get; set; }
        public partial class ListResponse : PddResponseModel
        {

            /// <summary>
            /// 售后单编号
            /// </summary>
            [JsonPropertyName("after_sales_biz_sn")]
            public string AfterSalesBizSn { get; set; }

            /// <summary>
            /// 售后单状态 0-未发起售后 1-退款中 2-退款成功 3-待处理 4-拒绝退款 6-待(顾客)退货 7-待(团长)确认退货 8-(顾客)撤销 9-(系统)关闭
            /// </summary>
            [JsonPropertyName("after_sales_status")]
            public int? AfterSalesStatus { get; set; }

            /// <summary>
            /// 售后单用户申请信息
            /// </summary>
            [JsonPropertyName("apply_extension")]
            public ApplyExtensionResponse ApplyExtension { get; set; }

            /// <summary>
            /// 售后单类型 0-仅退款 1-退货退款
            /// </summary>
            [JsonPropertyName("apply_type")]
            public int? ApplyType { get; set; }

            /// <summary>
            /// 售后单创建时间
            /// </summary>
            [JsonPropertyName("created_at")]
            public string CreatedAt { get; set; }

            /// <summary>
            /// 父单号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 售后单退货信息
            /// </summary>
            [JsonPropertyName("return_goods_extension")]
            public ReturnGoodsExtensionResponse ReturnGoodsExtension { get; set; }

            /// <summary>
            /// 售后单更新时间
            /// </summary>
            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }
            public partial class ApplyExtensionResponse : PddResponseModel
            {

                /// <summary>
                /// 用户申请说明
                /// </summary>
                [JsonPropertyName("description")]
                public string Description { get; set; }

                /// <summary>
                /// 用户申请的凭证图片
                /// </summary>
                [JsonPropertyName("image_list")]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// 用户申请原因
                /// </summary>
                [JsonPropertyName("reason")]
                public string Reason { get; set; }

                /// <summary>
                /// 用户申请退款总金额
                /// </summary>
                [JsonPropertyName("refund_amount")]
                public int? RefundAmount { get; set; }

                /// <summary>
                /// 用户申请退运费金额
                /// </summary>
                [JsonPropertyName("refund_shipping_amount")]
                public int? RefundShippingAmount { get; set; }

                /// <summary>
                /// 申请售后的子单信息列表
                /// </summary>
                [JsonPropertyName("sub_extensions")]
                public List<SubExtensionsResponse> SubExtensions { get; set; }
                public partial class SubExtensionsResponse : PddResponseModel
                {

                    /// <summary>
                    /// 申请售后的子单商品金额
                    /// </summary>
                    [JsonPropertyName("refund_amount")]
                    public int? RefundAmount { get; set; }

                    /// <summary>
                    /// 申请售后的子单号
                    /// </summary>
                    [JsonPropertyName("sub_order_sn")]
                    public string SubOrderSn { get; set; }

                }

            }
            public partial class ReturnGoodsExtensionResponse : PddResponseModel
            {

                /// <summary>
                /// 退货物流列表
                /// </summary>
                [JsonPropertyName("logistics_list")]
                public List<LogisticsListResponse> LogisticsList { get; set; }
                public partial class LogisticsListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 物流公司
                    /// </summary>
                    [JsonPropertyName("company")]
                    public string Company { get; set; }

                    /// <summary>
                    /// 退货物流单号
                    /// </summary>
                    [JsonPropertyName("track_no")]
                    public string TrackNo { get; set; }

                }

            }

        }

    }

}

