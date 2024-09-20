namespace PddOpenSdk.Models.Response.Ktt;
public partial class InfoKttPurchaseGoodsSupplierBrandResponse : PddResponseModel
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
            /// 品牌列表
            /// </summary>
            [JsonPropertyName("brand_list")]
            public List<BrandListResponse> BrandList { get; set; }
            public partial class BrandListResponse : PddResponseModel
            {

                /// <summary>
                /// 品牌Logo
                /// </summary>
                [JsonPropertyName("brand_logo")]
                public string BrandLogo { get; set; }

                /// <summary>
                /// 品牌名
                /// </summary>
                [JsonPropertyName("brand_name")]
                public string BrandName { get; set; }

                /// <summary>
                /// 品牌唯一ID
                /// </summary>
                [JsonPropertyName("brand_sn")]
                public string BrandSn { get; set; }

            }

        }

    }

}

