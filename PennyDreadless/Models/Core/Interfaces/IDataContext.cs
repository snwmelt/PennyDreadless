using PennyDreadless.Models.Finance.Interfaces;
using System.Collections.Generic;

namespace PennyDreadless.Models.Core.Interfaces
{
    internal interface IDataContext
    {
        IEnumerable<IAccount> Accounts { get; }
    }
}
