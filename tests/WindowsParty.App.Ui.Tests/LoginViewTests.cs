using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using TestStack.White;

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
            Assert.Fail();

        }

    }
}
