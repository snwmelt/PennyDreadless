using System;
using System.Security.Cryptography;
using System.Text;

namespace PennyDreadless.Models.Core
{
    internal static class StringExtensions
    {
        public static String GetSHA256Hash( this String Input )
        {
            StringBuilder _StringBuilder = new StringBuilder( );

            using ( var _Hash = SHA256.Create( ) )
            {
                Encoding _Encoding = Encoding.UTF8;

                Byte[] _Result = _Hash.ComputeHash( _Encoding.GetBytes( Input ) );

                foreach ( Byte _Byte in _Result )
                {
                    _StringBuilder.Append( _Byte.ToString( "x2" ) );
                }
            }

            return _StringBuilder.ToString( );
        }
    }
}
