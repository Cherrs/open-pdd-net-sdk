namespace PddOpenSdk.Models.Response.Ktt;
public partial class ListKttGroupQueryResponse : PddResponseModel
{

    /// <summary>
    /// 结果
    /// </summary>
    [JsonPropertyName("ktt_group_query_list_response")]
    public KttGroupQueryListResponseResponse KttGroupQueryListResponse { get; set; }
    public partial class KttGroupQueryListResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 团列表
        /// </summary>
        [JsonPropertyName("activity_list")]
        public List<ActivityListResponse> ActivityList { get; set; }

        /// <summary>
        /// 总团数量
        /// </summary>
        [JsonPropertyName("total")]
        public long? Total { get; set; }
        public partial class ActivityListResponse : PddResponseModel
        {

            /// <summary>
            /// 团号
            /// </summary>
            [JsonPropertyName("activity_no")]
            public string ActivityNo { get; set; }

            /// <summary>
            /// 创建时间（毫秒时间戳）
            /// </summary>
            [JsonPropertyName("create_time")]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 团结束时间（毫秒时间戳）
            /// </summary>
            [JsonPropertyName("end_time")]
            public long? EndTime { get; set; }

            /// <summary>
            /// 是否帮卖（0:我发布的，1:我帮卖的）
            /// </summary>
            [JsonPropertyName("is_help_sell")]
            public int? IsHelpSell { get; set; }

            /// <summary>
            /// 团开始时间（毫秒时间戳）
            /// </summary>
            [JsonPropertyName("start_time")]
            public long? StartTime { get; set; }

            /// <summary>
            /// 团状态（-10:待发布，-5:未开始，1:跟团中，20:已结束，30:已删除）
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 团标题
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; }

            /// <summary>
            /// 更新时间（毫秒时间戳）
            /// </summary>
            [JsonPropertyName("update_time")]
            public long? UpdateTime { get; set; }

        }

    }

}

