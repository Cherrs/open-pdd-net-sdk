namespace PddOpenSdk.Models.Request.Ktt;
public partial class SpecKttGoodsCreate
{

    /// <summary>
    /// 待创建规格Map 规格乘积不能超过400
    /// </summary>
    [JsonPropertyName("spec_map")]
    public Dictionary<string, object> SpecMap { get; set; }
    public partial class SpecMapModel
    {

        /// <summary>
        /// 父规格名 不超过30个字符
        /// </summary>
        [JsonPropertyName("$key")]
        public string Key { get; set; }

        /// <summary>
        /// 子规格列表
        /// </summary>
        [JsonPropertyName("$value")]
        public List<string> Value { get; set; }

    }

}

