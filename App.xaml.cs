using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Meowbah
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        private Window? _window;
        public static MainWindow? MainWindowInstance { get; private set; }

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            // Subscribe to UnhandledException early so we can log and handle exceptions ourselves
            UnhandledException += App_UnhandledException;

            InitializeComponent();
        }

        private void App_UnhandledException(object? sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
        {
            // Log the exception details so you can inspect them in the Output window
            System.Diagnostics.Debug.WriteLine($"Unhandled exception: {e.Exception}");
            System.Diagnostics.Debug.WriteLine(e.Exception?.StackTrace);

            // Mark the exception handled to prevent the app from crashing immediately.
            // Remove or change this in production to allow crash reporting.
            e.Handled = true;
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            _window = new MainWindow();
            MainWindowInstance = _window as MainWindow;
            _window.Activate();
        }
    }
}
