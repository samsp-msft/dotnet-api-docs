﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace SplashScreenDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Note to UE authors: The following Main definition is
        // autogenerated into App.g.cs in normal WPF Application
        // projects. The Build Action property for App.xaml has
        // been set to Page to override this behavior and enable
        // compile testing under Parsnip, but this is not a 
        // valid configuration for a real WPF application.
        // <snippet1>
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static void Main()
        {
            // <snippet2>
            SplashScreen splashScreen = new SplashScreen("SplashScreenImage.bmp");
            splashScreen.Show(true);

            // Run the application.
            // </snippet2>

            SplashScreenDemo.App app = new SplashScreenDemo.App();
            app.InitializeComponent();
            app.Run();
        }
        // </snippet1>
    }
}
