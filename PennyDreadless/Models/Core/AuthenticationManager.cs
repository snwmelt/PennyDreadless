using PennyDreadless.Models.Core.Interfaces;
using System;

namespace PennyDreadless.Models.Core
{
    internal class AuthenticationManager : IUserAuthenticator
    {
        #region Private Variables



        #endregion

        public Boolean Authenticate( String Username, String Password )
        {
            return true;
        }

        public Boolean Create( String Username, String Password )
        {
            return true;
        }

        public bool HasAuthenticatedUser
        {
            get;
            private set;
        }

        public Boolean IsValidPassword( String password )
        {
            return true;
        }

        public Boolean IsValidUsername( String username )
        {
            return true;
        }

        public IUser User
        {
            get;
            private set;
        }
    }
}
