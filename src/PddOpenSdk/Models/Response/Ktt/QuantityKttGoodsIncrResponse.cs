namespace PddOpenSdk.Models.Response.Ktt;
public partial class QuantityKttGoodsIncrResponse : PddResponseModel
{

    /// <summary>
    /// 结果
    /// </summary>
    [JsonPropertyName("ktt_goods_incr_quantity_response")]
    public KttGoodsIncrQuantityResponseResponse KttGoodsIncrQuantityResponse { get; set; }
    public partial class KttGoodsIncrQuantityResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

