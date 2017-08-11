using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace AnkiCardCreator.Model
{
    public class ImageDownloader
    {
        readonly string RequestHeader = "Ocp-Apim-Subscription-Key";
        readonly string  ApiKey = "0eb6a27102c84aeca101b5ff3964bed3";

        string q;
        int count;
        int width;

        ImgRootObject Root;
        
        public Queue<string> ImagesQueue;

        string request;

        public ImageDownloader(string w)
        {
            q = w;
            count = 50;
            width = 300;

            request = string.Format("https://api.cognitive.microsoft.com/bing/v5.0/images/search?q={0}&count={1}&offset=0&mkt=en-us&safeSearch=Moderate&width={2}", q, count, width);

            Root = GetImgResponse(request);
            
            ImagesQueue = new Queue<string>();
            
            foreach (Value val in Root.value)
            {
                ImagesQueue.Enqueue(val.contentUrl);
            }
        }

        ImgRootObject GetImgResponse(string req)
        {

            using (WebClient client = new WebClient())
            {
                client.Headers.Add(RequestHeader, ApiKey);

                string result = client.DownloadString(req);

                return Newtonsoft.Json.JsonConvert.DeserializeObject<ImgRootObject>(result);
            }
        }
    }
}
