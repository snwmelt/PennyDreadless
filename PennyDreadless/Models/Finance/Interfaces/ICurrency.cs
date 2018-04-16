using PennyDreadless.Models.Region.Interfaces;
using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    internal interface ICurrency
    {
        String Abbreviation { get; }

        ICountry Country { get; }

        String Name { get; }
    }
}
