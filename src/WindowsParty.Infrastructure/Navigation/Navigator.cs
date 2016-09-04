using System;
using Prism.Regions;

namespace WindowsParty.Infrastructure.Navigation
{
    public class Navigator : INavigator
    {
        private readonly IRegionManager _regionManager;

        public Navigator(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void GoTo(string serversView)
        {
            _regionManager.RequestNavigate(Regions.MainRegion, new Uri(serversView, UriKind.Relative));
        }
    }
}
