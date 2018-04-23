using System.ComponentModel;
using System.Windows;
using Walkways.MVVM.View_Model;

namespace PennyDreadless.View_Models
{
    internal class AccountsPageViewModel : INotifyPropertyChanged
    {
        #region Private Variables

        private Visibility _AccountDataColumnIsVisible;
        private INPCInvoker _INPCInvoke;

        #endregion

        public AccountsPageViewModel( )
        {
            _INPCInvoke = new INPCInvoker( this );

            AccountDataColumnIsVisible = Visibility.Collapsed;
        }

        public Visibility AccountDataColumnIsVisible
        {
            get
            {
                return _AccountDataColumnIsVisible;
            }

            set
            {
                _INPCInvoke.AssignPropertyValue<Visibility>( ref PropertyChanged, ref _AccountDataColumnIsVisible, value );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
