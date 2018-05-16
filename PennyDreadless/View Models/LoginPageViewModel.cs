using PennyDreadless.Models.Core;
using PennyDreadless.Models.Core.Enums;
using PennyDreadless.Models.Core.Extensions;
using System;
using System.ComponentModel;
using Walkways.MVVM.View_Model;

namespace PennyDreadless.View_Models
{
    internal class LoginPageViewModel : INotifyPropertyChanged
    {
        #region Private Variables

        private String      _Mask;
        private Char        _MaskChar;
        private String      _Password;
        private String      _Username;
        private INPCInvoker _INPCInvoke;

        #endregion

        public LoginPageViewModel( )
        {
            CreateUserCommand   = new CommandRelay<Object>( CreateUser, CanCreateUser );
            _INPCInvoke         = new INPCInvoker( this );
            _Mask               = "";
            _MaskChar           = '*';
            ValidateUserCommand = new CommandRelay<Object>( ValidateUser, CanValidateUser );
        }

        private bool CanCreateUser( Object obj )
        {
            return Core.UserAuthenticator.IsAValidPassword( Password ) &&
                   Core.UserAuthenticator.IsAValidUsername( Username ) &&
                   !Core.UserAuthenticator.UserExists( Username );
        }

        private bool CanValidateUser( Object obj )
        {
            return Core.UserAuthenticator.IsAValidPassword( Password ) &&
                   Core.UserAuthenticator.UserExists( Username );
        }
        
        public void CreateUser( Object obj )
        {
            if ( Core.UserAuthenticator.Create( Username, Password ) )
            {
                ValidateUser( obj );
            }
        }

        public CommandRelay<Object> CreateUserCommand
        {
            get;
        }
        
        public String Password
        {
            private get
            {
                return _Mask;
            }

            set
            {
                _Password = value.GetSHA256Hash();

                _INPCInvoke.AssignPropertyValue<String>( ref PropertyChanged, ref _Mask, ( value.Length > _Mask.Length ? _Mask + _MaskChar : _Mask.Substring( 0, value.Length ) ) );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

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
            Core.UserAuthenticator.Authenticate( Username, Password );

            if ( Core.UserAuthenticator.HasAuthenticatedUser )
            {
                Core.NavigationHandler.NavigateTo( UIContent.AccountsPage );
            }
        }

        public CommandRelay<object> ValidateUserCommand
        {
            get;
        }
    }
}
