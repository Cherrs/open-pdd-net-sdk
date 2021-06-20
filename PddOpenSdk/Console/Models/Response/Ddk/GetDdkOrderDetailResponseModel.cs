using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddk
{
public partial class GetDdkOrderDetailResponseModel : PddResponseModel
{
/// <summary>
/// order_detail_response
/// </summary>
[JsonProperty("order_detail_response")]
public OrderDetailResponseResponseModel OrderDetailResponse {get;set;}
public partial class OrderDetailResponseResponseModel : PddResponseModel
{
/// <summary>
/// 商品活动标记数组，例：[4,7]，4-秒杀 7-百亿补贴等
/// </summary>
[JsonProperty("activity_tags")]
public List<int?> ActivityTags {get;set;}
/// <summary>
/// 多多客工具id
/// </summary>
[JsonProperty("auth_duo_id")]
public long? AuthDuoId {get;set;}
/// <summary>
/// 结算批次号
/// </summary>
[JsonProperty("batch_no")]
public string BatchNo {get;set;}
/// <summary>
/// 商品一~四级类目ID列表
/// </summary>
[JsonProperty("cat_ids")]
public List<long?> CatIds {get;set;}
/// <summary>
/// 是否是 cpa 新用户，1表示是，0表示否
/// </summary>
[JsonProperty("cpa_new")]
public int? CpaNew {get;set;}
/// <summary>
/// CPS_Sign
/// </summary>
[JsonProperty("cps_sign")]
public string CpsSign {get;set;}
/// <summary>
/// 自定义参数
/// </summary>
[JsonProperty("custom_parameters")]
public string CustomParameters {get;set;}
/// <summary>
/// 订单审核失败原因
/// </summary>
[JsonProperty("fail_reason")]
public string FailReason {get;set;}
/// <summary>
/// 商品id
/// </summary>
[JsonProperty("goods_id")]
public long? GoodsId {get;set;}
/// <summary>
/// 商品名称
/// </summary>
[JsonProperty("goods_name")]
public string GoodsName {get;set;}
/// <summary>
/// 商品价格（分）
/// </summary>
[JsonProperty("goods_price")]
public long? GoodsPrice {get;set;}
/// <summary>
/// 商品数量
/// </summary>
[JsonProperty("goods_quantity")]
public long? GoodsQuantity {get;set;}
/// <summary>
/// goodsSign是加密后的goodsId，goodsId已下线，请使用goodsSign来替代。需要注意的是：推广链接带有goodsSign信息时，订单会返回原goodsSign；反之，会生成新的goodsSign返回。
/// </summary>
[JsonProperty("goods_sign")]
public string GoodsSign {get;set;}
/// <summary>
/// 商品缩略图
/// </summary>
[JsonProperty("goods_thumbnail_url")]
public string GoodsThumbnailUrl {get;set;}
/// <summary>
/// 成团编号
/// </summary>
[JsonProperty("group_id")]
public long? GroupId {get;set;}
/// <summary>
/// 是否直推 ，1表示是，0表示否
/// </summary>
[JsonProperty("is_direct")]
public int? IsDirect {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public long? MallId {get;set;}
/// <summary>
/// 订单价格（分）
/// </summary>
[JsonProperty("order_amount")]
public long? OrderAmount {get;set;}
/// <summary>
/// 订单创建时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_create_time")]
public long? OrderCreateTime {get;set;}
/// <summary>
/// 订单成团时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_group_success_time")]
public long? OrderGroupSuccessTime {get;set;}
/// <summary>
/// 订单最后更新时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_modify_at")]
public long? OrderModifyAt {get;set;}
/// <summary>
/// 订单支付时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_pay_time")]
public long? OrderPayTime {get;set;}
/// <summary>
/// 订单确认收货时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_receive_time")]
public long? OrderReceiveTime {get;set;}
/// <summary>
/// 订单结算时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_settle_time")]
public long? OrderSettleTime {get;set;}
/// <summary>
/// 订单编号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}
/// <summary>
/// 订单状态
/// </summary>
[JsonProperty("order_status")]
public int? OrderStatus {get;set;}
/// <summary>
/// 订单状态：0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算 ;10-已处罚
/// </summary>
[JsonProperty("order_status_desc")]
public string OrderStatusDesc {get;set;}
/// <summary>
/// 订单审核时间（UNIX时间戳）
/// </summary>
[JsonProperty("order_verify_time")]
public long? OrderVerifyTime {get;set;}
/// <summary>
/// 推广位id
/// </summary>
[JsonProperty("pid")]
public string Pid {get;set;}
/// <summary>
/// 打点时间
/// </summary>
[JsonProperty("point_time")]
public long? PointTime {get;set;}
/// <summary>
/// 比价状态：0：正常，1：比价
/// </summary>
[JsonProperty("price_compare_status")]
public int? PriceCompareStatus {get;set;}
/// <summary>
/// 佣金（分）
/// </summary>
[JsonProperty("promotion_amount")]
public long? PromotionAmount {get;set;}
/// <summary>
/// 佣金比例 千分比
/// </summary>
[JsonProperty("promotion_rate")]
public long? PromotionRate {get;set;}
/// <summary>
/// 售后状态：0：无，1：售后中，2：售后完成
/// </summary>
[JsonProperty("return_status")]
public int? ReturnStatus {get;set;}
/// <summary>
/// 直播间订单推广duoId
/// </summary>
[JsonProperty("sep_duo_id")]
public long? SepDuoId {get;set;}
/// <summary>
/// 直播间推广佣金
/// </summary>
[JsonProperty("sep_market_fee")]
public int? SepMarketFee {get;set;}
/// <summary>
/// 直播间推广自定义参数
/// </summary>
[JsonProperty("sep_parameters")]
public string SepParameters {get;set;}
/// <summary>
/// 直播间订单推广位
/// </summary>
[JsonProperty("sep_pid")]
public string SepPid {get;set;}
/// <summary>
/// 直播间推广佣金比例
/// </summary>
[JsonProperty("sep_rate")]
public int? SepRate {get;set;}
/// <summary>
/// 招商分成服务费金额，单位为分
/// </summary>
[JsonProperty("share_amount")]
public int? ShareAmount {get;set;}
/// <summary>
/// 招商分成服务费比例，千分比
/// </summary>
[JsonProperty("share_rate")]
public int? ShareRate {get;set;}
/// <summary>
/// 优势渠道专属商品补贴金额，单位为分。针对优质渠道的补贴活动，指定优势渠道可通过推广该商品获取相应补贴。补贴活动入口：[进宝网站-官方活动-千万补贴]，报名入口：https://jinbao.pinduoduo.com/ten-million-subsidy/entry
/// </summary>
[JsonProperty("subsidy_amount")]
public int? SubsidyAmount {get;set;}
/// <summary>
/// 等级补贴给渠道的收入补贴，不允许直接给下级代理展示，单位为分
/// </summary>
[JsonProperty("subsidy_duo_amount_level")]
public int? SubsidyDuoAmountLevel {get;set;}
/// <summary>
/// 千万补贴给渠道的收入补贴，不允许直接给下级代理展示，单位为分
/// </summary>
[JsonProperty("subsidy_duo_amount_ten_million")]
public int? SubsidyDuoAmountTenMillion {get;set;}
/// <summary>
/// 订单补贴类型：0-非补贴订单，1-千万补贴，2-社群补贴
/// </summary>
[JsonProperty("subsidy_type")]
public int? SubsidyType {get;set;}
/// <summary>
/// 订单类型：0：领券页面， 1： 红包页， 2：领券页， 3： 题页
/// </summary>
[JsonProperty("type")]
public int? Type {get;set;}
/// <summary>
/// 链接最后一次生产时间
/// </summary>
[JsonProperty("url_last_generate_time")]
public long? UrlLastGenerateTime {get;set;}
/// <summary>
/// 招商多多客id
/// </summary>
[JsonProperty("zs_duo_id")]
public long? ZsDuoId {get;set;}

}

}

}
