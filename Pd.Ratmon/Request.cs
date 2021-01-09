using IO.Swagger.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Pd.Ratmon
{
    public static class Request
    {
        public async static Task<GetToken> PostRequestAuth(string username, string password)
        {
            string url = "https://demo.ratmon.com/Account/GetToken";

            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            };

            HttpContent q = new FormUrlEncodedContent(queries);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(url, q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                        GetToken deserializedTokenAuth = JsonConvert.DeserializeObject<GetToken>(mycontent);
                        return deserializedTokenAuth;
                    }
                }
            }
        }
         
        public async static Task<List<AllCircuits>> GetRequestAllCircuits(GetToken token)
        {
            string url = "https://demo.ratmon.com/api/Circuit/Get";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        var t = new AllCircuits();
                        List<AllCircuits> allCircuits = JsonConvert.DeserializeObject<List<AllCircuits>>(mycontent);
                        return allCircuits;
                    }
                }
            }
        }
         
        public async static Task<List<AllCircuitsChannels>> GetRequestAllChannels(int id, GetToken token)
        {
            string url = "https://demo.ratmon.com/api/Circuit/Get";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        List<AllCircuits> allCircuits = JsonConvert.DeserializeObject<List<AllCircuits>>(mycontent);
                        return null;
                    }
                }
            }
        }


        public async static Task<SelectedChannel> GetRequestSelectedChanel(int chanel, GetToken token)
        {
            string url = "https://demo.ratmon.com/api/Channel/Get" + "?id=" + chanel.ToString();
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        var t = new SelectedChannel();
                        SelectedChannel selectedChannel = JsonConvert.DeserializeObject<SelectedChannel>(mycontent);
                        return selectedChannel;
                    }
                }
            }
        }
         
    }
}
