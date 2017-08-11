using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json.Linq;
using AnkiCardCreator.Interfaces;

namespace AnkiCardCreator.Model
{
    public class TranslatorYandex : ITranslater
    {
        public string Word { get; set; }
        public string Translation { get; set; }
        public string Transcription { get; set; }
        public string Language { get; set; }

        public TranslatorYandex(string word, string language)
        {
            Word = word;
            Language = language;
            GetTranslation();
        }

        public void GetTranslation()
        {
            try
            {
                var translateUrl = "https://dictionary.yandex.net/dicservice.json/lookup?ui=ru&text="
                                    + Word + 
                                    "&lang=" + Language + "&flags=23";

                using (var wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    var resultHtml = wc.DownloadString(translateUrl);

                    dynamic trsJson = JObject.Parse(resultHtml);

                    var translation = trsJson.def[0].tr[0].text;
                    var transcription = trsJson.def[0].ts;

                    Translation = translation;
                    Transcription = transcription;
                }
            }

            catch (Newtonsoft.Json.JsonReaderException)
            {
                Transcription = "JsonReaderException";
                Translation = "JsonReaderException";
            }

            catch (Newtonsoft.Json.JsonException)
            {
                Transcription = "Newtonsoft.Json.JsonException";
                Translation = "Newtonsoft.Json.JsonException";
            }
            catch (WebException)
            {
                Transcription = "WebException";
                Translation = "WebException";
            }
            catch (NotSupportedException)
            {
                Transcription = "NotSupportedException";
                Translation = "NotSupportedException";
            }

            catch (Exception)
            {
                Transcription = "Ошибка перевода";
                Translation = "Ошибка перевода";
            }
        }

        public void ChangeLanguage()
        { 
            
        }
    }
}
