using System;

namespace PennyDreadless.Models.Core.Interfaces
{
    internal interface IUserAuthenticator
    {
        void Authenticate( String Username, String Password );
        Boolean Create( String Username, String Password );
        void DeAuthenticate( );
        Boolean HasAuthenticatedUser { get; }
        Boolean IsAValidPassword( String Password );
        Boolean IsAValidUsername( String Username );
        Boolean UserExists( string username );
        String UserID { get; }
        Byte[] UserKey { get; }
        String Username { get; }

    }
}