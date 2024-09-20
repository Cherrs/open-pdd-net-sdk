namespace PddOpenSdk.Models.Response.Ktt;
public partial class StatusKttGroupQueryResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 团号
        /// </summary>
        [JsonPropertyName("activity_no")]
        public string ActivityNo { get; set; }

        /// <summary>
        /// status为2时有，创建团失败原因
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// status为1时有，返回goods_id，sku_id和external_sku_id对应关系
        /// </summary>
        [JsonPropertyName("goods_list")]
        public List<GoodsListResponse> GoodsList { get; set; }

        /// <summary>
        /// status为1时有，团小程序二维码图片地址
        /// </summary>
        [JsonPropertyName("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 创建团结果，1-创建成功，2-创建失败 3-创建中
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }
        public partial class GoodsListResponse : PddResponseModel
        {

            /// <summary>
            /// goods id
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品名
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// sku列表
            /// </summary>
            [JsonPropertyName("sku_list")]
            public List<SkuListResponse> SkuList { get; set; }
            public partial class SkuListResponse : PddResponseModel
            {

                /// <summary>
                /// 外部商品编码
                /// </summary>
                [JsonPropertyName("external_sku_id")]
                public string ExternalSkuId { get; set; }

                /// <summary>
                /// sku id
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

                /// <summary>
                /// 规格id列表，可用于映射sku
                /// </summary>
                [JsonPropertyName("spec_id_list")]
                public List<long?> SpecIdList { get; set; }

            }

        }

    }

}

