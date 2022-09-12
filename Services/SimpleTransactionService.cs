
using Newtonsoft.Json;
using System.Text;

namespace ERCAJ_BANCO_proj.Services
{
    public class SimpleTransactionService
    {
        private HttpClient HttpClient;
        private Uri BaseUri;

        public int Posicion { get; set; } = 0;

        public SimpleTransactionService()
        {
            HttpClient = new HttpClient();
            BaseUri = new Uri($"https://localhost:44326/api/vxtra/");
        }

        public async Task<T> GetFirst<T>()
        {
            Posicion = 0;
            var uri = new Uri(BaseUri, $"{typeof(T).Name}/GetFull?%24top=1&%24skip=0");
            
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
            try
            {
                var response = await HttpClient.SendAsync(httpRequestMessage);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<VXResponseOdata<T>>(content);
                    return (result == null)? default : result.Value[0];
                }
            }
            catch (Exception e)
            {
                //TODO verificar posibles errores
            }
            return default;
        }

        public async Task<T> GetOne<T>(int start)
        {
            Posicion = start;
            var uri = new Uri(BaseUri, $"{typeof(T).Name}/GetFull?%24top=1&%24skip={start}");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
            try
            {
                var response = await HttpClient.SendAsync(httpRequestMessage);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<VXResponseOdata<T>>(content);
                    return (result == null) ? default : result.Value[0];
                }
            }
            catch (Exception e)
            {
                //TODO verificar posibles errores
            }
            return default;
        }

        public async Task<List<T>> GetList<T>(int limit, int start)
        {
            var uri = new Uri(BaseUri, $"{typeof(T).Name}/GetFull?%24top={limit}&%24skip={start}");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
            try
            {
                var response = await HttpClient.SendAsync(httpRequestMessage);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<VXResponseOdata<T>>(content);
                    return (result == null) ? default : result.Value;
                }
            }
            catch (Exception e)
            {
                //TODO verificar posibles errores
            }
            return default;
        }
    }
}

