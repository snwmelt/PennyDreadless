﻿using PennyDreadless.Models.Core.Extensions;
using PennyDreadless.Models.Core.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;

namespace PennyDreadless.Models.Core
{
    /// <summary>
    /// An implementation of the PennyDreadless.Models.Core.Interfaces.IUserAuthenticator interface.
    /// </summary>
    internal class AuthenticationManager : IUserAuthenticator
    {
        public void Authenticate( String Username, String Password )
        {
            String _UserID = Username.GetSHA256Hash( );

            if ( !Core.UserDataSerializer.UserDataExists( _UserID ) )
            {
                throw new AccessViolationException( "User Does Not Exist." );
            }

            Byte[] _UserKey = _Generate256BitKey( Password.GetSHA256Hash( ), _UserID );

            if ( !Core.UserDataSerializer.UserKeyIsValid( _UserID, _UserKey ) )
            {
                throw new AccessViolationException( "User Password Incorrect." );
            }

            UserID        = _UserID;
            UserKey       = _UserKey;
            this.Username = Username;
        }
        
        public Boolean Create( String Username, String Password )
        {
            Core.UserDataSerializer.AddUser( Username.GetSHA256Hash( ), _Generate256BitKey( Password.GetSHA256Hash( ), Username.GetSHA256Hash( ) ) );

            return true;
        }

        public void DeAuthenticate( )
        {
            UserID   = null;
            UserKey  = null;
            Username = null;
        }

        /// <summary>
        /// Generates a 256 bit System.Byte[] representation of the user password combined with a salt.
        /// </summary>
        /// <param name="Password">System.String Containing User Password.</param>
        /// <param name="Salt">System.String Containing Salt To Combine With User Password.</param>
        /// <returns>Resulting Syste.Byte[] Key From Rfc2898DeriveBytes( string, byte[], int )</returns>
        private Byte[] _Generate256BitKey( String Password, String Salt )
        {
            return ( new Rfc2898DeriveBytes( Password, Encoding.ASCII.GetBytes( Salt ), 300 ) ).GetBytes( 32 );
        }
        
        public bool HasAuthenticatedUser
        {
            get
            {
                return !( Username is null );
            }
        }
        
        public Boolean IsAValidPassword( String Password )
        {
            return !String.IsNullOrEmpty( Password );
        }

        public Boolean IsAValidUsername( String Username )
        {
            return !String.IsNullOrEmpty( Username );
        }

        public Boolean UserExists( String Username )
        {
            if ( String.IsNullOrEmpty( Username ) )
            {
                return false;
            }

            return Core.UserDataSerializer.UserDataExists( Username.GetSHA256Hash( ) );
        }

        public String UserID
        {
            get;
            private set;
        }

        public Byte[] UserKey
        {
            get;
            private set;
        }

        public String Username
        {
            get;
            private set;
        }
    }
}
