using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WindowsParty.Infrastructure;
using WindowsParty.Infrastructure.Navigation;
using Prism.Commands;
using Prism.Regions;

namespace MainModule
{
    public class ServersViewModel : INotifyPropertyChanged
    {
        private readonly INavigator _navigator;
        public ICommand LogoutCommand { get; }

        public ServersViewModel(INavigator navigator)
        {
            _navigator = navigator;
            LogoutCommand = new DelegateCommand(OnLogout);
        }

        private void OnLogout()
        {
            _navigator.GoTo(AppViews.InitialView);
        }


        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new System.NotImplementedException();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new System.NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
