using System;
using System.Collections.Generic;

namespace PennyDreadless.Models.Core.Interfaces
{
    internal interface IUser
    {
        List<String> Keys { get; }
        String Username { get; }
    }
}