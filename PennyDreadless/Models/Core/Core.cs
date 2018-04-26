using PennyDreadless.Models.Core.Interfaces;
using PennyDreadless.Views.Interfaces;

namespace PennyDreadless.Models.Core
{
    /// <summary>
    /// Contains required static references for application function.
    /// </summary>
    internal sealed class Core
    {
        #region Private Variables

        private static readonly Core _Instance = new Core();

        private INavigationHandler _INavigationHandler;

        #endregion

        private Core( )
        {
            _INavigationHandler = new NavigationHandler( ( ( INavigationServiceProvider )App.Current.MainWindow ).NavigationService );
        }

        public static INavigationHandler NavigationHandler
        {
            get
            {
                return _Instance._INavigationHandler;
            }
        }

    }
}
