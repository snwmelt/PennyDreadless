using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    /// <summary>
    /// Represents an amount in a given currency.
    /// </summary>
    public interface IAmount
    {
        /// <summary>
        /// The sovereign state that issues the currency.
        /// </summary>
        ICurrency Currency { get; }

        /// <summary>
        /// Amount of currency.
        /// </summary>
        Decimal Value { get; }
    }
}
