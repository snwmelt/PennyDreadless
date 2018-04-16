using System;
using System.Collections.Generic;

namespace PennyDreadless.Models.Finance.Interfaces
{
    interface IAccount
    {
        uint AccountNumber { get; }

        Boolean AddTransaction( ITransaction Transaction );

        IParticipant Holder { get; }

        Boolean RemoveTransaction ( ITransaction Transaction );

        uint SortCode { get; }

        IEnumerable<ITransaction> Transactions { get; }
    }
}