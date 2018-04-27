using PennyDreadless.Models.Core.Interfaces;
using PennyDreadless.Views.Interfaces;
using System;

namespace PennyDreadless.Models.Core
{
    /// <summary>
    /// Contains required static references for application function.
    /// </summary>
    internal sealed class Core
    {
        #region Private Variables

        private static readonly Core _Instance = new Core( );

        private IDataContext             _IDataContext;
        private IUserAuthenticator       _IUserAuthenticator;
        private Lazy<INavigationHandler> _LazyINavigationHandler;

        #endregion

        private Core( )
        {
            _IDataContext           = new DataContext( );
            _IUserAuthenticator     = new AuthenticationManager( );
            _LazyINavigationHandler = new Lazy<INavigationHandler>( ( ) => new NavigationHandler( ( ( INavigationServiceProvider )App.Current.MainWindow ).NavigationService ) );
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

        public static IDataContext DataContext
        {
            get
            {
                return _Instance._IDataContext;
            }
        }
    }
}
