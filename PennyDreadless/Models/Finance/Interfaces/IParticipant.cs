using System;

namespace PennyDreadless.Models.Finance.Interfaces
{
    public interface IParticipant
    {
        String Title { get; }

        Boolean HasAccounts { get; }
    }
}
