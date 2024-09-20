namespace PddOpenSdk.Models.Request.Ktt;
public partial class ImageKttGroupUpload
{

    /// <summary>
    /// 图片url，注意同一url不可并发调用
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

}

