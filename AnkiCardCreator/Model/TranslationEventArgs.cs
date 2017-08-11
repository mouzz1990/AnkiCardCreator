using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnkiCardCreator.Model
{
    public class TranslationEventArgs : EventArgs
    {
        public string NewWord;

        public TranslationEventArgs(string str)
        {
            NewWord = str;
        }
    }
}
