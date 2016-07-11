using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Botsy
{
    public class Movies
    {
        public static async Task<MovieInfo> GetMovieInfoAsync(string movieName)
        {
            if (string.IsNullOrWhiteSpace(movieName))
                return null;

            string url = $"http://www.omdbapi.com/?t=" + movieName;
            string json;
            using (WebClient client = new WebClient())
            {
                json = await client.DownloadStringTaskAsync(url).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<MovieInfo>(json);
        }
    }
}