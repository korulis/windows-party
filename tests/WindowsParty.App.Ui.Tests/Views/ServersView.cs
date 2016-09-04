using System;
using WindowsParty.Infrastructure;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Utility;

namespace WindowsParty.App.Ui.Tests.Views
{
    public class ServersView : WindowsPartyWindow
    {
        public ServersView(Application app) : base(app)
        {
        }

        public LoginView Logout()
        {
            var logoutButtonCriteria = SearchCriteria.ByAutomationId(AutomationIds.LoginButton);
            var logoutButton = Retry.For(() => Get<Button>(logoutButtonCriteria), TimeSpan.FromMilliseconds(500));
            logoutButton.Click();
            var loginView = Retry.For(() => App.GetWindow(AppViews.ServersView), TimeSpan.FromMilliseconds(500));

            return loginView as LoginView;
        }
    }
}