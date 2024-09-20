namespace PddOpenSdk.Models.Request.Ktt;
public partial class ListKttGoodsQuery
{

    /// <summary>
    /// 团号（团号和创建时间只能传一个）
    /// </summary>
    [JsonPropertyName("activity_no")]
    public string ActivityNo { get; set; }

    /// <summary>
    /// 分页页码
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// 分页大小
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// 结束最后更新时间（毫秒级时间戳）
    /// </summary>
    [JsonPropertyName("update_time_end")]
    public long? UpdateTimeEnd { get; set; }

    /// <summary>
    /// 起始最后更新时间（毫秒级时间戳）
    /// </summary>
    [JsonPropertyName("update_time_start")]
    public long? UpdateTimeStart { get; set; }

    /// <summary>
    /// 开始时间结束（毫秒级时间戳）
    /// </summary>
    [JsonPropertyName("create_time_end")]
    public long? CreateTimeEnd { get; set; }

    /// <summary>
    /// 开始时间起始（毫秒级时间戳）
    /// </summary>
    [JsonPropertyName("create_time_start")]
    public long? CreateTimeStart { get; set; }

}

