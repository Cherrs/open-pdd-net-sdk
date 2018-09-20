using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class RelationGoodsGetRequestModel : PddRequestModel
    {
        /// <summary>
        /// 拼多多商品id
        /// </summary>
        [JsonProperty("pdd_goods_id")]
        public object PddGoodsId { get; set; }

    }
}
