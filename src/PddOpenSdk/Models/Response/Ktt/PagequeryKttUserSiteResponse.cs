namespace PddOpenSdk.Models.Response.Ktt;
public partial class PagequeryKttUserSiteResponse : PddResponseModel
{

    /// <summary>
    /// 结果
    /// </summary>
    [JsonPropertyName("ktt_user_site_list_response")]
    public KttUserSiteListResponseResponse KttUserSiteListResponse { get; set; }
    public partial class KttUserSiteListResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 自提点列表
        /// </summary>
        [JsonPropertyName("self_site_info_list")]
        public List<SelfSiteInfoListResponse> SelfSiteInfoList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public long? Total { get; set; }
        public partial class SelfSiteInfoListResponse : PddResponseModel
        {

            /// <summary>
            /// 分类名称
            /// </summary>
            [JsonPropertyName("category_name")]
            public string CategoryName { get; set; }

            /// <summary>
            /// 市
            /// </summary>
            [JsonPropertyName("city_name")]
            public string CityName { get; set; }

            /// <summary>
            /// 区
            /// </summary>
            [JsonPropertyName("district_name")]
            public string DistrictName { get; set; }

            /// <summary>
            /// 是否删除
            /// </summary>
            [JsonPropertyName("is_delete")]
            public bool? IsDelete { get; set; }

            /// <summary>
            /// 电话
            /// </summary>
            [JsonPropertyName("mobile")]
            public string Mobile { get; set; }

            /// <summary>
            /// 省
            /// </summary>
            [JsonPropertyName("province_name")]
            public string ProvinceName { get; set; }

            /// <summary>
            /// 联系人
            /// </summary>
            [JsonPropertyName("receive_name")]
            public string ReceiveName { get; set; }

            /// <summary>
            /// 路线名称
            /// </summary>
            [JsonPropertyName("route_name")]
            public string RouteName { get; set; }

            /// <summary>
            /// 详细地址
            /// </summary>
            [JsonPropertyName("shipping_address")]
            public string ShippingAddress { get; set; }

            /// <summary>
            /// 管理员昵称
            /// </summary>
            [JsonPropertyName("site_manager_nickname")]
            public string SiteManagerNickname { get; set; }

            /// <summary>
            /// 自提点名称
            /// </summary>
            [JsonPropertyName("site_name")]
            public string SiteName { get; set; }

            /// <summary>
            /// 编号
            /// </summary>
            [JsonPropertyName("site_no")]
            public string SiteNo { get; set; }

        }

    }

}

