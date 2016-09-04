using System;
using Prism.Regions;

namespace WindowsParty.Infrastructure.Navigation
{
    public class Navigator : INavigator
    {
        private readonly IRegionManager _regionManager;
        private readonly ITitleResolver _titleResolver;

        public Navigator(IRegionManager regionManager, ITitleResolver titleResolver)
        {
            _regionManager = regionManager;
            _titleResolver = titleResolver;
        }

        public void GoTo(string serversView)
        {
            _regionManager.RequestNavigate(Regions.MainRegion, new Uri(serversView, UriKind.Relative));
            _titleResolver.ChangeTitle(serversView);
        }
    }
}
