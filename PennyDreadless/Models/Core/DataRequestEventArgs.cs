using PennyDreadless.Models.Core.Enums;
using System;

namespace PennyDreadless.Models.Core
{
    internal class DataRequestEventArgs : EventArgs
    {
        public DataRequestResult Result
        {
            get;
        }

        public Exception Exception
        {
            get;
        }

        public DataRequestEventArgs( DataRequestResult Result, Exception Exception = null )
        {
            this.Exception = Exception;
            this.Result    = Result;
        }
    }
}
