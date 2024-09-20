namespace PddOpenSdk.Models.Response.Ktt;
public partial class SingleKttGoodsQueryResponse : PddResponseModel
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
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 商品归属快团团团号
            /// </summary>
            [JsonPropertyName("activity_no")]
            public string ActivityNo { get; set; }

            /// <summary>
            /// 商品分类名
            /// </summary>
            [JsonPropertyName("category_name")]
            public string CategoryName { get; set; }

            /// <summary>
            /// 商品描述
            /// </summary>
            [JsonPropertyName("goods_desc")]
            public string GoodsDesc { get; set; }

            /// <summary>
            /// 商品ID
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品图列表
            /// </summary>
            [JsonPropertyName("goods_image_list")]
            public List<string> GoodsImageList { get; set; }

            /// <summary>
            /// 商品名
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品归属团是否删除
            /// </summary>
            [JsonPropertyName("is_activity_delete")]
            public int? IsActivityDelete { get; set; }

            /// <summary>
            /// 限购数 0代表不限购
            /// </summary>
            [JsonPropertyName("limit_buy")]
            public int? LimitBuy { get; set; }

            /// <summary>
            /// 划线价 单位分
            /// </summary>
            [JsonPropertyName("market_price")]
            public long? MarketPrice { get; set; }

            /// <summary>
            /// sku列表
            /// </summary>
            [JsonPropertyName("sku_list")]
            public List<SkuListResponse> SkuList { get; set; }

            /// <summary>
            /// 更新时间 毫秒时间戳
            /// </summary>
            [JsonPropertyName("update_time")]
            public long? UpdateTime { get; set; }
            public partial class SkuListResponse : PddResponseModel
            {

                /// <summary>
                /// 外部商品编码
                /// </summary>
                [JsonPropertyName("external_sku_id")]
                public string ExternalSkuId { get; set; }

                /// <summary>
                /// 成本价 单位分 可能没有
                /// </summary>
                [JsonPropertyName("goods_purchase_price")]
                public long? GoodsPurchasePrice { get; set; }

                /// <summary>
                /// 价格 单位分
                /// </summary>
                [JsonPropertyName("price_in_fen")]
                public long? PriceInFen { get; set; }

                /// <summary>
                /// 剩余库存
                /// </summary>
                [JsonPropertyName("quantity")]
                public long? Quantity { get; set; }

                /// <summary>
                /// sku库存类型 0-正常 1-无限
                /// </summary>
                [JsonPropertyName("quantity_type")]
                public int? QuantityType { get; set; }

                /// <summary>
                /// 预占库存 秒杀商品有
                /// </summary>
                [JsonPropertyName("reserve_quantity")]
                public long? ReserveQuantity { get; set; }

                /// <summary>
                /// sku ID
                /// </summary>
                [JsonPropertyName("sku_id")]
                public long? SkuId { get; set; }

                /// <summary>
                /// 已售库存
                /// </summary>
                [JsonPropertyName("sold_quantity")]
                public long? SoldQuantity { get; set; }

                /// <summary>
                /// 规格列表
                /// </summary>
                [JsonPropertyName("spec_list")]
                public List<SpecListResponse> SpecList { get; set; }

                /// <summary>
                /// 具体规格名
                /// </summary>
                [JsonPropertyName("spec_name")]
                public string SpecName { get; set; }

                /// <summary>
                /// sku缩略图
                /// </summary>
                [JsonPropertyName("thumb_url")]
                public string ThumbUrl { get; set; }

                /// <summary>
                /// 总库存=剩余+预占+已售
                /// </summary>
                [JsonPropertyName("total_quantity")]
                public long? TotalQuantity { get; set; }
                public partial class SpecListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 子规格名
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                    /// <summary>
                    /// 父规格名
                    /// </summary>
                    [JsonPropertyName("parent_name")]
                    public string ParentName { get; set; }

                    /// <summary>
                    /// 规格id
                    /// </summary>
                    [JsonPropertyName("spec_id")]
                    public long? SpecId { get; set; }

                }

            }

        }

    }

}

