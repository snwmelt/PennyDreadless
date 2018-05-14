using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    public interface IAmount
    {
        ICurrency Currency { get; }

        Decimal Value { get; }
    }
}
