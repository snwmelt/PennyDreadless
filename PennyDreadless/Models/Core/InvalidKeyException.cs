using System;
using System.Runtime.InteropServices;

namespace PennyDreadless.Models.Core
{
    [ComVisible( true )]
    [Serializable]
    internal class InvalidKeyException : AccessViolationException
    {
        public InvalidKeyException( ) : base() { }

        public InvalidKeyException( string message ) : base( message ) { }

        public InvalidKeyException( string message, Exception innerException ) : base( message, innerException ) { }
    }
}
