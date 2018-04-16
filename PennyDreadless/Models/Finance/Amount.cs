using PennyDreadless.Models.Finance.Interfaces;
using System;

namespace PennyDreadless.Models.Financial
{
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
