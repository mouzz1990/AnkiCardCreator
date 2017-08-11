using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnkiCardCreator.Model;

namespace AnkiCardCreator.Interfaces
{
    public interface IView
    {
        Presenter presenter { get; set; }

        string Word { get; set; }
        string Translation { get; set; }
        string Transcription { get; set; }
        string Language { get; set; }
        string AlternativeImageSearch { get; set; }

        event EventHandler TranslationChanged;

        void DisplayTranslation(string w, string tr, string ts);
        void ViewCatchModelException(string message);
        void GetTranslation();
        void DisplayImage();
        string GetSelectedURL();
        void ChangeAnkiContentFolder();
        
        void SuccessfullMessage();
        void ErrorMessage(); //not use

        
    
    }
}
