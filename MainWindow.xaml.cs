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
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Meowbah
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Initial navigation after components are initialized
            ShellNavView.SelectedItem = NavVideos;
            NavigateTo("Videos");
        }

        private void ShellNavView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                NavigateTo("Settings");
                return;
            }

            if (args.SelectedItemContainer is Microsoft.UI.Xaml.Controls.NavigationViewItem item && item.Tag is string tag)
            {
                NavigateTo(tag);
            }
        }

        private void ShellNavView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            if (ContentFrame.CanGoBack)
            {
                ContentFrame.GoBack();
            }
        }

        private void NavigateTo(string tag)
        {
            switch (tag)
            {
                case "Videos":
                    if (ContentFrame.CurrentSourcePageType != typeof(VideosPage))
                        ContentFrame.Navigate(typeof(VideosPage));
                    break;
                case "Art":
                    if (ContentFrame.CurrentSourcePageType != typeof(ArtPage))
                        ContentFrame.Navigate(typeof(ArtPage));
                    break;
                case "Merch":
                    if (ContentFrame.CurrentSourcePageType != typeof(MerchPage))
                        ContentFrame.Navigate(typeof(MerchPage));
                    break;
                case "MeowTalk":
                    if (ContentFrame.CurrentSourcePageType != typeof(MeowTalkPage))
                        ContentFrame.Navigate(typeof(MeowTalkPage));
                    break;
                case "Settings":
                    if (ContentFrame.CurrentSourcePageType != typeof(SettingsPage))
                        ContentFrame.Navigate(typeof(SettingsPage));
                    break;
            }
        }
    }
}
