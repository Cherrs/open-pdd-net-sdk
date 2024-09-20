namespace PddOpenSdk.Models.Request.Ktt;
public partial class QuantityKttGoodsIncr
{

    /// <summary>
    /// goods ID
    /// </summary>
    [JsonPropertyName("goods_id")]
    public long GoodsId { get; set; }

    /// <summary>
    /// 修改库存的类型，不传或1代表增量修改，2代表全量修改
    /// </summary>
    [JsonPropertyName("modify_quantity_type")]
    public int? ModifyQuantityType { get; set; }

    /// <summary>
    /// 库存增减值
    /// </summary>
    [JsonPropertyName("quantity_delta")]
    public int QuantityDelta { get; set; }

    /// <summary>
    /// sku ID
    /// </summary>
    [JsonPropertyName("sku_id")]
    public long SkuId { get; set; }

}

