using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    internal interface IParticipant
    {
        String Title { get; }

        Boolean HasAccount { get; }

        IAccount Account { get; }
    }
}
