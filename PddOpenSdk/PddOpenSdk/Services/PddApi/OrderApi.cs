
using PddOpenSdk.Models.Request.Order;
using PddOpenSdk.Models.Response.Order;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class OrderApi : PddCommonApi
    {
        public OrderApi() { }
        public OrderApi(string accessToken) { AccessToken = accessToken; }
        /// <summary>
        /// 查询订单承诺信息
        /// </summary>
        public async Task<GetChatPromiseInfoResponseModel> GetChatPromiseInfoAsync(GetChatPromiseInfoRequestModel getChatPromiseInfo)
        {
            var result = await PostAsync<GetChatPromiseInfoRequestModel, GetChatPromiseInfoResponseModel>("pdd.chat.promise.info.get", getChatPromiseInfo);
            return result;
        }
        /// <summary>
        /// erp打单信息同步
        /// </summary>
        public async Task<SyncErpOrderResponseModel> SyncErpOrderAsync(SyncErpOrderRequestModel syncErpOrder)
        {
            var result = await PostAsync<SyncErpOrderRequestModel, SyncErpOrderResponseModel>("pdd.erp.order.sync", syncErpOrder);
            return result;
        }
        /// <summary>
        /// 订单基础信息列表查询接口（根据成交时间）
        /// </summary>
        public async Task<GetOrderBasicListResponseModel> GetOrderBasicListAsync(GetOrderBasicListRequestModel getOrderBasicList)
        {
            var result = await PostAsync<GetOrderBasicListRequestModel, GetOrderBasicListResponseModel>("pdd.order.basic.list.get", getOrderBasicList);
            return result;
        }
        /// <summary>
        /// 订单详情
        /// </summary>
        public async Task<GetOrderInformationResponseModel> GetOrderInformationAsync(GetOrderInformationRequestModel getOrderInformation)
        {
            var result = await PostAsync<GetOrderInformationRequestModel, GetOrderInformationResponseModel>("pdd.order.information.get", getOrderInformation);
            return result;
        }
        /// <summary>
        /// 订单列表查询接口（根据成交时间）
        /// </summary>
        public async Task<GetOrderListResponseModel> GetOrderListAsync(GetOrderListRequestModel getOrderList)
        {
            var result = await PostAsync<GetOrderListRequestModel, GetOrderListResponseModel>("pdd.order.list.get", getOrderList);
            return result;
        }
        /// <summary>
        /// 订单增量接口
        /// </summary>
        public async Task<GetOrderNumberListIncrementResponseModel> GetOrderNumberListIncrementAsync(GetOrderNumberListIncrementRequestModel getOrderNumberListIncrement)
        {
            var result = await PostAsync<GetOrderNumberListIncrementRequestModel, GetOrderNumberListIncrementResponseModel>("pdd.order.number.list.increment.get", getOrderNumberListIncrement);
            return result;
        }
        /// <summary>
        /// 订单状态
        /// </summary>
        public async Task<GetOrderStatusResponseModel> GetOrderStatusAsync(GetOrderStatusRequestModel getOrderStatus)
        {
            var result = await PostAsync<GetOrderStatusRequestModel, GetOrderStatusResponseModel>("pdd.order.status.get", getOrderStatus);
            return result;
        }

    }
}
