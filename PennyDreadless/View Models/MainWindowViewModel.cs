using PennyDreadless.Views;
using System.ComponentModel;
using System.Windows;
using Walkways.MVVM.View_Model;

namespace PennyDreadless.View_Models
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Private Variables

        private FrameworkElement _CurrentView;
        private INPCInvoke       _INPCInvoke;

        #endregion

        public MainWindowViewModel( )
        {
            _INPCInvoke = new INPCInvoke( this );
            CurrentView = new LoginPageView( );
        }

        public FrameworkElement CurrentView
        {
            get
            {
                return _CurrentView;
            }

            set
            {
                _INPCInvoke.AssignPropertyValue<FrameworkElement>( ref PropertyChanged, ref _CurrentView, value );
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
