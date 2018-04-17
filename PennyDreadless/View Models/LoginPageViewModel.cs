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
        private INPCInvoke  _INPCInvoke;

        #endregion

        public LoginPageViewModel ( )
        {
            _INPCInvoke         = new INPCInvoke( this );
            CreateUserCommand   = new CommandRelay<Object>( CreateUser, InputIsValid );
            ValidateUserCommand = new CommandRelay<Object>( ValidateUser, InputIsValid );

            Password = "Password";
            Username = "Username";
        }

        private bool InputIsValid( Object obj )
        {
            return !( obj is null ); // Need to write proper validation
        }

        public void CreateUser( Object obj )
        {
            // Implement Database Create User?
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

        public void ValidateUser( Object obj )
        {
            // Implement Database Validate User?
        }

        public CommandRelay<object> ValidateUserCommand
        {
            get;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
