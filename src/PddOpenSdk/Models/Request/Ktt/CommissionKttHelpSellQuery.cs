namespace PddOpenSdk.Models.Request.Ktt;
public partial class CommissionKttHelpSellQuery
{

    /// <summary>
    /// 父单号列表
    /// </summary>
    [JsonPropertyName("parent_order_sn_list")]
    public List<string> ParentOrderSnList { get; set; }

}

