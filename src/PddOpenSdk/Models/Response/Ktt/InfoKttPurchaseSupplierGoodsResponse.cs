namespace PddOpenSdk.Models.Response.Ktt;
public partial class InfoKttPurchaseSupplierGoodsResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public InfoKttPurchaseSupplierGoodsResponseResponse Response { get; set; }
    public partial class InfoKttPurchaseSupplierGoodsResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public InfoKttPurchaseSupplierGoodsResult Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class InfoKttPurchaseSupplierGoodsResult : PddResponseModel
        {

            /// <summary>
            /// 结果集
            /// </summary>
            [JsonPropertyName("result")]
            public List<ResultResponse> Result { get; set; }

            /// <summary>
            /// 总数
            /// </summary>
            [JsonPropertyName("total")]
            public int? Total { get; set; }
            public partial class ResultResponse : PddResponseModel
            {

                /// <summary>
                /// 品牌信息
                /// </summary>
                [JsonPropertyName("brand_info")]
                public BrandInfoResponse BrandInfo { get; set; }

                /// <summary>
                /// 类目信息
                /// </summary>
                [JsonPropertyName("category_info")]
                public CategoryInfoResponse CategoryInfo { get; set; }

                /// <summary>
                /// 商品发布时间
                /// </summary>
                [JsonPropertyName("create_time")]
                public string CreateTime { get; set; }

                /// <summary>
                /// 商品详情图
                /// </summary>
                [JsonPropertyName("detail_gallery")]
                public List<DetailGalleryResponse> DetailGallery { get; set; }

                /// <summary>
                /// 专属价团长列表
                /// </summary>
                [JsonPropertyName("exclusive_price_user_info_list")]
                public List<ExclusivePriceUserInfoListResponse> ExclusivePriceUserInfoList { get; set; }

                /// <summary>
                /// 商品描述
                /// </summary>
                [JsonPropertyName("goods_desc")]
                public string GoodsDesc { get; set; }

                /// <summary>
                /// 商品前台状态 1：在售中 2：已下架 3：发布中 4：已驳回 5：未发布
                /// </summary>
                [JsonPropertyName("goods_front_status")]
                public int? GoodsFrontStatus { get; set; }

                /// <summary>
                /// 商品ID
                /// </summary>
                [JsonPropertyName("goods_id")]
                public long? GoodsId { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonPropertyName("goods_name")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 商品属性
                /// </summary>
                [JsonPropertyName("goods_property_info")]
                public List<GoodsPropertyInfoResponse> GoodsPropertyInfo { get; set; }

                /// <summary>
                /// 是否控佣
                /// </summary>
                [JsonPropertyName("is_commission_restrict")]
                public bool? IsCommissionRestrict { get; set; }

                /// <summary>
                /// 是否控价
                /// </summary>
                [JsonPropertyName("is_price_restrict")]
                public bool? IsPriceRestrict { get; set; }

                /// <summary>
                /// 报名驳回理由
                /// </summary>
                [JsonPropertyName("refuse_reason")]
                public string RefuseReason { get; set; }

                /// <summary>
                /// 佣金配置 基数：100000
                /// </summary>
                [JsonPropertyName("restrict_commission")]
                public int? RestrictCommission { get; set; }

                /// <summary>
                /// sku列表
                /// </summary>
                [JsonPropertyName("sku_list")]
                public List<SkuListResponse> SkuList { get; set; }

                /// <summary>
                /// 视频
                /// </summary>
                [JsonPropertyName("video_info")]
                public List<VideoInfoResponse> VideoInfo { get; set; }

                /// <summary>
                /// 可见类型 可见类型 0：全部可见，1：白名单可见
                /// </summary>
                [JsonPropertyName("visible_type")]
                public int? VisibleType { get; set; }

                /// <summary>
                /// 可见用户列表
                /// </summary>
                [JsonPropertyName("visible_user_info_list")]
                public List<VisibleUserInfoListResponse> VisibleUserInfoList { get; set; }
                public partial class BrandInfoResponse : PddResponseModel
                {

                    /// <summary>
                    /// 品牌logo
                    /// </summary>
                    [JsonPropertyName("brand_logo")]
                    public string BrandLogo { get; set; }

                    /// <summary>
                    /// 品牌名称
                    /// </summary>
                    [JsonPropertyName("brand_name")]
                    public string BrandName { get; set; }

                    /// <summary>
                    /// 品牌唯一ID
                    /// </summary>
                    [JsonPropertyName("brand_sn")]
                    public string BrandSn { get; set; }

                }
                public partial class CategoryInfoResponse : PddResponseModel
                {

                    /// <summary>
                    /// 类目ID
                    /// </summary>
                    [JsonPropertyName("category_id")]
                    public int? CategoryId { get; set; }

                    /// <summary>
                    /// 类目名称
                    /// </summary>
                    [JsonPropertyName("category_name")]
                    public string CategoryName { get; set; }

                    /// <summary>
                    /// 默认属性
                    /// </summary>
                    [JsonPropertyName("default_property_info")]
                    public List<DefaultPropertyInfoResponse> DefaultPropertyInfo { get; set; }
                    public partial class DefaultPropertyInfoResponse : PddResponseModel
                    {

                        /// <summary>
                        /// 是否必填
                        /// </summary>
                        [JsonPropertyName("is_required")]
                        public bool? IsRequired { get; set; }

                        /// <summary>
                        /// 属性名
                        /// </summary>
                        [JsonPropertyName("name")]
                        public string Name { get; set; }

                        /// <summary>
                        /// 属性值
                        /// </summary>
                        [JsonPropertyName("values")]
                        public List<string> Values { get; set; }

                    }

                }
                public partial class DetailGalleryResponse : PddResponseModel
                {

                    /// <summary>
                    /// 视频封面链接
                    /// </summary>
                    [JsonPropertyName("cover_url")]
                    public string CoverUrl { get; set; }

                    /// <summary>
                    /// 元素类型 0：图片 1：视频
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// 链接
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string Url { get; set; }

                }
                public partial class ExclusivePriceUserInfoListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 头像
                    /// </summary>
                    [JsonPropertyName("avatar")]
                    public string Avatar { get; set; }

                    /// <summary>
                    /// 昵称
                    /// </summary>
                    [JsonPropertyName("nick_name")]
                    public string NickName { get; set; }

                    /// <summary>
                    /// 用户编号
                    /// </summary>
                    [JsonPropertyName("user_no")]
                    public string UserNo { get; set; }

                }
                public partial class GoodsPropertyInfoResponse : PddResponseModel
                {

                    /// <summary>
                    /// 是否必填
                    /// </summary>
                    [JsonPropertyName("is_required")]
                    public bool? IsRequired { get; set; }

                    /// <summary>
                    /// 属性名
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                    /// <summary>
                    /// 属性值
                    /// </summary>
                    [JsonPropertyName("values")]
                    public List<string> Values { get; set; }

                }
                public partial class SkuListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 专属价
                    /// </summary>
                    [JsonPropertyName("exclusive_price")]
                    public long? ExclusivePrice { get; set; }

                    /// <summary>
                    /// 商品编码
                    /// </summary>
                    [JsonPropertyName("external_sku_id")]
                    public string ExternalSkuId { get; set; }

                    /// <summary>
                    /// 团购价
                    /// </summary>
                    [JsonPropertyName("group_price")]
                    public long? GroupPrice { get; set; }

                    /// <summary>
                    /// 采购价
                    /// </summary>
                    [JsonPropertyName("price")]
                    public long? Price { get; set; }

                    /// <summary>
                    /// 库存类型 0：普通库存, 1：无限库存
                    /// </summary>
                    [JsonPropertyName("quantity_type")]
                    public int? QuantityType { get; set; }

                    /// <summary>
                    /// 剩余库存
                    /// </summary>
                    [JsonPropertyName("remain_quantity")]
                    public long? RemainQuantity { get; set; }

                    /// <summary>
                    /// skuId
                    /// </summary>
                    [JsonPropertyName("sku_id")]
                    public long? SkuId { get; set; }

                    /// <summary>
                    /// 销量
                    /// </summary>
                    [JsonPropertyName("sold_quantity")]
                    public long? SoldQuantity { get; set; }

                    /// <summary>
                    /// 规格列表
                    /// </summary>
                    [JsonPropertyName("spec_list")]
                    public List<SpecListResponse> SpecList { get; set; }

                    /// <summary>
                    /// sku状态 0：正常 1：下架
                    /// </summary>
                    [JsonPropertyName("status")]
                    public int? Status { get; set; }

                    /// <summary>
                    /// sku图
                    /// </summary>
                    [JsonPropertyName("thumb_url")]
                    public string ThumbUrl { get; set; }

                    /// <summary>
                    /// 总库存
                    /// </summary>
                    [JsonPropertyName("total_quantity")]
                    public long? TotalQuantity { get; set; }
                    public partial class SpecListResponse : PddResponseModel
                    {

                        /// <summary>
                        /// 规格名，如红色
                        /// </summary>
                        [JsonPropertyName("name")]
                        public string Name { get; set; }

                        /// <summary>
                        /// 父规格名，如颜色
                        /// </summary>
                        [JsonPropertyName("parent_name")]
                        public string ParentName { get; set; }

                        /// <summary>
                        /// 规格ID
                        /// </summary>
                        [JsonPropertyName("spec_id")]
                        public long? SpecId { get; set; }

                    }

                }
                public partial class VideoInfoResponse : PddResponseModel
                {

                    /// <summary>
                    /// 视频封面链接
                    /// </summary>
                    [JsonPropertyName("cover_url")]
                    public string CoverUrl { get; set; }

                    /// <summary>
                    /// 元素类型 0：图片 1：视频
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// 链接
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string Url { get; set; }

                }
                public partial class VisibleUserInfoListResponse : PddResponseModel
                {

                    /// <summary>
                    /// 头像
                    /// </summary>
                    [JsonPropertyName("avatar")]
                    public string Avatar { get; set; }

                    /// <summary>
                    /// 昵称
                    /// </summary>
                    [JsonPropertyName("nick_name")]
                    public string NickName { get; set; }

                    /// <summary>
                    /// 用户编号
                    /// </summary>
                    [JsonPropertyName("user_no")]
                    public string UserNo { get; set; }

                }

            }

        }

    }

}

