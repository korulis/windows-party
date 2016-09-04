﻿using System;
using System.IO;
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
            _terminalApp.GetLoginView().Login().Logout();

            Assert.Pass();
        }

    }
}