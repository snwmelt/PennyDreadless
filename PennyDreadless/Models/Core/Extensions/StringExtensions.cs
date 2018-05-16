using System;
using System.Security.Cryptography;
using System.Text;

namespace PennyDreadless.Models.Core.Extensions
{
    /// <summary>
    /// Contains extension methods for the System.String type.
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        /// Generates an SHA256 from the System.Array Instance passed by the user.
        /// </summary>
        /// <param name="This">System.String Instance To Be Operated On.</param>
        /// <returns>String Containing SHA256 Hash Of This String.</returns>
        public static String GetSHA256Hash( this String This )
        {
            StringBuilder _StringBuilder = new StringBuilder( );

            using ( var _Hash = SHA256.Create( ) )
            {
                Encoding _Encoding = Encoding.UTF8;

                Byte[] _Result = _Hash.ComputeHash( _Encoding.GetBytes( This ) );

                foreach ( Byte _Byte in _Result )
                {
                    _StringBuilder.Append( _Byte.ToString( "x2" ) );
                }
            }

            return _StringBuilder.ToString( );
        }
    }
}
