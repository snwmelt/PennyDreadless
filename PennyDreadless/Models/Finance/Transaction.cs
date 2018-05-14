using System;
using PennyDreadless.Models.Finance.Interfaces;

namespace PennyDreadless.Models.Finance
{
    public class Transaction : ITransaction
    {
        public Transaction( IParticipant Payee, IParticipant Payer, IAmount Amount, DateTime Date )
        {
            this.Payee  = Payee;
            this.Payer  = Payer;
            this.Amount = Amount;
            this.Date   = Date;
        }

        public Transaction( IParticipant Payee, IParticipant Payer, IAmount Amount ) : this( Payee, Payer, Amount, DateTime.Now )
        {
        }

        public IAmount Amount
        {
            get;
        }

        public DateTime Date
        {
            get;
        }

        public IParticipant Payee
        {
            get;
        }

        public IParticipant Payer
        {
            get;
        }
    }
}
