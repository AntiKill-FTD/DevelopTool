using System.Net.Http.Headers;

namespace Tool.Business.Common
{
    public class HttpService
    {
        #region 只读/私有变量
        readonly string TokenPrefix = "Bearer";
        static HttpClient _HttpClient = null;
        #endregion

        #region Ctor
        public HttpService()
        {
            if (_HttpClient == null)
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.UseProxy = false;
                _HttpClient = new HttpClient(handler);
            }
        }
        #endregion

        #region GetAuthorization 生成http头认证键值对
        /// <summary>
        /// 生成http头认证键值对
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public Task<Dictionary<string, string>> GetAuthorization(string prefix, string val)
        {
            return Task.FromResult(new Dictionary<string, string> { { "Authorization", string.IsNullOrEmpty(prefix) ? val : (" " + val) } });
        }
        #endregion

        #region Get
        public HttpClientSharpResponse Get(string url, IDictionary<string, string> headers = null)
        {
            var ret = new HttpClientSharpResponse();
            try
            {
                string server = url;
                HttpClient client = _HttpClient;
                var requestMessage = new HttpRequestMessage { Method = HttpMethod.Get, RequestUri = new Uri(server) };
                if (headers != null)
                {
                    foreach (var item in headers)
                    {
                        requestMessage.Headers.Add(item.Key, item.Value);
                    }
                }
                var httpRet = client.Send(requestMessage);
                ret.Content = httpRet.Content.ReadAsStringAsync().Result;
                ret.StatusCode = (int)httpRet.StatusCode;
                return ret;
            }
            catch (Exception ex)
            {
                ret.ErrorMessage = ex.Message;
                ret.Content = string.Empty; ;
                ret.StatusCode = 201;
                return ret;
            }
        }
        #endregion

        #region GetAsync
        public async Task<HttpClientSharpResponse> GetAsync(string url, IDictionary<string, string> headers = null)
        {
            string server = url;
            HttpClient client = _HttpClient;
            var requestMessage = new HttpRequestMessage { Method = HttpMethod.Get, RequestUri = new Uri(server) };
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    requestMessage.Headers.Add(item.Key, item.Value);
                }
            }
            var httpRet = await client.SendAsync(requestMessage);
            var ret = new HttpClientSharpResponse();
            ret.Content = await httpRet.Content.ReadAsStringAsync();
            ret.StatusCode = (int)httpRet.StatusCode;
            return ret;
        }
        #endregion

        #region Post
        public HttpClientSharpResponse Post(string url, string json, IDictionary<string, string> headers = null, string ContentType = ContentTypeConstants.ApplicationJson)
        {
            var ret = new HttpClientSharpResponse();
            try
            {
                HttpClient client = _HttpClient;
                var _request = new HttpRequestMessage { Method = HttpMethod.Post, RequestUri = new Uri(url), Content = new System.Net.Http.StringContent(json) };
                _request.Content.Headers.ContentType = new MediaTypeHeaderValue(ContentType);
                _request.Content.Headers.ContentType.CharSet = "utf-8";
                if (headers != null)
                {
                    foreach (var item in headers)
                    {
                        _request.Headers.Add(item.Key, item.Value);
                    }
                }
                var httpRet = client.Send(_request);
                ret.Content = httpRet.Content.ReadAsStringAsync().Result;
                ret.StatusCode = (int)httpRet.StatusCode;
                return ret;
            }
            catch (Exception ex)
            {
                ret.ErrorMessage = ex.Message;
                ret.Content = string.Empty; ;
                ret.StatusCode = 201;
                return ret;
            }
        }
        #endregion

        #region PostAsync
        public async Task<HttpClientSharpResponse> PostAsync(string url, string json, IDictionary<string, string> headers = null, string ContentType = ContentTypeConstants.ApplicationJson)
        {
            HttpClient client = _HttpClient;
            var _request = new HttpRequestMessage { Method = HttpMethod.Post, RequestUri = new Uri(url), Content = new System.Net.Http.StringContent(json) };
            _request.Content.Headers.ContentType.CharSet = "utf-8";
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    _request.Headers.Add(item.Key, item.Value);
                }
            }
            _request.Content.Headers.ContentType = new MediaTypeHeaderValue(ContentType);
            var httpRet = await client.SendAsync(_request);
            var ret = new HttpClientSharpResponse();
            ret.Content = await httpRet.Content.ReadAsStringAsync();
            ret.StatusCode = (int)httpRet.StatusCode;
            return ret;
        }
        #endregion

        #region PostFormAsync
        public async Task<HttpClientSharpResponse> PostFormAsync(string url, Dictionary<string, string> data, IDictionary<string, string> headers = null)
        {
            HttpClient client = _HttpClient;
            var _request = new HttpRequestMessage { Method = HttpMethod.Post, RequestUri = new Uri(url) };

            if (headers != null)
            {
                foreach (var item in headers)
                {
                    _request.Headers.Add(item.Key, item.Value);
                }
            }
            // _request.Content = new MultipartFormDataContent { };
            string boundary = DateTime.Now.Ticks.ToString("X");
            var formData = new MultipartFormDataContent();
            foreach (var item in data)
            {
                formData.Add(new StringContent(item.Value), item.Key);
            }
            _request.Content = formData;
            _request.Content.Headers.ContentType.CharSet = "utf-8";
            // _request.Content.Headers.ContentType = new MediaTypeHeaderValue(ContentTypeConstants.FormData);
            var httpRet = await client.SendAsync(_request);
            var ret = new HttpClientSharpResponse();
            ret.Content = await httpRet.Content.ReadAsStringAsync();
            ret.StatusCode = (int)httpRet.StatusCode;
            return ret;
        }
        #endregion

        #region DeleteAsync
        public async Task<HttpClientSharpResponse> DeleteAsync(string url, IDictionary<string, string> headers = null)
        {
            string server = url;
            HttpClient client = _HttpClient;
            var requestMessage = new HttpRequestMessage { Method = HttpMethod.Delete, RequestUri = new Uri(server) };
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    requestMessage.Headers.Add(item.Key, item.Value);
                }
            }
            var httpRet = await client.SendAsync(requestMessage);
            var ret = new HttpClientSharpResponse();
            ret.Content = await httpRet.Content.ReadAsStringAsync();
            ret.StatusCode = (int)httpRet.StatusCode;
            return ret;
        }
        #endregion

        #region PutAsync
        public async Task<HttpClientSharpResponse> PutAsync(string url, string json, IDictionary<string, string> headers = null)
        {
            HttpClient client = _HttpClient;
            var _request = new HttpRequestMessage { Method = HttpMethod.Put, RequestUri = new Uri(url), Content = new System.Net.Http.StringContent(json) };
            _request.Content.Headers.ContentType.CharSet = "utf-8";
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    _request.Headers.Add(item.Key, item.Value);
                }
            }
            _request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var httpRet = await client.SendAsync(_request);
            var ret = new HttpClientSharpResponse();
            ret.Content = await httpRet.Content.ReadAsStringAsync();
            ret.StatusCode = (int)httpRet.StatusCode;
            return ret;
        }
        #endregion
    }

    #region ContentType
    public static class ContentTypeConstants
    {
        public const string ApplicationJson = "application/json";
        public const string FormUrlEncoded = "application/x-www-form-urlencoded";
        public const string FormData = "multipart/form-data";
    }
    #endregion

    #region HttpClientSharpResponse Http响应对象
    public class HttpClientSharpResponse
    {
        public int StatusCode { get; set; }
        public string Content { get; set; }
        public string ErrorMessage { get; set; }
        public Exception ErrorException { get; set; }
    }
    #endregion

    #region HttpClientSharpResponseExtensions Http响应对象扩展：判断请求是否成功
    public static class HttpClientSharpResponseExtensions
    {
        public static bool IsSuccess(this HttpClientSharpResponse t)
        {
            List<int> StatusCodeSuccess = new List<int> { 200, 201, 202, 203, 204, 205, 206 };
            return StatusCodeSuccess.Contains(t.StatusCode);
        }
    }
    #endregion
}