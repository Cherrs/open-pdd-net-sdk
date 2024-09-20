namespace PddOpenSdk.Models.Request.Ktt;
public partial class SyncKttOrderVoucher
{

    /// <summary>
    /// 父订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 子订单号
    /// </summary>
    [JsonPropertyName("sub_order_sn")]
    public string SubOrderSn { get; set; }

    /// <summary>
    /// 券码列表
    /// </summary>
    [JsonPropertyName("voucher_list")]
    public List<VoucherListModel> VoucherList { get; set; }
    public partial class VoucherListModel
    {

        /// <summary>
        /// 过期时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 可核销次数
        /// </summary>
        [JsonPropertyName("valid_verification_times")]
        public int ValidVerificationTimes { get; set; }

        /// <summary>
        /// 券码id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券码编号
        /// </summary>
        [JsonPropertyName("voucher_sn")]
        public string VoucherSn { get; set; }

    }

}

