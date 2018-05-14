using PennyDreadless.Models.Finance.Interfaces;
using System;
using System.Collections.Generic;

namespace PennyDreadless.Models.Core.Interfaces
{
    internal interface IUserDataSerializer
    {
        void AddUser( String ID, Byte[] Key );
        event EventHandler<DataRequestEventArgs> DataRequestEventHandler;
        void LoadUserData( String ID, Byte[] Key );
        IEnumerable<IAccount> UserAccountsData { get; }
        Boolean UserDataExists( String ID );
        Boolean UserKeyIsValid( String ID, Byte[] Key );
    }
}
