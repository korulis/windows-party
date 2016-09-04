﻿using System.Collections.Generic;
using WindowsParty.Infrastructure;
using WindowsParty.Infrastructure.Domain;
using WindowsParty.Infrastructure.Navigation;
using MainModule;
using Moq;
using NUnit.Framework;

namespace WindowsParty.App.MainModule.Tests
{
    [TestFixture]
    public class ServersViewModelTests
    {
        private Mock<INavigator> _navigatorMock;
        private ServersViewModel _sut;

        [SetUp]
        public void Init()
        {
            _navigatorMock = new Mock<INavigator>();
            _sut = new ServersViewModel(_navigatorMock.Object);
        }

        [Test]
        public void LogoutCommand_NavigatesToInitialView()
        {
            _sut.LogoutCommand.Execute(new {});

            _navigatorMock.Verify(t=>t.GoTo(AppViews.InitialView));
        }

        [Test]
        public void Servers_RaisesPropertyChanged()
        {
            var wasRaised = false;
            _sut.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(_sut.Servers))
                {
                    wasRaised = true;
                }
            };

            _sut.Servers = new List<ServerDto>();

            Assert.True(wasRaised);
        }
    }
}