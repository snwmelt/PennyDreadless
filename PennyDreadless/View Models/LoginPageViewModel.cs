using PennyDreadless.Models.Core;
using PennyDreadless.Models.Core.Enums;
using System;
using System.ComponentModel;
using Walkways.MVVM.View_Model;

namespace PennyDreadless.View_Models
{
    internal class LoginPageViewModel : INotifyPropertyChanged
    {
        #region Private Variables

        private String      _Password;
        private String      _Username;
        private INPCInvoker  _INPCInvoke;

        #endregion

        public LoginPageViewModel( )
        {
            _INPCInvoke         = new INPCInvoker( this );
            CreateUserCommand   = new CommandRelay<Object>( CreateUser, InputIsValid );
            ValidateUserCommand = new CommandRelay<Object>( ValidateUser, InputIsValid );
        }

        private bool InputIsValid( Object obj )
        {
            return PasswordIsValid() &&
                   UsernameIsValid();
        }
        
        public void CreateUser( Object obj )
        {
            // Implement Database Create User?
            Core.NavigationHandler.NavigateTo( UIContent.AccountsPage );
        }

        public CommandRelay<Object> CreateUserCommand
        {
            get;
        }
        

        public String Password
        {
            private get
            {
                return _Password;
            }

            set
            {
                _INPCInvoke.AssignPropertyValue<String>( ref PropertyChanged, ref _Password, value );
            }
        }

        private bool PasswordIsValid( )
        {
            return !String.IsNullOrEmpty( Password );
        }

        public String Username
        {
            private get
            {
                return _Username;
            }

            set
            {
                _INPCInvoke.AssignPropertyValue<String>( ref PropertyChanged, ref _Username, value );
            }
        }

        private bool UsernameIsValid( )
        {
            return !String.IsNullOrEmpty( Username );
        }

        public void ValidateUser( Object obj )
        {
            Core.NavigationHandler.NavigateTo( UIContent.AccountsPage );
        }

        public CommandRelay<object> ValidateUserCommand
        {
            get;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
