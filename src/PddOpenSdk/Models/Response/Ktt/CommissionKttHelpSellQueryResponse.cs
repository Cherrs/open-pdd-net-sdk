namespace PddOpenSdk.Models.Response.Ktt;
public partial class CommissionKttHelpSellQueryResponse : PddResponseModel
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
            /// 父单分佣列表
            /// </summary>
            [JsonPropertyName("parent_order_commission_list")]
            public List<ParentOrderCommissionListResponse> ParentOrderCommissionList { get; set; }
            public partial class ParentOrderCommissionListResponse : PddResponseModel
            {

                /// <summary>
                /// 子单分佣列表
                /// </summary>
                [JsonPropertyName("order_commission_list")]
                public List<OrderCommissionListResponse> OrderCommissionList { get; set; }

                /// <summary>
                /// 父单号
                /// </summary>
                [JsonPropertyName("parent_order_sn")]
                public string ParentOrderSn { get; set; }
                public partial class OrderCommissionListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 商品佣金（分）
                    /// </summary>
                    [JsonPropertyName("goods_commission")]
                    public long? GoodsCommission { get; set; }

                    /// <summary>
                    /// 分佣状态 1-成功 2-失败 3-处理中
                    /// </summary>
                    [JsonPropertyName("goods_commission_status")]
                    public int? GoodsCommissionStatus { get; set; }

                    /// <summary>
                    /// 子单号
                    /// </summary>
                    [JsonPropertyName("order_sn")]
                    public string OrderSn { get; set; }

                }

            }

        }

    }

}

