using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace AnkiCardCreator.Model
{

    public class ImageDownloader
    {
        readonly string Key = AnkiAppSettings.PixaBayApiKey;

        string q;
        int count;
        int width;

        PixabayRootObject Root;

        public Queue<string> ImagesQueue;

        string request;

        public ImageDownloader(string w)
        {
            q = w;
            count = 100;
            width = 300;

            request = string.Format("https://pixabay.com/api/?key={0}&q={1}&per_page={2}",
                Key,
                q,
                count
                );

            Root = GetImgResponse(request);

            ImagesQueue = new Queue<string>();

            foreach (var val in Root.hits)
            {
                ImagesQueue.Enqueue(val.webformatURL);
            }
        }

        private PixabayRootObject GetImgResponse(string req)
        {

            using (WebClient client = new WebClient())
            {
                string result = client.DownloadString(req);

                return Newtonsoft.Json.JsonConvert.DeserializeObject<PixabayRootObject>(result);
            }
        }

    }
}