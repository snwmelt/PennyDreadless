using System;
using System.Collections.Generic;

namespace PennyDreadless.Models.Finance.Interfaces
{
    /// <summary>
    /// Represents a person or company involved in a financial transaction.
    /// </summary>
    public interface IParticipant
    {
        /// <summary>
        /// Name of company or person.
        /// </summary>
        String Name { get; }

        /// <summary>
        /// Indicates if this company or person currently owns any accounts.
        /// </summary>
        Boolean HasAccounts { get; }

        /// <summary>
        /// A collection of accounts owned by this company or person.
        /// </summary>
        ICollection<IAccount> Accounts { get; }
    }
}
