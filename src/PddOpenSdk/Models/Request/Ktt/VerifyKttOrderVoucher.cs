namespace PddOpenSdk.Models.Request.Ktt;
public partial class VerifyKttOrderVoucher
{

    /// <summary>
    /// 操作唯一键
    /// </summary>
    [JsonPropertyName("external_biz_sn")]
    public string ExternalBizSn { get; set; }

    /// <summary>
    /// 操作时间（格式：yyyy-MM-dd HH:mm:ss）
    /// </summary>
    [JsonPropertyName("operation_time")]
    public string OperationTime { get; set; }

    /// <summary>
    /// 操作类型：0=核销；1=退款销毁券码
    /// </summary>
    [JsonPropertyName("operation_type")]
    public int OperationType { get; set; }

    /// <summary>
    /// 父订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 销毁理由
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>
    /// 子订单号
    /// </summary>
    [JsonPropertyName("sub_order_sn")]
    public string SubOrderSn { get; set; }

    /// <summary>
    /// 核销门店
    /// </summary>
    [JsonPropertyName("verification_store")]
    public VerificationStoreModel VerificationStore { get; set; }

    /// <summary>
    /// 核销次数/销毁收回次数
    /// </summary>
    [JsonPropertyName("verification_times")]
    public int VerificationTimes { get; set; }

    /// <summary>
    /// 当前券码是否已核销
    /// </summary>
    [JsonPropertyName("verified")]
    public bool Verified { get; set; }

    /// <summary>
    /// 券码id
    /// </summary>
    [JsonPropertyName("voucher_id")]
    public string VoucherId { get; set; }
    public partial class VerificationStoreModel
    {

        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonPropertyName("external_store_no")]
        public string ExternalStoreNo { get; set; }

        /// <summary>
        /// 门店地址详情
        /// </summary>
        [JsonPropertyName("store_address_detail")]
        public string StoreAddressDetail { get; set; }

        /// <summary>
        /// 门店市
        /// </summary>
        [JsonPropertyName("store_city")]
        public string StoreCity { get; set; }

        /// <summary>
        /// 门店区
        /// </summary>
        [JsonPropertyName("store_district")]
        public string StoreDistrict { get; set; }

        /// <summary>
        /// 门店名字
        /// </summary>
        [JsonPropertyName("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店电话
        /// </summary>
        [JsonPropertyName("store_phone")]
        public string StorePhone { get; set; }

        /// <summary>
        /// 门店省
        /// </summary>
        [JsonPropertyName("store_province")]
        public string StoreProvince { get; set; }

    }

}

