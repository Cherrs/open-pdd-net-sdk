
using PddOpenSdk.Models.Request.Ktt;
using PddOpenSdk.Models.Response.Ktt;
namespace PddOpenSdk.Services.PddApi;
public class KttApi : PddCommonApi
{
    public KttApi() { }
    public KttApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 快团团增量售后单
    /// </summary>
    public async Task<ListKttAfterSalesIncrementResponse> ListKttAfterSalesIncrementAsync(ListKttAfterSalesIncrement listKttAfterSalesIncrement)
    {
        var result = await PostAsync<ListKttAfterSalesIncrement, ListKttAfterSalesIncrementResponse>("pdd.ktt.after.sales.increment.list", listKttAfterSalesIncrement);
        return result;
    }

    /// <summary>
    /// 快团团商品规格创建接口
    /// </summary>
    public async Task<SpecKttGoodsCreateResponse> SpecKttGoodsCreateAsync(SpecKttGoodsCreate specKttGoodsCreate)
    {
        var result = await PostAsync<SpecKttGoodsCreate, SpecKttGoodsCreateResponse>("pdd.ktt.goods.create.spec", specKttGoodsCreate);
        return result;
    }

    /// <summary>
    /// 快团团ERP增加商品库存接口
    /// </summary>
    public async Task<QuantityKttGoodsIncrResponse> QuantityKttGoodsIncrAsync(QuantityKttGoodsIncr quantityKttGoodsIncr)
    {
        var result = await PostAsync<QuantityKttGoodsIncr, QuantityKttGoodsIncrResponse>("pdd.ktt.goods.incr.quantity", quantityKttGoodsIncr);
        return result;
    }

    /// <summary>
    /// 快团团ERP商品列表查询
    /// </summary>
    public async Task<ListKttGoodsQueryResponse> ListKttGoodsQueryAsync(ListKttGoodsQuery listKttGoodsQuery)
    {
        var result = await PostAsync<ListKttGoodsQuery, ListKttGoodsQueryResponse>("pdd.ktt.goods.query.list", listKttGoodsQuery);
        return result;
    }

    /// <summary>
    /// 快团团单品查询接口
    /// </summary>
    public async Task<SingleKttGoodsQueryResponse> SingleKttGoodsQueryAsync(SingleKttGoodsQuery singleKttGoodsQuery)
    {
        var result = await PostAsync<SingleKttGoodsQuery, SingleKttGoodsQueryResponse>("pdd.ktt.goods.query.single", singleKttGoodsQuery);
        return result;
    }

    /// <summary>
    /// 快团团上传商品图接口
    /// </summary>
    public async Task<ImageKttGoodsUploadResponse> ImageKttGoodsUploadAsync(ImageKttGoodsUpload imageKttGoodsUpload)
    {
        var result = await PostAsync<ImageKttGoodsUpload, ImageKttGoodsUploadResponse>("pdd.ktt.goods.upload.image", imageKttGoodsUpload);
        return result;
    }

    /// <summary>
    /// 快团团创建团购接口
    /// </summary>
    public async Task<CreateKttGroupResponse> CreateKttGroupAsync(CreateKttGroup createKttGroup)
    {
        var result = await PostAsync<CreateKttGroup, CreateKttGroupResponse>("pdd.ktt.group.create", createKttGroup);
        return result;
    }

    /// <summary>
    /// 快团团查询团列表接口
    /// </summary>
    public async Task<ListKttGroupQueryResponse> ListKttGroupQueryAsync(ListKttGroupQuery listKttGroupQuery)
    {
        var result = await PostAsync<ListKttGroupQuery, ListKttGroupQueryResponse>("pdd.ktt.group.query.list", listKttGroupQuery);
        return result;
    }

    /// <summary>
    /// 快团团查询团购创建结果接口
    /// </summary>
    public async Task<StatusKttGroupQueryResponse> StatusKttGroupQueryAsync(StatusKttGroupQuery statusKttGroupQuery)
    {
        var result = await PostAsync<StatusKttGroupQuery, StatusKttGroupQueryResponse>("pdd.ktt.group.query.status", statusKttGroupQuery);
        return result;
    }

    /// <summary>
    /// 快团团上传图片接口
    /// </summary>
    public async Task<ImageKttGroupUploadResponse> ImageKttGroupUploadAsync(ImageKttGroupUpload imageKttGroupUpload)
    {
        var result = await PostAsync<ImageKttGroupUpload, ImageKttGroupUploadResponse>("pdd.ktt.group.upload.image", imageKttGroupUpload);
        return result;
    }

    /// <summary>
    /// 帮卖团长查询分佣
    /// </summary>
    public async Task<CommissionKttHelpSellQueryResponse> CommissionKttHelpSellQueryAsync(CommissionKttHelpSellQuery commissionKttHelpSellQuery)
    {
        var result = await PostAsync<CommissionKttHelpSellQuery, CommissionKttHelpSellQueryResponse>("pdd.ktt.help.sell.query.commission", commissionKttHelpSellQuery);
        return result;
    }

    /// <summary>
    /// 快团团增量查订单
    /// </summary>
    public async Task<QueryKttIncrementOrderResponse> QueryKttIncrementOrderAsync(QueryKttIncrementOrder queryKttIncrementOrder)
    {
        var result = await PostAsync<QueryKttIncrementOrder, QueryKttIncrementOrderResponse>("pdd.ktt.increment.order.query", queryKttIncrementOrder);
        return result;
    }

    /// <summary>
    /// 根据订单号查询订单信息
    /// </summary>
    public async Task<GetKttOrderResponse> GetKttOrderAsync(GetKttOrder getKttOrder)
    {
        var result = await PostAsync<GetKttOrder, GetKttOrderResponse>("pdd.ktt.order.get", getKttOrder);
        return result;
    }

    /// <summary>
    /// 根据成交时间拉取订单列表
    /// </summary>
    public async Task<ListKttOrderResponse> ListKttOrderAsync(ListKttOrder listKttOrder)
    {
        var result = await PostAsync<ListKttOrder, ListKttOrderResponse>("pdd.ktt.order.list", listKttOrder);
        return result;
    }

    /// <summary>
    /// 物流发布接口
    /// </summary>
    public async Task<CreateKttOrderLogisticResponse> CreateKttOrderLogisticAsync(CreateKttOrderLogistic createKttOrderLogistic)
    {
        var result = await PostAsync<CreateKttOrderLogistic, CreateKttOrderLogisticResponse>("pdd.ktt.order.logistic.create", createKttOrderLogistic);
        return result;
    }

    /// <summary>
    /// 物流删除接口
    /// </summary>
    public async Task<DeleteKttOrderLogisticResponse> DeleteKttOrderLogisticAsync(DeleteKttOrderLogistic deleteKttOrderLogistic)
    {
        var result = await PostAsync<DeleteKttOrderLogistic, DeleteKttOrderLogisticResponse>("pdd.ktt.order.logistic.delete", deleteKttOrderLogistic);
        return result;
    }

    /// <summary>
    /// 快团团售后单
    /// </summary>
    public async Task<GetKttOrderRefundResponse> GetKttOrderRefundAsync(GetKttOrderRefund getKttOrderRefund)
    {
        var result = await PostAsync<GetKttOrderRefund, GetKttOrderRefundResponse>("pdd.ktt.order.refund.get", getKttOrderRefund);
        return result;
    }

    /// <summary>
    /// 券码同步
    /// </summary>
    public async Task<SyncKttOrderVoucherResponse> SyncKttOrderVoucherAsync(SyncKttOrderVoucher syncKttOrderVoucher)
    {
        var result = await PostAsync<SyncKttOrderVoucher, SyncKttOrderVoucherResponse>("pdd.ktt.order.voucher.sync", syncKttOrderVoucher);
        return result;
    }

    /// <summary>
    /// 券码核销
    /// </summary>
    public async Task<VerifyKttOrderVoucherResponse> VerifyKttOrderVoucherAsync(VerifyKttOrderVoucher verifyKttOrderVoucher)
    {
        var result = await PostAsync<VerifyKttOrderVoucher, VerifyKttOrderVoucherResponse>("pdd.ktt.order.voucher.verify", verifyKttOrderVoucher);
        return result;
    }

    /// <summary>
    /// 供货商商品库商品分类查询
    /// </summary>
    public async Task<InfoKttPurchaseGoodsCatResponse> InfoKttPurchaseGoodsCatAsync(InfoKttPurchaseGoodsCat infoKttPurchaseGoodsCat)
    {
        var result = await PostAsync<InfoKttPurchaseGoodsCat, InfoKttPurchaseGoodsCatResponse>("pdd.ktt.purchase.goods.cat.info", infoKttPurchaseGoodsCat);
        return result;
    }

    /// <summary>
    /// 供货商商品库商品创建
    /// </summary>
    public async Task<CreateKttPurchaseGoodsResponse> CreateKttPurchaseGoodsAsync(CreateKttPurchaseGoods createKttPurchaseGoods)
    {
        var result = await PostAsync<CreateKttPurchaseGoods, CreateKttPurchaseGoodsResponse>("pdd.ktt.purchase.goods.create", createKttPurchaseGoods);
        return result;
    }

    /// <summary>
    /// 供货商商品库供货商品牌查询
    /// </summary>
    public async Task<InfoKttPurchaseGoodsSupplierBrandResponse> InfoKttPurchaseGoodsSupplierBrandAsync(InfoKttPurchaseGoodsSupplierBrand infoKttPurchaseGoodsSupplierBrand)
    {
        var result = await PostAsync<InfoKttPurchaseGoodsSupplierBrand, InfoKttPurchaseGoodsSupplierBrandResponse>("pdd.ktt.purchase.goods.supplier.brand.info", infoKttPurchaseGoodsSupplierBrand);
        return result;
    }

    /// <summary>
    /// 供货商查订单售后列表
    /// </summary>
    public async Task<ListKttPurchaseOrderAfterSalesResponse> ListKttPurchaseOrderAfterSalesAsync(ListKttPurchaseOrderAfterSales listKttPurchaseOrderAfterSales)
    {
        var result = await PostAsync<ListKttPurchaseOrderAfterSales, ListKttPurchaseOrderAfterSalesResponse>("pdd.ktt.purchase.order.after.sales.list", listKttPurchaseOrderAfterSales);
        return result;
    }

    /// <summary>
    /// 供货商订单发货
    /// </summary>
    public async Task<DeliveryKttPurchaseOrderResponse> DeliveryKttPurchaseOrderAsync(DeliveryKttPurchaseOrder deliveryKttPurchaseOrder)
    {
        var result = await PostAsync<DeliveryKttPurchaseOrder, DeliveryKttPurchaseOrderResponse>("pdd.ktt.purchase.order.delivery", deliveryKttPurchaseOrder);
        return result;
    }

    /// <summary>
    /// 供货商订单详情
    /// </summary>
    public async Task<InfoKttPurchaseOrderResponse> InfoKttPurchaseOrderAsync(InfoKttPurchaseOrder infoKttPurchaseOrder)
    {
        var result = await PostAsync<InfoKttPurchaseOrder, InfoKttPurchaseOrderResponse>("pdd.ktt.purchase.order.info", infoKttPurchaseOrder);
        return result;
    }

    /// <summary>
    /// 供货商订单增量列表
    /// </summary>
    public async Task<ListKttPurchaseOrderResponse> ListKttPurchaseOrderAsync(ListKttPurchaseOrder listKttPurchaseOrder)
    {
        var result = await PostAsync<ListKttPurchaseOrder, ListKttPurchaseOrderResponse>("pdd.ktt.purchase.order.list", listKttPurchaseOrder);
        return result;
    }

    /// <summary>
    /// 供货商订单发货物流单号替换
    /// </summary>
    public async Task<ReplaceKttPurchaseOrderLogisticResponse> ReplaceKttPurchaseOrderLogisticAsync(ReplaceKttPurchaseOrderLogistic replaceKttPurchaseOrderLogistic)
    {
        var result = await PostAsync<ReplaceKttPurchaseOrderLogistic, ReplaceKttPurchaseOrderLogisticResponse>("pdd.ktt.purchase.order.logistic.replace", replaceKttPurchaseOrderLogistic);
        return result;
    }

    /// <summary>
    /// 供货商拍样订单发货
    /// </summary>
    public async Task<DeliveryKttPurchaseSampleOrderResponse> DeliveryKttPurchaseSampleOrderAsync(DeliveryKttPurchaseSampleOrder deliveryKttPurchaseSampleOrder)
    {
        var result = await PostAsync<DeliveryKttPurchaseSampleOrder, DeliveryKttPurchaseSampleOrderResponse>("pdd.ktt.purchase.sample.order.delivery", deliveryKttPurchaseSampleOrder);
        return result;
    }

    /// <summary>
    /// 供货商拍样品订单详情
    /// </summary>
    public async Task<InfoKttPurchaseSampleOrderResponse> InfoKttPurchaseSampleOrderAsync(InfoKttPurchaseSampleOrder infoKttPurchaseSampleOrder)
    {
        var result = await PostAsync<InfoKttPurchaseSampleOrder, InfoKttPurchaseSampleOrderResponse>("pdd.ktt.purchase.sample.order.info", infoKttPurchaseSampleOrder);
        return result;
    }

    /// <summary>
    /// 供货商拍样品订单增量列表
    /// </summary>
    public async Task<ListKttPurchaseSampleOrderResponse> ListKttPurchaseSampleOrderAsync(ListKttPurchaseSampleOrder listKttPurchaseSampleOrder)
    {
        var result = await PostAsync<ListKttPurchaseSampleOrder, ListKttPurchaseSampleOrderResponse>("pdd.ktt.purchase.sample.order.list", listKttPurchaseSampleOrder);
        return result;
    }

    /// <summary>
    /// 供货商拍样品订单运单号修改
    /// </summary>
    public async Task<ReplaceKttPurchaseSampleOrderLogisticResponse> ReplaceKttPurchaseSampleOrderLogisticAsync(ReplaceKttPurchaseSampleOrderLogistic replaceKttPurchaseSampleOrderLogistic)
    {
        var result = await PostAsync<ReplaceKttPurchaseSampleOrderLogistic, ReplaceKttPurchaseSampleOrderLogisticResponse>("pdd.ktt.purchase.sample.order.logistic.replace", replaceKttPurchaseSampleOrderLogistic);
        return result;
    }

    /// <summary>
    /// 供货商商品库商品查询
    /// </summary>
    public async Task<InfoKttPurchaseSupplierGoodsResponse> InfoKttPurchaseSupplierGoodsAsync(InfoKttPurchaseSupplierGoods infoKttPurchaseSupplierGoods)
    {
        var result = await PostAsync<InfoKttPurchaseSupplierGoods, InfoKttPurchaseSupplierGoodsResponse>("pdd.ktt.purchase.supplier.goods.info", infoKttPurchaseSupplierGoods);
        return result;
    }

    /// <summary>
    /// 供货商商品库商品库存编辑
    /// </summary>
    public async Task<UpdateKttPurchaseSupplierStorageResponse> UpdateKttPurchaseSupplierStorageAsync(UpdateKttPurchaseSupplierStorage updateKttPurchaseSupplierStorage)
    {
        var result = await PostAsync<UpdateKttPurchaseSupplierStorage, UpdateKttPurchaseSupplierStorageResponse>("pdd.ktt.purchase.supplier.storage.update", updateKttPurchaseSupplierStorage);
        return result;
    }

    /// <summary>
    /// 分页查询自提点信息
    /// </summary>
    public async Task<PagequeryKttUserSiteResponse> PagequeryKttUserSiteAsync(PagequeryKttUserSite pagequeryKttUserSite)
    {
        var result = await PostAsync<PagequeryKttUserSite, PagequeryKttUserSiteResponse>("pdd.ktt.user.site.pagequery", pagequeryKttUserSite);
        return result;
    }

}
