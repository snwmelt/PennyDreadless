using System;
using System.Collections.Generic;

namespace PennyDreadless.Models.Finance.Interfaces
{
    public interface IAccount : ICollection<ITransaction>
    {
        UInt16 AccountNumber { get; }
        
        IParticipant Holder { set; get; }
        
        uint SortCode { get; }
    }
}