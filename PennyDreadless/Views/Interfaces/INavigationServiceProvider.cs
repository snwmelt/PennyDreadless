using System.Windows.Navigation;

namespace PennyDreadless.Views.Interfaces
{
    internal interface INavigationServiceProvider
    {
        NavigationService NavigationService { get; }
    }
}