using PennyDreadless.Models.Core.Enums;
using PennyDreadless.Models.Core.Interfaces;
using PennyDreadless.Models.Finance.Interfaces;
using SerialPersistanceLibrary;
using SerialPersistanceLibrary.Enums;
using SerialPersistanceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace PennyDreadless.Models.Core
{
    /// <summary>
    /// An implementation of the PennyDreadless.Models.Core.Interfaces.IUserDataSerializer interface.
    /// </summary>
    internal sealed class DataContext : IUserDataSerializer
    {
        #region Private Variables

        private IEncryptedSerializer  _IEncryptedSerlizer = new RijndaelManagedEncryptedSerializer( );
        private String                _ConfrimationString = "PennyDreadlessLovesYou";
        private IEnumerable<IAccount> _UserAccountsData;
        private String                _UserDataLocation   = Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments ), "PennyDreadless", "DataContext" );
        
        #endregion


        public void AddUser( String ID, Byte[] Key )
        {
            if ( Directory.Exists ( Path.Combine( _UserDataLocation, ID ) ) )
            {
                throw new AccessViolationException( "User Data Exists" );
            }

            Directory.CreateDirectory( Path.Combine( _UserDataLocation, ID ) );

            _IEncryptedSerlizer.Serialize( _ConfrimationString, Path.Combine( _UserDataLocation, ID, "KV" ), IOSerializationFormatter.BinaryFormatter, Key );
        }
        
        public event EventHandler<DataRequestEventArgs> DataRequestEventHandler;

        public void Dispose( )
        {
            _IEncryptedSerlizer.Dispose( );
        }

        public void LoadUserAccountsData( String ID, Byte[] Key )
        {
            throw new NotImplementedException( );
        }

        public IEnumerable<IAccount> UserAccountsData
        {
            get
            {
                return _UserAccountsData;
            }

            private set
            {
                _UserAccountsData = value;

                DataRequestEventHandler?.Invoke( this, new DataRequestEventArgs( DataRequestResult.Success ) );
            }
        }
        
        public Boolean UserDataExists( String ID )
        {
            return Directory.Exists( Path.Combine( _UserDataLocation, ID ) );
        }

        public bool UserKeyIsValid( String ID, Byte[] Key )
        {
            try
            {
                var _DeserializeOutput = _IEncryptedSerlizer.Deserialize( Path.Combine( _UserDataLocation, ID, "KV" ), IOSerializationFormatter.BinaryFormatter, Key );

                return ( _DeserializeOutput == _ConfrimationString );
            }
            catch ( Exception Ex )
            {
                System.Diagnostics.Debug.WriteLine( Ex );

                return false;
            }
        }
    }
}
