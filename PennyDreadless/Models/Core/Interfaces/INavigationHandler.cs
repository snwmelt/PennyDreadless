using PennyDreadless.Models.Core.Enums;
using System;
using System.Windows.Navigation;

namespace PennyDreadless.Models.Core.Interfaces
{
    /// <summary>
    /// Provides mechanisms for naviagting the application user interface via a System.Windows.Navigation.NavigationService instance.
    /// </summary>
    internal interface INavigationHandler
    {
        /// <summary>
        /// Naviage user interface Backwards.
        /// </summary>
        /// <returns></returns>
        Boolean NavigateBackward( );

        /// <summary>
        /// Navigate user interface Forwards.
        /// </summary>
        /// <returns></returns>
        Boolean NavigateForward( );

        /// <summary>
        /// An Instance of System.Windows.Navigation.NavigationService.
        /// </summary>
        NavigationService NavigationService { get; }

        /// <summary>
        /// Indicate availablity of the System.Windows.Navigation.NavigationService Instance.
        /// </summary>
        Boolean NavigationServiceAvailable { get; }

        /// <summary>
        /// Navigate user interface to a Page assosiated with the UIContent Enum. 
        /// </summary>
        /// <param name="Object"></param>
        /// <returns></returns>
        Boolean NavigateTo ( UIContent UI );
    }
}