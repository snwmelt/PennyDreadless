using PennyDreadless.Models.Region.Interfaces;
using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    /// <summary>
    /// Represents a currency of a given country.
    /// </summary>
    public interface ICurrency
    {
        /// <summary>
        /// Shorthand name of currency.
        /// </summary>
        String Abbreviation { get; }

        /// <summary>
        /// Country of use.
        /// </summary>
        ICountry Country { get; }

        /// <summary>
        /// Full name of currency.
        /// </summary>
        String Name { get; }

        /// <summary>
        /// Symbol representing currency.
        /// </summary>
        Char Symbol { get; }
    }
}
