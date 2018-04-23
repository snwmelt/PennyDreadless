using PennyDreadless.Models.Core.Enums;
using PennyDreadless.Views.Interfaces;
using System;
using System.Windows;
using System.Windows.Navigation;

namespace PennyDreadless.Core
{
    internal static class NavigationHandler
    {
        #region Private Variables

        private static NavigationService _NavigationService = null;

        #endregion

        public static void AttatchNavigationService ( NavigationService NavigationService )
        {
            _NavigationService = NavigationService;
        }

        public static NavigationService NavigationService
        {
            get
            {
                if ( NavigationServiceAttached )
                {
                    AttatchNavigationService( ( ( INavigationServiceProvider )App.Current.MainWindow )?.NavigationService );
                }

                return _NavigationService;
            }

            private set
            {
                _NavigationService = NavigationService;
            }
        }

        public static bool NavigationServiceAttached
        {
            get
            {
                return ( _NavigationService is null );
            }
        }

        public static void NavigateTo ( UIContent UIContent )
        {
            switch ( UIContent )
            {
                case UIContent.AccountsPage:
                    NavigationService.Navigate( new Uri( "pack://application:,,,/Views/AccountsPageView.xaml" ) );
                    break;

                case UIContent.LoginPage:
                    NavigationService.Navigate( new Uri( "pack://application:,,,/Views/LoginPageView.xaml" ) );
                    break;

                default:
                    break;
            }
        }

        public static void NavigateTo ( FrameworkElement FrameWorkElement )
        {
            NavigationService.Navigate( FrameWorkElement );
        }
    }
}
