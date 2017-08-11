using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnkiCardCreator.Model;
using AnkiCardCreator.Interfaces;

namespace AnkiCardCreator
{
    public class Presenter
    {
        Model.Model model;
        IView view;
        

        public Presenter(Model.Model m, IView v)
        {
            model = m;
            view = v;

            view.presenter = this;
            view.TranslationChanged += new EventHandler(view_TranslationChanged);

            model.YandexTranslateError += ModelExceptinCatched;
            model.BingDownloaderError += ModelExceptinCatched;
            model.AnkiCardCreatorError += ModelExceptinCatched;
        }

        void ModelExceptinCatched(object sender, EventArgs e)
        {
            ModelExceptiontEventArgs arg = (ModelExceptiontEventArgs)e;
            view.ViewCatchModelException(arg.message);
        }

        void view_TranslationChanged(object sender, EventArgs e)
        {
            model.Translator.Translation = view.Translation;
        }

        public void ShowTranslation()
        {
            model.MakeTranslation(view.Word, view.Language);
            view.DisplayTranslation(model.Translator.Word, model.Translator.Translation, model.Translator.Transcription);
        }

        public string GetTranslationTemp()
        {
            return model.Translator.Translation;
        }

        public string GetImageUrl()
        {
            string temp = model.QueueUrl.Dequeue();
            model.QueueUrl.Enqueue(temp);
            return temp;
        }

        public void OnCreateAnkiCard(string url)
        {
            bool CreateResult = model.CreateAnkiCard(view.GetSelectedURL());
                if (CreateResult) view.SuccessfullMessage();
        }

        public void AlternativeSearchImage()
        {
            model.DownloadImages(view.AlternativeImageSearch);
        }
    }
}
