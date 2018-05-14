using System.Collections;
using System.Collections.Generic;
using PennyDreadless.Models.Finance.Interfaces;

namespace PennyDreadless.Models.Finance
{
    internal class Account : IAccount
    {
        private List<ITransaction> _Transactions;

        public Account( ushort AccountNumber, uint SortCode, IParticipant Holder )
        {
            _Transactions      = new List<ITransaction>( );
            this.AccountNumber = AccountNumber;
            this.SortCode      = SortCode;
        }

        public ushort AccountNumber
        {
            get;
        }

        public IParticipant Holder
        {
            set;
            get;
        }

        public uint SortCode
        {
            get;
        }

        public int Count
        {
            get
            {
                return _Transactions.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add( ITransaction Item )
        {
            _Transactions.Add( Item );
        }

        public void Clear( )
        {
            _Transactions.Clear( );
        }

        public bool Contains( ITransaction Item )
        {
            return _Transactions.Contains( Item );
        }

        public void CopyTo( ITransaction[] Array, int ArrayIndex )
        {
            _Transactions.CopyTo( Array, ArrayIndex );
        }

        public IEnumerator<ITransaction> GetEnumerator( )
        {
            return _Transactions.GetEnumerator( );
        }

        public bool Remove( ITransaction Item )
        {
            return _Transactions.Remove( Item );
        }

        IEnumerator IEnumerable.GetEnumerator( )
        {
            return _Transactions.GetEnumerator( );
        }
    }
}
