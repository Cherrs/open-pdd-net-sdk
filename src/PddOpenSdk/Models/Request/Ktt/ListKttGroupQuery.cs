namespace PddOpenSdk.Models.Request.Ktt;
public partial class ListKttGroupQuery
{

    /// <summary>
    /// 查询终止更新时间（毫秒时间戳，起止时间差不能超过7天）
    /// </summary>
    [JsonPropertyName("end_update_time")]
    public long EndUpdateTime { get; set; }

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
    /// 查询起始更新时间（毫秒时间戳）
    /// </summary>
    [JsonPropertyName("start_update_time")]
    public long StartUpdateTime { get; set; }

}

