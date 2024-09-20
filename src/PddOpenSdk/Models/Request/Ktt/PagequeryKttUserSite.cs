namespace PddOpenSdk.Models.Request.Ktt;
public partial class PagequeryKttUserSite
{

    /// <summary>
    /// 页码 从1开始
    /// </summary>
    [JsonPropertyName("page_no")]
    public int PageNo { get; set; }

    /// <summary>
    /// 数量 <=100
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

}

