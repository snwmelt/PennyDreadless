using System;

namespace PennyDreadless.Models.Core.Interfaces
{
    internal interface IUserAuthenticator
    {
        Boolean Authenticate( String Username, String Password );
        Boolean Create( String Username, String Password );
        Boolean HasAuthenticatedUser { get;  }
        Boolean IsValidPassword( String Password );
        Boolean IsValidUsername( String Username );
        IUser   User { get; }
    }
}
