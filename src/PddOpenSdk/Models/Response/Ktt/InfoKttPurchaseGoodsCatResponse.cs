namespace PddOpenSdk.Models.Response.Ktt;
public partial class InfoKttPurchaseGoodsCatResponse : PddResponseModel
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
            /// 商品类目列表
            /// </summary>
            [JsonPropertyName("category_list")]
            public List<CategoryListResponse> CategoryList { get; set; }
            public partial class CategoryListResponse : PddResponseModel
            {

                /// <summary>
                /// 类目ID
                /// </summary>
                [JsonPropertyName("category_id")]
                public int? CategoryId { get; set; }

                /// <summary>
                /// 类目名称
                /// </summary>
                [JsonPropertyName("category_name")]
                public string CategoryName { get; set; }

                /// <summary>
                /// 关联预设商品属性
                /// </summary>
                [JsonPropertyName("goods_property_list")]
                public List<GoodsPropertyListResponse> GoodsPropertyList { get; set; }

                /// <summary>
                /// 商品属性备注
                /// </summary>
                [JsonPropertyName("remark")]
                public string Remark { get; set; }
                public partial class GoodsPropertyListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 是否必填
                    /// </summary>
                    [JsonPropertyName("is_required")]
                    public bool? IsRequired { get; set; }

                    /// <summary>
                    /// 属性名
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                    /// <summary>
                    /// 属性值
                    /// </summary>
                    [JsonPropertyName("values")]
                    public List<string> Values { get; set; }

                }

            }

        }

    }

}

