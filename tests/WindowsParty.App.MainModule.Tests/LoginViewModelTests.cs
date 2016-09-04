using WindowsParty.Infrastructure;
using WindowsParty.Infrastructure.Navigation;
using MainModule;
using Moq;
using NUnit.Framework;

namespace WindowsParty.App.MainModule.Tests
{
    [TestFixture]
    public class LoginViewModelTests
    {
        private Mock<INavigator> _navigatorMock;
        private LoginViewModel _sut;

        [SetUp]
        public void Init()
        {
            _navigatorMock = new Mock<INavigator>();
            _sut = new LoginViewModel(_navigatorMock.Object);
        }

        [Test]
        public void LoginCommand_NavigatesToServersView()
        {
            _sut.LoginCommand.Execute(new {});

            _navigatorMock.Verify(t=>t.GoTo(AppViews.ServersView));
        }
    }
}
