using System.Collections.Generic;
using PennyDreadless.Models.Core.Interfaces;
using PennyDreadless.Models.Finance.Interfaces;

namespace PennyDreadless.Models.Core
{
    internal class DataContext : IDataContext
    {
        public IEnumerable<IAccount> Accounts
        {
            get;
        }
    }
}
