namespace PddOpenSdk.Models.Request.Ktt;
public partial class StatusKttGroupQuery
{

    /// <summary>
    /// 团号，创建团购接口获得
    /// </summary>
    [JsonPropertyName("activity_no")]
    public string ActivityNo { get; set; }

}

