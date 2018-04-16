using System.Collections.Generic;
using PennyDreadless.Models.Finance.Interfaces;

namespace PennyDreadless.Models.Finance
{
    internal class Account : IAccount
    {
        private List<ITransaction> _Transactions; // should be populated from a database

        public Account ( IParticipant Holder )
        {
            this.Holder = Holder;
        }

        public uint AccountNumber
        {
            get;
            set;
        }

        public IParticipant Holder
        {
            get;

            private set;
        }

        public uint SortCode
        {
            get;
            set;
        }

        public IEnumerable<ITransaction> Transactions // Possibly fetch here?
        {
            get
            {
                return _Transactions;
            }
        }

        public bool AddTransaction( ITransaction Transaction ) // True / Flase based on databse success / fail
        {
            _Transactions.Add( Transaction );

            return false;
        }

        public bool RemoveTransaction( ITransaction Transaction ) // True / Flase based on databse success / fail
        {
            _Transactions.Remove( Transaction );

            return false;
        }
    }
}
