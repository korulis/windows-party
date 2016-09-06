using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WindowsParty.Infrastructure;
using WindowsParty.Infrastructure.Communication;
using WindowsParty.Infrastructure.Navigation;
using Prism.Commands;

namespace MainModule
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly INavigator _navigator;
        private readonly IAuthenticator _authenticator;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand LoginCommand { get; }
        public string User { get; set; }
        public string Pass { get; set; }


        public LoginViewModel(INavigator navigator, IAuthenticator authenticator)
        {
            _navigator = navigator;
            _authenticator = authenticator;
            LoginCommand = new DelegateCommand(OnLogin);
        }

        private void OnLogin()
        {
            var token = _authenticator.Authenticate(User, Pass);
            if (token != string.Empty)
            {
                _navigator.GoTo(AppViews.ServersView);
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
