﻿using System.Windows;

namespace WindowsParty.App
{
    public partial class App : Application
    {
        private Bootstrapper _bootstrapper;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _bootstrapper = new Bootstrapper();
            _bootstrapper.Run();
        }
    }
}