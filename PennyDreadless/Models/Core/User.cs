using PennyDreadless.Models.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace PennyDreadless.Models.Core
{
    internal class User : IUser
    {
        public User ( String Username, List<String>Keys )
        {
            this.Keys = Keys;
            this.Username = Username;
        }

        public List<String> Keys
        {
            get;
        }

        public String Username
        {
            get;
        }
    }
}
