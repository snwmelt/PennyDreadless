using PennyDreadless.Models.Finance.Interfaces;
using System;

namespace PennyDreadless.Models.Financial
{
    /// <summary>
    /// An implementation of the PennyDreadless.Models.Finance.Interfaces.IAmount interface.
    /// </summary>
    internal class Amount : IAmount
    {
        public Amount( Decimal Value, ICurrency Currency )
        {
            this.Currency = Currency;
            this.Value    = Value;
        }

        public ICurrency Currency
        {
            get;
            private set;
        }


        public Decimal Value
        {
            get;
            private set;
        }
    }
}
