namespace PddOpenSdk.Models.Response.Ktt;
public partial class ListKttPurchaseOrderAfterSalesResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("ktt_purchase_order_after_sales_list_response")]
    public KttPurchaseOrderAfterSalesListResponseResponse KttPurchaseOrderAfterSalesListResponse { get; set; }
    public partial class KttPurchaseOrderAfterSalesListResponseResponse : PddResponseModel
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
            [JsonPropertyName("after_sales_list")]
            public List<AfterSalesListResponse> AfterSalesList { get; set; }

            /// <summary>
            /// 总数
            /// </summary>
            [JsonPropertyName("total_count")]
            public int? TotalCount { get; set; }
            public partial class AfterSalesListResponse : PddResponseModel
            {

                /// <summary>
                /// 售后id
                /// </summary>
                [JsonPropertyName("after_sales_biz_sn")]
                public string AfterSalesBizSn { get; set; }

                /// <summary>
                /// 售后状态：1-待供货商处理，2-已退款，3-已同意退款，待入账，4-待团长处理，5-已同意退货，待团长退货，6-团长已退货，待供货商确认收货，7-已撤销，8-已驳回，9-退款失败
                /// </summary>
                [JsonPropertyName("after_sales_status")]
                public int? AfterSalesStatus { get; set; }

                /// <summary>
                /// 售后类型：0-供货商退款，1-团长申请仅退款，2-团长申请退货退款
                /// </summary>
                [JsonPropertyName("apply_type")]
                public int? ApplyType { get; set; }

                /// <summary>
                /// 创建时间（毫秒）
                /// </summary>
                [JsonPropertyName("created_at")]
                public long? CreatedAt { get; set; }

                /// <summary>
                /// 团长提供的凭证图
                /// </summary>
                [JsonPropertyName("image_list")]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// 退货物流。若为“退货退款”且团长已经上传退货单号后不为空； 允许存在多对物流公司和单号
                /// </summary>
                [JsonPropertyName("logistics_list")]
                public List<LogisticsListResponse> LogisticsList { get; set; }

                /// <summary>
                /// 父单号
                /// </summary>
                [JsonPropertyName("parent_order_sn")]
                public string ParentOrderSn { get; set; }

                /// <summary>
                /// 售后原因
                /// </summary>
                [JsonPropertyName("reason")]
                public string Reason { get; set; }

                /// <summary>
                /// 总退款金额。若售后单状态为2、3时，为退款金额 否则：为申请金额
                /// </summary>
                [JsonPropertyName("refund_amount")]
                public long? RefundAmount { get; set; }

                /// <summary>
                /// 退商品金额。若售后单状态为2、3时，为退款金额 否则：为申请金额
                /// </summary>
                [JsonPropertyName("refund_goods_amount")]
                public long? RefundGoodsAmount { get; set; }

                /// <summary>
                /// 退运费金额。若售后单状态为2、3时，为退款金额 否则：为申请金额
                /// </summary>
                [JsonPropertyName("refund_shipping_amount")]
                public long? RefundShippingAmount { get; set; }

                /// <summary>
                /// 子单售后明细
                /// </summary>
                [JsonPropertyName("sub_item_list")]
                public List<SubItemListResponse> SubItemList { get; set; }

                /// <summary>
                /// 供货商说明
                /// </summary>
                [JsonPropertyName("supplier_description")]
                public string SupplierDescription { get; set; }

                /// <summary>
                /// 团长描述
                /// </summary>
                [JsonPropertyName("supply_description")]
                public string SupplyDescription { get; set; }

                /// <summary>
                /// 更新时间（毫秒）
                /// </summary>
                [JsonPropertyName("updated_at")]
                public long? UpdatedAt { get; set; }
                public partial class LogisticsListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 物流公司名
                    /// </summary>
                    [JsonPropertyName("ship_name")]
                    public string ShipName { get; set; }

                    /// <summary>
                    /// 物流单号
                    /// </summary>
                    [JsonPropertyName("track_no")]
                    public string TrackNo { get; set; }

                }
                public partial class SubItemListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 子单取消件数
                    /// </summary>
                    [JsonPropertyName("cancel_number")]
                    public int? CancelNumber { get; set; }

                    /// <summary>
                    /// 子单单号
                    /// </summary>
                    [JsonPropertyName("order_sn")]
                    public string OrderSn { get; set; }

                    /// <summary>
                    /// 子单退款金额。若售后单状态为2、3时，为退款金额 否则：为申请金额
                    /// </summary>
                    [JsonPropertyName("refund_goods_amount")]
                    public long? RefundGoodsAmount { get; set; }

                }

            }

        }

    }

}

