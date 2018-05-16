using PennyDreadless.Models.Core.Enums;
using System;

namespace PennyDreadless.Models.Core
{
    /// <summary>
    /// Represents the outcome of a data request as combination of a PennyDreadless.Models.Core.Enums.DataRequestResult
    /// result and encapsulates any System.Exception that may be raised during the data request operation.
    /// </summary>
    public class DataRequestEventArgs : EventArgs
    {
        /// <summary>
        /// Outcome of the data request.
        /// </summary>
        public DataRequestResult Result
        {
            get;
        }

        /// <summary>
        /// Any System.Exception that may have occured during the data request.
        /// </summary>
        public Exception Exception
        {
            get;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="Result">Outcome Of The Data Request.</param>
        /// <param name="Exception">Any System.Exception That May Have Occured During The Data Request.</param>
        public DataRequestEventArgs( DataRequestResult Result, Exception Exception = null )
        {
            this.Exception = Exception;
            this.Result    = Result;
        }
    }
}
