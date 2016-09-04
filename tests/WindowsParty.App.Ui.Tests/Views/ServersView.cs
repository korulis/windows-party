using System;
using WindowsParty.Infrastructure;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace WindowsParty.App.Ui.Tests.Views
{
    public class ServersView : WindowsPartyWindow
    {

        public LoginView Logout()
        {
            var logoutButtonCriteria = SearchCriteria.ByAutomationId(AutomationIds.LoginButton);
            var logoutButton = Retry.For(() => Window.Get<Button>(logoutButtonCriteria), TimeSpan.FromMilliseconds(500));
            logoutButton.Click();
            var loginWindow = Retry.For(() => App.GetWindow(AppViews.ServersView), TimeSpan.FromMilliseconds(500));

            return new LoginView(App, loginWindow);
        }

        public ServersView(Application app, Window window) : base(app, window)
        {
        }
    }
}