using System;
using WindowsParty.Infrastructure;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Utility;

namespace WindowsParty.App.Ui.Tests.Views
{
    public class LoginView : WindowsPartyWindow
    {
        public ServersView Login()
        {
            var loginButtonCriteria = SearchCriteria.ByAutomationId(AutomationIds.LoginButton);
            var loginButton = Retry.For(() => this.Get<Button>(loginButtonCriteria), TimeSpan.FromMilliseconds(500));
            loginButton.Click();
            var serversView = Retry.For(() => App.GetWindow(AppViews.ServersView), TimeSpan.FromMilliseconds(500));

            return serversView as ServersView;
        }

        public LoginView(Application app) : base(app)
        {
        }
    }
}
