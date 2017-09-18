using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnkiCardCreator.Interfaces;
using System.IO;

namespace AnkiCardCreator.Model
{
    public class Model
    {
        AnkiCard Card;
        ImageDownloader ImgDownloader;

        
        public ITranslater Translator { get; set; }
        
        public Queue<string> QueueUrl;

        public string Translation { get; set; }
        public string Transcription { get; private set; }

        public event EventHandler YandexTranslateError;
        public event EventHandler BingDownloaderError;
        public event EventHandler AnkiCardCreatorError;

        public void MakeTranslation(string word, string language)
        {
            try
            {
                Translator = new TranslatorYandex(word, language);
                //Translator = new TranslatorYandexAPI(word);
            }
            catch (Exception)
            { 
                YandexTranslateError(this, new ModelExceptiontEventArgs("Ошибка с запросом переводчика."));
            }
            
            DownloadImages();
        }
        
        public void DownloadImages()
        {
            try
            {
                ImgDownloader = new ImageDownloader(Translator.Word);

                QueueUrl = ImgDownloader.ImagesQueue;
            }
            catch
            {
                BingDownloaderError(this, new ModelExceptiontEventArgs("Ошибка с загрузкой изображений."));
            }
        }


        public void DownloadImages(string word)
        {
            try
            {
                ImgDownloader = new ImageDownloader(word);

                QueueUrl = ImgDownloader.ImagesQueue;
            }
            catch
            {
                BingDownloaderError(this, new ModelExceptiontEventArgs("Ошибка с загрузкой изображений."));
            }
        }

        public bool CreateAnkiCard(string imgUrl)
        {
            try
            {
                Card = new AnkiCard(Translator.Word, Translator.Translation, Translator.Transcription, imgUrl);
                Card.SaveCard();
                return true;
            }
            catch (DirectoryNotFoundException exc)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(string.Format("Произошла ошибка при копировании изображения в папку контента Anki.{0}Пожалуйста проверьте указанный путь нажатием правой кнопкой мыши на форму и выбрав \"Изменить папку контента Anki.\"{0}{0}{1}", Environment.NewLine, exc.Message));
                AnkiCardCreatorError(this, new ModelExceptiontEventArgs(sb.ToString()));
                return false;
            }
            catch
            {
                AnkiCardCreatorError(this, new ModelExceptiontEventArgs("Ошибка с созданием Anki-карточки."));
                return false;
            }
        }
    }
}
