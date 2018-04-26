using PennyDreadless.Models.Core.Enums;
using System;
using System.Windows.Navigation;

namespace PennyDreadless.Models.Core.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    internal interface INavigationHandler
    {
        /// <summary>
        /// Naviage User Interface Backwards.
        /// </summary>
        /// <returns></returns>
        Boolean NavigateBackward( );

        /// <summary>
        /// Navigate User Interface Forwards.
        /// </summary>
        /// <returns></returns>
        Boolean NavigateForward( );

        /// <summary>
        /// An Instance of System.Windows.Navigation.NavigationService.
        /// </summary>
        NavigationService NavigationService { get; }

        /// <summary>
        /// Indicate Availablity of System.Windows.Navigation.NavigationService Instance.
        /// </summary>
        Boolean NavigationServiceAvailable { get; }

        /// <summary>
        /// Navigate User Interface to a Page Assosiated with UIContent Enum. 
        /// </summary>
        /// <param name="Object"></param>
        /// <returns></returns>
        Boolean NavigateTo ( UIContent Object );
    }
}