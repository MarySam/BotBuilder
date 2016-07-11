using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Botsy
{
    public class LuisMovieClient
    {
        public static async Task<LuisInfo> ParseUserInput(string strInput)
        {
            string strRet = string.Empty;
            string strEscaped = Uri.EscapeDataString(strInput);

            using (var client = new HttpClient())
            {
                string uri = "https://api.projectoxford.ai/luis/v1/application?id=27eb0729-4391-4880-a04f-dae911162fe1&subscription-key=a0794768387a459da34bab6f49878c1e&q=" + strEscaped;
                HttpResponseMessage msg = await client.GetAsync(uri);

                if (msg.IsSuccessStatusCode)
                {
                    string jsonResponse = await msg.Content.ReadAsStringAsync();
                    LuisInfo _Data = JsonConvert.DeserializeObject<LuisInfo>(jsonResponse);
                    return _Data;
                }
            }
            return null;
        }
    }

    public class LuisInfo
    {
        public string query { get; set; }
        public Intent[] intents { get; set; }
        public Entity[] entities { get; set; }
    }

    public class Intent
    {
        public string intent { get; set; }
        public float score { get; set; }
    }

    public class Entity
    {
        public string entity { get; set; }
        public string type { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public float score { get; set; }
    }
}