using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnkiCardCreator.Model
{
    public class ModelExceptiontEventArgs : EventArgs
    {
        public string message { get; private set; }

        public ModelExceptiontEventArgs(string m)
        {
            message = m;
        }
    }
}
