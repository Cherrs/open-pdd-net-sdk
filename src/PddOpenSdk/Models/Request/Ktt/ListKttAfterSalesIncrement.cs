namespace PddOpenSdk.Models.Request.Ktt;
public partial class ListKttAfterSalesIncrement
{

    /// <summary>
    /// 结束的更新时间，毫秒时间戳，结束时间戳-启始时间戳应小于24小时
    /// </summary>
    [JsonPropertyName("end_updated_at")]
    public long EndUpdatedAt { get; set; }

    /// <summary>
    /// 页码，第x页，从1开始
    /// </summary>
    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 分页大小，1～100之间
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// 查询场景：0或不传-所有售后单；1-待团长处理的售后单
    /// </summary>
    [JsonPropertyName("query_type")]
    public int? QueryType { get; set; }

    /// <summary>
    /// 启始的更新时间，毫秒时间戳
    /// </summary>
    [JsonPropertyName("start_updated_at")]
    public long StartUpdatedAt { get; set; }

}

