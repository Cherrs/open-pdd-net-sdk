namespace PddOpenSdk.Models.Request.Ktt;
public partial class CreateKttPurchaseGoods
{

    /// <summary>
    /// 入参请求
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 商品创建信息
        /// </summary>
        [JsonPropertyName("goods_create_info")]
        public GoodsCreateInfoModel GoodsCreateInfo { get; set; }
        public partial class GoodsCreateInfoModel
        {

            /// <summary>
            /// 类目ID
            /// </summary>
            [JsonPropertyName("cat_id")]
            public int CatId { get; set; }

            /// <summary>
            /// 商品图片，最多9张
            /// </summary>
            [JsonPropertyName("detail_gallery")]
            public List<string> DetailGallery { get; set; }

            /// <summary>
            /// 商品描述，不能超过2000字
            /// </summary>
            [JsonPropertyName("goods_desc")]
            public string GoodsDesc { get; set; }

            /// <summary>
            /// 商品名称，不能超过100字
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品属性列表
            /// </summary>
            [JsonPropertyName("goods_property_info")]
            public List<GoodsPropertyInfoModel> GoodsPropertyInfo { get; set; }

            /// <summary>
            /// 关联品牌Sn
            /// </summary>
            [JsonPropertyName("relate_brand_sn")]
            public string RelateBrandSn { get; set; }

            /// <summary>
            /// sku列表
            /// </summary>
            [JsonPropertyName("sku_list")]
            public List<SkuListModel> SkuList { get; set; }

            /// <summary>
            /// 视频列表，最多1个
            /// </summary>
            [JsonPropertyName("video_urls")]
            public List<string> VideoUrls { get; set; }
            public partial class GoodsPropertyInfoModel
            {

                /// <summary>
                /// 属性名，不能超过10个字
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; }

                /// <summary>
                /// 属性值列表
                /// </summary>
                [JsonPropertyName("values")]
                public List<string> Values { get; set; }

            }
            public partial class SkuListModel
            {

                /// <summary>
                /// sku货号，不能超过30个字
                /// </summary>
                [JsonPropertyName("external_sku_id")]
                public string ExternalSkuId { get; set; }

                /// <summary>
                /// 团购价（单位：分），范围 1 - 50000000
                /// </summary>
                [JsonPropertyName("group_price")]
                public long GroupPrice { get; set; }

                /// <summary>
                /// 采购价（单位：分），范围 1 - 50000000
                /// </summary>
                [JsonPropertyName("price")]
                public long Price { get; set; }

                /// <summary>
                /// 库存类型  0：普通库存  1：无限库存
                /// </summary>
                [JsonPropertyName("quantity_type")]
                public int QuantityType { get; set; }

                /// <summary>
                /// 规格列表
                /// </summary>
                [JsonPropertyName("spec_list")]
                public List<SpecListModel> SpecList { get; set; }

                /// <summary>
                /// sku图
                /// </summary>
                [JsonPropertyName("thumb_url")]
                public string ThumbUrl { get; set; }

                /// <summary>
                /// 总库存，范围 0 - 99999999
                /// </summary>
                [JsonPropertyName("total_quantity")]
                public long? TotalQuantity { get; set; }
                public partial class SpecListModel
                {

                    /// <summary>
                    /// 规格名，如红色，最多30个字
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                    /// <summary>
                    /// 父规格名，如颜色，最多30个字
                    /// </summary>
                    [JsonPropertyName("parent_name")]
                    public string ParentName { get; set; }

                    /// <summary>
                    /// 规格ID
                    /// </summary>
                    [JsonPropertyName("spec_id")]
                    public long SpecId { get; set; }

                }

            }

        }

    }

}

