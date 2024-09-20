namespace PddOpenSdk.Models.Request.Ktt;
public partial class ImageKttGoodsUpload
{

    /// <summary>
    /// 图片url，注意上传图片长宽必须在480~1200以内，且为正方形，大小不得超过1MB，同一url不可并发调用
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

}

