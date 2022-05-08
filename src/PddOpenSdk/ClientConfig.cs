namespace MSDev.PddOpenSdk;

public class ClientConfig
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string CallbackUrl { get; set; }
    public string AccessToken { get; set; }
    /// <summary>
    /// ��Ϣ�����ַ
    /// </summary>
    public string SocketUrl { get; set; }
    /// <summary>
    /// socket �������
    /// </summary>
    public int HeartBeatSeconds { get; set; } = 5;
}
