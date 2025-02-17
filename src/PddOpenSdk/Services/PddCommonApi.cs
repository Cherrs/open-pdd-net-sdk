using System.Text.Encodings.Web;
using System.Text.Unicode;
using PddOpenSdk.Common;
using PddOpenSdk.Models;

namespace PddOpenSdk.Services;

/// <summary>
/// 拼多多请求
/// </summary>
public class PddCommonApi
{
    /// <summary>
    /// 请求接口
    /// </summary>
    private readonly static string ApiUrl = "http://gw-api.pinduoduo.com/api/router";
    public string AccessToken { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string RedirectUri { get; set; }
    public string Ace { get; set; }

    protected static HttpClient Client = new() { Timeout = TimeSpan.FromSeconds(10) };

    public PddErrorResponseModel ErrorResponse;

    private readonly JsonSerializerOptions JsonOptions = new() {
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        ReferenceHandler = ReferenceHandler.IgnoreCycles,
        WriteIndented = true,
        Converters = { new CustomStringConverter() }
    };

    public PddCommonApi()
    {
    }
    public PddCommonApi(string clientId, string clientSecret, string accessToken)
    {
        ClientId = clientId;
        ClientSecret = clientSecret;
        AccessToken = accessToken;
    }
    public async Task<TResult> PostFileAsync<TModel, TResult>(string type, TModel model)
    {
        // 类型转换到字典
        var dic = Function.ToDictionary(model);
        var filePath = dic.Where(d => d.Key == "file_path")
            .Select(s => s.Value)
            .FirstOrDefault()?.ToString();

        if (!File.Exists(filePath))
        {
            return default;
        }

        // 添加公共参数
        dic.Add("client_id", ClientId);
        dic.Add("data_type", "JSON");
        if (string.IsNullOrEmpty(AccessToken))
        {
            Console.WriteLine("当前请求未设置AccessToken");
        }
        else
        {
            dic.Add("access_token", AccessToken);
        }
        dic.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds());
        if (dic.Keys.Any(k => k == "type"))
        {
            _ = dic.Remove("type");
        }
        if (dic.Keys.Any(k => k == "file_path"))
        {
            _ = dic.Remove("file_path");
        }
        dic.Add("type", type);
        // 添加签名
        var paramsDic = BuildSign(dic);
        var data = paramsDic.ToDictionary(s => s.Key, s => s.Value.ToString());
        using var content = new MultipartFormDataContent("------WebKitFormBoundaryxIAL5jDsXOFEIKEN");

        var streamContent = new StreamContent(new FileStream(filePath, FileMode.Open));
        content.Add(streamContent, "file", "upload.jpg");
        foreach (var item in data)
        {
            content.Add(new StringContent(item.Value), item.Key);
        }
        using var client = new HttpClient();
        try
        {
            var response = await client.PostAsync("https://gw-upload.pinduoduo.com/api/upload", content);
            ErrorResponse = new PddErrorResponseModel();
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var jObject = JsonDocument.Parse(jsonResult);
                if (jObject.RootElement.TryGetProperty("error_response", out var errorResponse))
                {
                    ErrorResponse = JsonSerializer.Deserialize<PddErrorResponseModel>(jsonResult);
                    Console.WriteLine("错误信息:" + errorResponse.ToString());
                    return default;
                }
                else
                {
                    return JsonSerializer.Deserialize<TResult>(jsonResult);
                }
            }
            else
            {
                Console.WriteLine("网络请求错误：" + response.ReasonPhrase + ":" + response.StatusCode);
            }
            return default;
        }
        catch (Exception e)
        {
            // TODO:异常处理
            Console.WriteLine(e.Message);
            return default;
        }
    }
    /// <summary>
    /// post请求封装
    /// </summary>
    /// <typeparam name="TModel">请求参数类型</typeparam>
    /// <typeparam name="TResult">返回参数类型</typeparam>
    /// <param name="type"></param>
    /// <param name="model"></param>
    /// <returns></returns>
    protected async Task<TResult> PostAsync<TModel, TResult>(string type, TModel model)
    {
        if (string.IsNullOrEmpty(ClientId) || string.IsNullOrEmpty(ClientSecret))
        {
            throw new Exception("请检查是否设置ClientId、ClientSecret");
        }
        // 类型转换到字典
        var dic = Function.ToDictionary(model);

        // 添加公共参数
        dic.Add("client_id", ClientId);
        dic.Add("data_type", "JSON");
        if (string.IsNullOrEmpty(AccessToken))
        {
            Console.WriteLine("当前请求未设置AccessToken");
        }
        else
        {
            dic.Add("access_token", AccessToken);
        }
        dic.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds());

        if (dic.Keys.Any(k => k == "type"))
        {
            _ = dic.Remove("type");
        }
        dic.Add("type", type);
        // 添加签名
        var paramsDic = BuildSign(dic);
        var jsonBody = JsonSerializer.Serialize(paramsDic, JsonOptions);
        var data = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        try
        {
            var response = await Client.PostAsync(ApiUrl, data);
            ErrorResponse = new PddErrorResponseModel();
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var jObject = JsonDocument.Parse(jsonResult);
                if (jObject.RootElement.TryGetProperty("error_response", out var errorResponse))
                {
                    ErrorResponse = JsonSerializer.Deserialize<PddErrorResponseModel>(jsonResult);
                    Console.WriteLine("错误信息:" + errorResponse.ToString());
                    return default;
                }
                else
                {
                    return JsonSerializer.Deserialize<TResult>(jsonResult);
                }
            }
            else
            {
                Console.WriteLine("网络请求错误：" + response.ReasonPhrase + ":" + response.StatusCode);
            }
            return default;
        }
        catch (Exception e)
        {
            // TODO:异常处理
            Console.WriteLine(e.Message);
            return default;
        }

    }
    /// <summary>
    /// 生成签名
    /// </summary>
    /// <param name="dic"></param>
    /// <returns></returns>
    public Dictionary<string, object> BuildSign(Dictionary<string, object> dic)
    {
        var result = new Dictionary<string, object>();
        // 去除空值并排序
        dic = dic.Where(d => d.Value != null)
            .OrderBy(d => d.Key)
            .ToDictionary((d) => d.Key, (d) => d.Value);
        // 拼接
        var signString = "";
        // 反射处理非基本类型字段的json转换
        string[] types = { "String", "DateTime", "Int64", "Boolean", "Float", "Double", "Long", "Int32" };
        var orderedKeys = dic.Keys.ToList();
        orderedKeys.Sort(string.CompareOrdinal);
        foreach (var item in orderedKeys)
        {
            if (!types.Contains(dic[item]?.GetType().Name))
            {
                dic[item] = JsonSerializer.Serialize(dic[item], JsonOptions);
            }
            _ = dic.TryGetValue(item, out var value);
            // 布尔值大写造成的签名错误
            if (value.ToString().ToLower().Equals("false"))
            {
                value = "false";
            }

            if (value.ToString().ToLower().Equals("true"))
            {
                value = "true";
            }

            signString += item + value.ToString();
            result.Add(item, value.ToString());
        }
        signString = ClientSecret + signString + ClientSecret;
        Console.WriteLine("拼接内容:" + signString);
        // MD5加密
        using (var md5 = MD5.Create())
        {
            signString = Function.GetMd5Hash(md5, signString).ToUpper();
        }
        Console.WriteLine("签名:" + signString);
        result.Add("sign", signString);
        return result;
    }
}

/// <summary>
/// 公共请求参数
/// </summary>
public class CommonReqeustParams
{
    /// <summary>
    /// API接口名称
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// POP分配给应用的client_id
    /// </summary>
    public string Client_Id { get; set; }
    /// <summary>
    /// 通过code获取的access_token(无需授权的接口，该字段不参与sign签名运算)
    /// </summary>
    public string Access_Token { get; set; }
    /// <summary>
    /// UNIX时间戳
    /// </summary>
    public string TimeStamp { get; set; }
    /// <summary>
    /// 响应格式，即返回数据的格式，JSON或者XML（二选一），默认JSON，注意是大写
    /// </summary>
    public string Data_Type { get; set; } = "JSON";
    public string Version { get; set; } = "V1";
    /// <summary>
    /// API输入参数签名结果，签名算法参考开放平台接入指南第三部分底部
    /// </summary>
    public string Sign { get; set; }
}

/// <summary>
/// 自定义 转换器，兼容使用字符串接收其它类型
/// </summary>
public class CustomStringConverter : JsonConverter<string>
{
    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }
        else if (reader.TokenType == JsonTokenType.Number && typeToConvert.FullName == "System.String")
        {
            if (reader.TryGetInt64(out long longValue))
            {
                return longValue.ToString();
            }
            else
            {
                return reader.GetDouble().ToString();
            }
        }
        return default;
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}

