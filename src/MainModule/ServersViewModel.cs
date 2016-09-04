using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WindowsParty.Infrastructure;
using WindowsParty.Infrastructure.Domain;
using WindowsParty.Infrastructure.Navigation;
using Prism.Commands;
using Prism.Regions;

namespace MainModule
{
    public class ServersViewModel : INotifyPropertyChanged, INavigationAware
    {
        private readonly INavigator _navigator;
        private IEnumerable<ServerDto> _servers;
        public ICommand LogoutCommand { get; }

        public IEnumerable<ServerDto> Servers   
        {
            get { return _servers; }
            set
            {
                _servers = value; 
                OnPropertyChanged();
            }
        }

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
            Servers = new List<ServerDto>
            {
                new ServerDto {Server = "Alzyras",Distance = "Toli" },
                new ServerDto {Server = "Vilnius",Distance = "1" },
            };
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
