using System;
using System.Collections.Generic;

namespace PennyDreadless.Models.Finance.Interfaces
{
    /// <summary>
    /// Represents a participant's account.
    /// </summary>
    public interface IAccount : ICollection<ITransaction>
    {
        /// <summary>
        /// The account identification number.
        /// </summary>
        UInt16 AccountNumber { get; }
        
        /// <summary>
        /// The onwer of the account.
        /// </summary>
        IParticipant Holder { get; }
        
        /// <summary>
        /// The identification number of the account's branch within a bank.
        /// </summary>
        uint SortCode { get; }
    }
}