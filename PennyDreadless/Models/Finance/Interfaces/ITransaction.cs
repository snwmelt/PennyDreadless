using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    /// <summary>
    /// Represents an exchange of funds between two participants.
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// The amount being exchanged.
        /// </summary>
        IAmount Amount { get; }

        /// <summary>
        /// The date the exchange occured/will occur.
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Participant receiving funds from the exchange.
        /// </summary>
        IParticipant Payee { get; }

        /// <summary>
        /// Participant giving funds to the exchange. 
        /// </summary>
        IParticipant Payer { get; }
    }
}
