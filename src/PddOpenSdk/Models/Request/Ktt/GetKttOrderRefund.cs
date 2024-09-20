namespace PddOpenSdk.Models.Request.Ktt;
public partial class GetKttOrderRefund
{

    /// <summary>
    /// 父单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 页码，第x页，从1开始
    /// </summary>
    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    /// <summary>
    /// 分页大小，1～10之间，建议为5即可
    /// </summary>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

}

