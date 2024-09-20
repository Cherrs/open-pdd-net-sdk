namespace PddOpenSdk.Models.Request.Order;
public partial class OrderOrderSearch
{

    /// <summary>
    /// 必填，下单时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数，开始时间结束时间间距不超过90天
    /// </summary>
    [JsonPropertyName("end_created_at")]
    public long EndCreatedAt { get; set; }

    /// <summary>
    /// 收件人姓名
    /// </summary>
    [JsonPropertyName("receiver_name")]
    public string ReceiverName { get; set; }

    /// <summary>
    /// 收件人电话号码
    /// </summary>
    [JsonPropertyName("receiver_phone")]
    public string ReceiverPhone { get; set; }

    /// <summary>
    /// 必填，下单时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数
    /// </summary>
    [JsonPropertyName("start_created_at")]
    public long StartCreatedAt { get; set; }

}

