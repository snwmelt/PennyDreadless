using PennyDreadless.Models.Finance.Interfaces;
using System;
using System.Collections.Generic;

namespace PennyDreadless.Models.Core.Interfaces
{
    /// <summary>
    /// An interface defining the required properties of a user data serialization handler.
    /// </summary>
    public interface IUserDataSerializer : IDisposable
    {
        /// <summary>
        /// Add user to authenticated users pool.
        /// </summary>
        /// <param name="ID">User Identification String.</param>
        /// <param name="Key">Byte[] Array Representation of User Authentication Key.</param>
        void AddUser( String ID, Byte[] Key );

        /// <summary>
        /// Event to be raised when a user data event occurs.
        /// </summary>
        event EventHandler<DataRequestEventArgs> DataRequestEventHandler;

        /// <summary>
        /// Load an authenticated user's data from store.
        /// </summary>
        /// <param name="ID">User Identification String.</param>
        /// <param name="Key">Byte[] Array Representation of User Authentication Key.</param>
        void LoadUserAccountsData( String ID, Byte[] Key );

        /// <summary>
        /// IEnumerable collection of user account data.
        /// </summary>
        IEnumerable<IAccount> UserAccountsData { get; }

        /// <summary>
        /// Checks if user identification string is authenticated and in users pool.
        /// </summary>
        /// <param name="ID">User Identification String.</param>
        /// <returns>True if user identification string is authenticated and in users pool.</returns>
        Boolean UserDataExists( String ID );

        /// <summary>
        /// Checks if the provided key is the user's authentication key.
        /// </summary>
        /// <param name="ID">User Identification String.</param>
        /// <param name="Key">Byte[] Array Representation of User Authentication Key.</param>
        /// <returns>True if the provided key is the user's authentication key.</returns>
        Boolean UserKeyIsValid( String ID, Byte[] Key );
    }
}
