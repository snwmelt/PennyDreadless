using PennyDreadless.Models.Core.Enums;
using PennyDreadless.Models.Core.Interfaces;
using System;
using System.Windows.Navigation;

namespace PennyDreadless.Models.Core
{
    internal class NavigationHandler : INavigationHandler
    {
        public NavigationHandler ( NavigationService NavigationService )
        {
            this.NavigationService = NavigationService;
        }

        public NavigationService NavigationService
        {
            get;
        }

        public bool NavigationServiceAvailable
        {
            get
            {
                return !( NavigationService is null );
            }
        }

        public bool NavigateBackward( )
        {
            if ( NavigationService.CanGoBack )
            {
                NavigationService.GoBack( );

                return true;
            }

            return false;
        }

        public bool NavigateForward( )
        {
            if ( NavigationService.CanGoForward )
            {
                NavigationService.GoForward( );

                return true;
            }

            return false;
        }

        public bool NavigateTo( UIContent UI)
        {
            switch ( UI )
            {
                default:
                    return NavigationService.Navigate( new Uri( "pack://application:,,,/Views/" + UI.ToString( ) + "View.xaml" ) );
            }
        }
    }
}
