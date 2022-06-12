using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MegafonSmsAPI
{
    public class MegafonSmsClient : IDisposable
    {
		private const string url = "https://a2p-api.megalabs.ru/sms/v1/sms";
		private const string contentType = "application/json";

		private readonly string _login;
        private readonly string _password;
        private HttpClient _httpClient = new HttpClient();

		public MegafonSmsClient(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public async Task<SendResult> SendSmsAsync(SmsMessage message)
        {
            if (message is null)
            {
                throw new ArgumentNullException(nameof(message));
            }

			string content = JsonConvert.SerializeObject(message);

			var authToken = Encoding.ASCII.GetBytes($"{_login}:{_password}");

			_httpClient.DefaultRequestHeaders.Accept.Clear();
			_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
			_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));

			HttpContent httpContent = new StringContent(content, Encoding.UTF8, contentType);

			var httpResponse = await _httpClient.PostAsync(url, httpContent);
			var responseContent = await httpResponse.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<SendResult>(responseContent);
		}
		public SendResult SendSms(SmsMessage message)
		{
			var task = SendSmsAsync(message);
			task.Wait();
			return task.Result;
		}

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
