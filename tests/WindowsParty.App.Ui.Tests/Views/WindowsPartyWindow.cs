using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace WindowsParty.App.Ui.Tests.Views
{
    public class WindowsPartyWindow : Window
    {
        public Application App { get; }

        public WindowsPartyWindow(Application app)
        {
            App = app;
        }

        public override Window ModalWindow(string title, InitializeOption option)
        {
            throw new System.NotImplementedException();
        }

        public override Window ModalWindow(SearchCriteria searchCriteria, InitializeOption option)
        {
            throw new System.NotImplementedException();
        }

        public override PopUpMenu Popup { get; }
    }
}