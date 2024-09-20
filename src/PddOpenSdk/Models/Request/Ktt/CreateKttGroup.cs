namespace PddOpenSdk.Models.Request.Ktt;
public partial class CreateKttGroup
{

    /// <summary>
    /// 结束时间戳，毫秒级，不能比开始时间早，不能比当前时间早
    /// </summary>
    [JsonPropertyName("end_time")]
    public long EndTime { get; set; }

    /// <summary>
    /// 开团商品列表，不能为空
    /// </summary>
    [JsonPropertyName("goods_list")]
    public List<GoodsListModel> GoodsList { get; set; }

    /// <summary>
    /// 是否保存为预览团 0-不为预览团 1-预览团
    /// </summary>
    [JsonPropertyName("is_save_preview")]
    public int IsSavePreview { get; set; }

    /// <summary>
    /// 分配给isv的编号，用于绑新
    /// </summary>
    [JsonPropertyName("isv_no")]
    public string IsvNo { get; set; }

    /// <summary>
    /// 开始时间戳，毫秒级
    /// </summary>
    [JsonPropertyName("start_time")]
    public long StartTime { get; set; }

    /// <summary>
    /// 团购标题，不能为空
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
    public partial class GoodsListModel
    {

        /// <summary>
        /// 分类名
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品限购数量，不填或填0代表不限购
        /// </summary>
        [JsonPropertyName("limit_buy")]
        public int? LimitBuy { get; set; }

        /// <summary>
        /// 划线价，不填或填0代表无划线价，单位分
        /// </summary>
        [JsonPropertyName("market_price")]
        public long? MarketPrice { get; set; }

        /// <summary>
        /// 商品图列表，注意数量不可超过20
        /// </summary>
        [JsonPropertyName("pic_url_list")]
        public List<string> PicUrlList { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [JsonPropertyName("sku_list")]
        public List<SkuListModel> SkuList { get; set; }
        public partial class SkuListModel
        {

            /// <summary>
            /// 外部商品编码，不超过32位
            /// </summary>
            [JsonPropertyName("external_sku_id")]
            public string ExternalSkuId { get; set; }

            /// <summary>
            /// sku价格，单位分
            /// </summary>
            [JsonPropertyName("price_in_fen")]
            public long PriceInFen { get; set; }

            /// <summary>
            /// 库存类型，0-普通 1-无限，无限库存时会无视total_quantity字段
            /// </summary>
            [JsonPropertyName("quantity_type")]
            public int QuantityType { get; set; }

            /// <summary>
            /// 规格id列表，无规格为空list，如果想规格为红色,M，调用生成规格的id，红色为1，M为3，则应传入[1,3]
            /// </summary>
            [JsonPropertyName("spec_id_list")]
            public List<long> SpecIdList { get; set; }

            /// <summary>
            /// sku图url，注意sku图格式必须是jpg、jpeg、png中的一个，且尺寸不得大于1200*1200，大小不大于1MB，可以不填
            /// </summary>
            [JsonPropertyName("thumb_url")]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// 总库存，最大100w
            /// </summary>
            [JsonPropertyName("total_quantity")]
            public long TotalQuantity { get; set; }

        }

    }

}

