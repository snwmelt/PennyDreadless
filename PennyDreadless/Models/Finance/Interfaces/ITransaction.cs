using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    internal interface ITransaction
    {
        IAmount Amount { get; }

        DateTime Date { get; }

        IParticipant Payee { get; }

        IParticipant Payer { get; }
    }
}
