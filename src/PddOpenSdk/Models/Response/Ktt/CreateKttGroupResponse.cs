namespace PddOpenSdk.Models.Response.Ktt;
public partial class CreateKttGroupResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 团号，用于请求创建团结果
        /// </summary>
        [JsonPropertyName("activity_no")]
        public string ActivityNo { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }

}

