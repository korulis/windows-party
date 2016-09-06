using System.Net;
using WindowsParty.Infrastructure;
using WindowsParty.Infrastructure.Communication;
using WindowsParty.Infrastructure.Navigation;
using MainModule;
using Moq;
using NUnit.Framework;
using Ploeh.AutoFixture.NUnit3;

namespace WindowsParty.App.MainModule.Tests
{
    [TestFixture]
    public class LoginViewModelTests
    {
        private Mock<INavigator> _navigatorMock;
        private LoginViewModel _sut;
        private Mock<IAuthenticator> _authenticatorMock;

        [SetUp]
        public void Init()
        {
            _authenticatorMock = new Mock<IAuthenticator>();
            _navigatorMock = new Mock<INavigator>();
            _sut = new LoginViewModel(_navigatorMock.Object, _authenticatorMock.Object);
        }

        [Test,AutoData]
        public void LoginCommand_NavigatesToServersView_IfAuthenticationSuccessfull(string token)
        {
            _authenticatorMock.Setup(t => t.Authenticate(It.IsAny<string>(), It.IsAny<string>())).Returns(token);

            _sut.LoginCommand.Execute(new {});

            _navigatorMock.Verify(t=>t.GoTo(AppViews.ServersView), Times.Once);
        }

        [Test]
        public void LoginCommand_DoesNotNavigateToServersView_IfAuthenticationUnsuccessfull()
        {
            _authenticatorMock.Setup(t => t.Authenticate(It.IsAny<string>(), It.IsAny<string>())).Returns(string.Empty);

            _sut.LoginCommand.Execute(new { });

            _navigatorMock.Verify(t => t.GoTo(AppViews.ServersView), Times.Never);
        }

        [Test]
        public void LoginCommand_Authenticates()
        {
            _sut.LoginCommand.Execute(new {});

            _authenticatorMock.Verify(t=>t.Authenticate(_sut.User, _sut.Pass), Times.Once);
        }
    }
}
