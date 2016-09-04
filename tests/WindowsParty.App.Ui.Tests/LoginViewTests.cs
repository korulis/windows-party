using System;
using System.IO;
using WindowsParty.Infrastructure;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace WindowsParty.App.Ui.Tests
{
    [TestFixture]
    public class LoginViewTests
    {
        private Application _terminalApp;

        [SetUp]
        public void Init()
        {
            var testProjectPath = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = Path.GetFullPath(Path.Combine(testProjectPath, "..\\..\\..\\..\\src\\WindowsParty.App\\bin\\Debug\\WindowsParty.App.exe"));
            _terminalApp = Application.Launch(fullPath);
        }

        [TearDown]
        public void Dest()
        {
            _terminalApp.Close();
        }

        [Test]
        public void UserCanLoginAndLogout()
        {
            _terminalApp
                .GetLoginView().Wait(100)
                .Login().Wait(100)
                .Logout().Wait(100);

            Assert.Pass();
        }

        [Test]
        public void UserCanSeeSomeServersOnServerView()
        {
            var serverList = _terminalApp
                .GetLoginView().Wait(100)
                .Login().Wait(100)
                .GetServerList();


            Assert.True(serverList.Rows.Count > 1);
            
        }

    }
}
