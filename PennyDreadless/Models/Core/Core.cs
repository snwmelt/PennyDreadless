using PennyDreadless.Models.Core.Interfaces;
using PennyDreadless.Views.Interfaces;
using System;

namespace PennyDreadless.Models.Core
{
    /// <summary>
    /// Contains required static references for application function.
    /// </summary>
    internal sealed class Core : IDisposable
    {
        #region Private Variables

        private static readonly Core _Instance = new Core( );
        private IUserDataSerializer      _IUserDataSerializer;
        private IUserAuthenticator       _IUserAuthenticator;
        private Lazy<INavigationHandler> _LazyINavigationHandler;

        #endregion

        private Core( )
        {
            _IUserDataSerializer    = new DataContext( );
            _IUserAuthenticator     = new AuthenticationManager( );
            _LazyINavigationHandler = new Lazy<INavigationHandler>( ( ) => new NavigationHandler( ( ( INavigationServiceProvider )App.Current.MainWindow ).NavigationService ) );
        }

        public void Dispose( )
        {
            throw new NotImplementedException( );
        }

        public static IUserAuthenticator UserAuthenticator
        {
            get
            {
                return _Instance._IUserAuthenticator;
            }
        }

        public static INavigationHandler NavigationHandler
        {
            get
            {
                return _Instance._LazyINavigationHandler.Value;
            }
        }
        
        public static IUserDataSerializer UserDataSerializer
        {
            get
            {
                return _Instance._IUserDataSerializer;
            }
        }
    }
}
