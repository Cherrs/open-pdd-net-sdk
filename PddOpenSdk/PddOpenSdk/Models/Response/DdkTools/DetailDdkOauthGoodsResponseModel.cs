using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.DdkTools
{
    public partial class DetailDdkOauthGoodsResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_detail_response")]
        public GoodsDetailResponseResponseModel GoodsDetailResponse { get; set; }
        public partial class GoodsDetailResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 多多进宝商品对象列表
            /// </summary>
            [JsonProperty("goods_details")]
            public List<GoodsDetailsResponseModel> GoodsDetails { get; set; }
            public partial class GoodsDetailsResponseModel : PddResponseModel
            {
                /// <summary>
                /// 活动佣金比例，千分比（特定活动期间的佣金比例）
                /// </summary>
                [JsonProperty("activity_promotion_rate")]
                public long? ActivityPromotionRate { get; set; }
                /// <summary>
                /// 商品活动标记数组，例：[4,7]，4-秒杀 7-百亿补贴等
                /// </summary>
                [JsonProperty("activity_tags")]
                public List<int?> ActivityTags { get; set; }
                /// <summary>
                /// 商品品牌词信息，如“苹果”、“阿迪达斯”、“李宁”等
                /// </summary>
                [JsonProperty("brand_name")]
                public string BrandName { get; set; }
                /// <summary>
                /// 商品类目ID，使用pdd.goods.cats.get接口获取
                /// </summary>
                [JsonProperty("cat_id")]
                public long? CatId { get; set; }
                /// <summary>
                /// 商品一~四级类目ID列表
                /// </summary>
                [JsonProperty("cat_ids")]
                public List<int?> CatIds { get; set; }
                /// <summary>
                /// 店铺收藏券id
                /// </summary>
                [JsonProperty("clt_cpn_batch_sn")]
                public string CltCpnBatchSn { get; set; }
                /// <summary>
                /// 店铺收藏券面额,单位为分
                /// </summary>
                [JsonProperty("clt_cpn_discount")]
                public long? CltCpnDiscount { get; set; }
                /// <summary>
                /// 店铺收藏券截止时间
                /// </summary>
                [JsonProperty("clt_cpn_end_time")]
                public long? CltCpnEndTime { get; set; }
                /// <summary>
                /// 店铺收藏券使用门槛价格,单位为分
                /// </summary>
                [JsonProperty("clt_cpn_min_amt")]
                public long? CltCpnMinAmt { get; set; }
                /// <summary>
                /// 店铺收藏券总量
                /// </summary>
                [JsonProperty("clt_cpn_quantity")]
                public long? CltCpnQuantity { get; set; }
                /// <summary>
                /// 店铺收藏券剩余量
                /// </summary>
                [JsonProperty("clt_cpn_remain_quantity")]
                public long? CltCpnRemainQuantity { get; set; }
                /// <summary>
                /// 店铺收藏券起始时间
                /// </summary>
                [JsonProperty("clt_cpn_start_time")]
                public long? CltCpnStartTime { get; set; }
                /// <summary>
                /// 优惠券面额，单位为分
                /// </summary>
                [JsonProperty("coupon_discount")]
                public long? CouponDiscount { get; set; }
                /// <summary>
                /// 优惠券失效时间，UNIX时间戳
                /// </summary>
                [JsonProperty("coupon_end_time")]
                public long? CouponEndTime { get; set; }
                /// <summary>
                /// 优惠券门槛金额，单位为分
                /// </summary>
                [JsonProperty("coupon_min_order_amount")]
                public long? CouponMinOrderAmount { get; set; }
                /// <summary>
                /// 优惠券剩余数量
                /// </summary>
                [JsonProperty("coupon_remain_quantity")]
                public long? CouponRemainQuantity { get; set; }
                /// <summary>
                /// 优惠券生效时间，UNIX时间戳
                /// </summary>
                [JsonProperty("coupon_start_time")]
                public long? CouponStartTime { get; set; }
                /// <summary>
                /// 优惠券总数量
                /// </summary>
                [JsonProperty("coupon_total_quantity")]
                public long? CouponTotalQuantity { get; set; }
                /// <summary>
                /// 创建时间（unix时间戳）
                /// </summary>
                [JsonProperty("create_at")]
                public long? CreateAt { get; set; }
                /// <summary>
                /// 描述分
                /// </summary>
                [JsonProperty("desc_txt")]
                public string DescTxt { get; set; }
                /// <summary>
                /// 额外优惠券，单位为分
                /// </summary>
                [JsonProperty("extra_coupon_amount")]
                public long? ExtraCouponAmount { get; set; }
                /// <summary>
                /// 参与多多进宝的商品描述
                /// </summary>
                [JsonProperty("goods_desc")]
                public string GoodsDesc { get; set; }
                /// <summary>
                /// 商品轮播图
                /// </summary>
                [JsonProperty("goods_gallery_urls")]
                public List<string> GoodsGalleryUrls { get; set; }
                /// <summary>
                /// 多多进宝商品主图
                /// </summary>
                [JsonProperty("goods_image_url")]
                public string GoodsImageUrl { get; set; }
                /// <summary>
                /// 参与多多进宝的商品标题
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品goodsSign，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
                /// </summary>
                [JsonProperty("goods_sign")]
                public string GoodsSign { get; set; }
                /// <summary>
                /// 商品缩略图
                /// </summary>
                [JsonProperty("goods_thumbnail_url")]
                public string GoodsThumbnailUrl { get; set; }
                /// <summary>
                /// 商品是否有优惠券 true-有，false-没有
                /// </summary>
                [JsonProperty("has_coupon")]
                public bool? HasCoupon { get; set; }
                /// <summary>
                /// 是否有店铺券
                /// </summary>
                [JsonProperty("has_mall_coupon")]
                public bool? HasMallCoupon { get; set; }
                /// <summary>
                /// 物流分
                /// </summary>
                [JsonProperty("lgst_txt")]
                public string LgstTxt { get; set; }
                /// <summary>
                /// 店铺折扣
                /// </summary>
                [JsonProperty("mall_coupon_discount_pct")]
                public int? MallCouponDiscountPct { get; set; }
                /// <summary>
                /// 店铺券使用结束时间
                /// </summary>
                [JsonProperty("mall_coupon_end_time")]
                public long? MallCouponEndTime { get; set; }
                /// <summary>
                /// 最大使用金额
                /// </summary>
                [JsonProperty("mall_coupon_max_discount_amount")]
                public int? MallCouponMaxDiscountAmount { get; set; }
                /// <summary>
                /// 最小使用金额
                /// </summary>
                [JsonProperty("mall_coupon_min_order_amount")]
                public int? MallCouponMinOrderAmount { get; set; }
                /// <summary>
                /// 店铺券余量
                /// </summary>
                [JsonProperty("mall_coupon_remain_quantity")]
                public long? MallCouponRemainQuantity { get; set; }
                /// <summary>
                /// 店铺券使用开始时间
                /// </summary>
                [JsonProperty("mall_coupon_start_time")]
                public long? MallCouponStartTime { get; set; }
                /// <summary>
                /// 店铺券总量
                /// </summary>
                [JsonProperty("mall_coupon_total_quantity")]
                public long? MallCouponTotalQuantity { get; set; }
                /// <summary>
                /// 该商品所在店铺是否参与全店推广，0：否，1：是
                /// </summary>
                [JsonProperty("mall_cps")]
                public int? MallCps { get; set; }
                /// <summary>
                /// 商家id
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 店铺logo图
                /// </summary>
                [JsonProperty("mall_img_url")]
                public string MallImgUrl { get; set; }
                /// <summary>
                /// 店铺名称
                /// </summary>
                [JsonProperty("mall_name")]
                public string MallName { get; set; }
                /// <summary>
                /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店（未传为全部）
                /// </summary>
                [JsonProperty("merchant_type")]
                public int? MerchantType { get; set; }
                /// <summary>
                /// 最低价sku的拼团价，单位为分
                /// </summary>
                [JsonProperty("min_group_price")]
                public long? MinGroupPrice { get; set; }
                /// <summary>
                /// 最低价sku的单买价，单位为分
                /// </summary>
                [JsonProperty("min_normal_price")]
                public long? MinNormalPrice { get; set; }
                /// <summary>
                /// 快手专享
                /// </summary>
                [JsonProperty("only_scene_auth")]
                public bool? OnlySceneAuth { get; set; }
                /// <summary>
                /// 商品标签ID，使用pdd.goods.opt.get接口获取
                /// </summary>
                [JsonProperty("opt_id")]
                public long? OptId { get; set; }
                /// <summary>
                /// 商品标签ID
                /// </summary>
                [JsonProperty("opt_ids")]
                public List<int?> OptIds { get; set; }
                /// <summary>
                /// 商品标签名称
                /// </summary>
                [JsonProperty("opt_name")]
                public string OptName { get; set; }
                /// <summary>
                /// 推广计划类型: 1-全店推广 2-单品推广 3-定向推广 4-招商推广 5-分销推广
                /// </summary>
                [JsonProperty("plan_type")]
                public int? PlanType { get; set; }
                /// <summary>
                /// 比价行为预判定佣金，需要用户备案
                /// </summary>
                [JsonProperty("predict_promotion_rate")]
                public long? PredictPromotionRate { get; set; }
                /// <summary>
                /// 佣金比例，千分比
                /// </summary>
                [JsonProperty("promotion_rate")]
                public long? PromotionRate { get; set; }
                /// <summary>
                /// 已售卖件数
                /// </summary>
                [JsonProperty("sales_tip")]
                public string SalesTip { get; set; }
                /// <summary>
                /// 服务标签: 4-送货入户并安装,5-送货入户,6-电子发票,9-坏果包赔,11-闪电退款,12-24小时发货,13-48小时发货,17-顺丰包邮,18-只换不修,1可定制化,29-预约配送,1000001-正品发票,1000002-送货入户并安装
                /// </summary>
                [JsonProperty("service_tags")]
                public List<int?> ServiceTags { get; set; }
                /// <summary>
                /// 服务分
                /// </summary>
                [JsonProperty("serv_txt")]
                public string ServTxt { get; set; }
                /// <summary>
                /// 招商分成服务费比例，千分比
                /// </summary>
                [JsonProperty("share_rate")]
                public int? ShareRate { get; set; }
                /// <summary>
                /// 优势渠道专属商品补贴金额，单位为分。针对优质渠道的补贴活动，指定优势渠道可通过推广该商品获取相应补贴。补贴活动入口：[进宝网站-官方活动-千万补贴]，报名入口：https://jinbao.pinduoduo.com/ten-million-subsidy/entry
                /// </summary>
                [JsonProperty("subsidy_amount")]
                public int? SubsidyAmount { get; set; }
                /// <summary>
                /// 千万补贴给渠道的收入补贴，不允许直接给下级代理展示，单位为分
                /// </summary>
                [JsonProperty("subsidy_duo_amount_ten_million")]
                public int? SubsidyDuoAmountTenMillion { get; set; }
                /// <summary>
                /// 优惠标签列表，包括："X元券","比全网低X元","服务费","精选素材","近30天低价","同款低价","同款好评","同款热销","旗舰店","一降到底","招商优选","商家优选","好价再降X元","全站销量XX","实时热销榜第X名","实时好评榜第X名","额外补X元"等
                /// </summary>
                [JsonProperty("unified_tags")]
                public List<string> UnifiedTags { get; set; }
                /// <summary>
                /// 商品视频url
                /// </summary>
                [JsonProperty("video_urls")]
                public List<string> VideoUrls { get; set; }
                /// <summary>
                /// 招商团长id
                /// </summary>
                [JsonProperty("zs_duo_id")]
                public long? ZsDuoId { get; set; }

            }

        }

    }

}
