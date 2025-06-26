using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RTLVuln
{
    public class ResponseHandlerDeepSeek
    {
        public HttpClient _httpClient { get; }


        public ResponseHandlerDeepSeek(bool IsCloudDeepSeek)
        {
            string ApiKeyURL = string.Empty;
            _httpClient = new HttpClient();
            if (IsCloudDeepSeek)
            {
                ApiKeyURL = RTLVuln.Properties.Resources.deepseekapiurl;
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {RTLVuln.Properties.Resources.deepseekapikey}");
            }
            else
            {
                ApiKeyURL = RTLVuln.Properties.Resources.deepseekurllocal;
            }
            _httpClient.BaseAddress = new Uri(ApiKeyURL);
        }

        public async Task<string> HttpPost(string requestUri, string serializeObject)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
            requestMessage.Content = new StringContent(serializeObject);
            requestMessage.Content.Headers.ContentType
             = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            if (((int)response.StatusCode) == 401)
                throw new UnauthorizedAccessException();

            var responseBody = await response.Content.ReadAsStringAsync();
            
            return responseBody;
        }

    }
}
