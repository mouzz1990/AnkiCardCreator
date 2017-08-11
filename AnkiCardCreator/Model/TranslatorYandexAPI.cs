using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnkiCardCreator.Interfaces;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace AnkiCardCreator.Model
{
    //Does not work with my mobile operator. LifeCell are blocking yandex request

    public class TranslatorYandexAPI : ITranslater
    {
        public string Word { get; set; }
        public string Translation {get;set;}
        public string Transcription { get; set; }

        public TranslatorYandexAPI(string word)
        {
            Word = word;

            request = string.Format(@"https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}", ApiKey, Word, lang);

            GetTranslation();
        }

        string request;
        string ApiKey = "";
        
        string lang = "en-ru";

        public void GetTranslation()
        {
            using (WebClient wc = new WebClient())
            {
                string respond = wc.DownloadString(request);
                dynamic trJson = JObject.Parse(respond);

                var translation = trJson.text;
                
                Translation = translation;
                Transcription = "-";
            }
        }



        public string Language
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void ChangeLanguage()
        {
            throw new NotImplementedException();
        }
    }
}
