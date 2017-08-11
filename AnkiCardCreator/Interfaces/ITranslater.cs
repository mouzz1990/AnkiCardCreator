using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnkiCardCreator.Interfaces
{
    public interface ITranslater
    {
        string Word { get; set; }
        string Translation { get; set; }
        string Transcription { get; set; }
        string Language { get; set; }

        void GetTranslation();
        void ChangeLanguage();
    }
}
