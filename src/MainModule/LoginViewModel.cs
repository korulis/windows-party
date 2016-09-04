using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WindowsParty.Infrastructure;
using WindowsParty.Infrastructure.Navigation;
using Prism.Commands;

namespace MainModule
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly INavigator _navigator;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand LoginCommand { get; }

        public LoginViewModel(INavigator navigator)
        {
            _navigator = navigator;
            LoginCommand = new DelegateCommand(OnLogin);
        }

        private void OnLogin()
        {
            _navigator.GoTo(AppViews.ServersView);
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
