namespace PddOpenSdk.Models.Request.Ktt;
public partial class UpdateKttPurchaseSupplierStorage
{

    /// <summary>
    /// 入参请求
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 单sku库存修改
        /// </summary>
        [JsonPropertyName("single_sku_storage_modify_info")]
        public SingleSkuStorageModifyInfoModel SingleSkuStorageModifyInfo { get; set; }
        public partial class SingleSkuStorageModifyInfoModel
        {

            /// <summary>
            /// 商品ID
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long GoodsId { get; set; }

            /// <summary>
            /// skuId
            /// </summary>
            [JsonPropertyName("sku_id")]
            public long SkuId { get; set; }

            /// <summary>
            /// 总库存
            /// </summary>
            [JsonPropertyName("total_quantity")]
            public long TotalQuantity { get; set; }

        }

    }

}

