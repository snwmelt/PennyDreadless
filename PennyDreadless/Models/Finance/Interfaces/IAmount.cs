using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    internal interface IAmount
    {
        ICurrency Currency { get; }

        Decimal Value { get; }
    }
}
