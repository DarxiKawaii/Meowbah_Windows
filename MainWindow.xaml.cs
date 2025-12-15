using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.System;
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
        // Simple in-memory cart: map variant id -> (title, price, qty)
        private readonly Dictionary<string, (string Title, string Price, int Qty)> _cart = new Dictionary<string, (string, string, int)>();

        public int CartCount => _cart.Values.Sum(i => i.Qty);

        public MainWindow()
        {
            InitializeComponent();
            // Extend content into the system title bar so we can blend the title area with Mica
            this.ExtendsContentIntoTitleBar = true;
            this.SetTitleBar(AppTitleBar);
            // Defer initial selection/navigation until the window is activated so ContentFrame
            // (now located outside the NavigationView in XAML) is available.
            this.Activated += MainWindow_Activated;
        }

        private void MainWindow_Activated(object? sender, WindowActivatedEventArgs e)
        {
            // Ensure the default nav item is selected and navigate to its page.
            ShellNavView.SelectedItem = NavVideos;
            if (NavVideos.Tag is string tag)
            {
                NavigateTo(tag);
                UpdateCartVisibility(tag);
            }
            else
            {
                NavigateTo("Videos");
                UpdateCartVisibility("Videos");
            }

            // Unsubscribe to avoid repeated calls if the window is re-used.
            this.Activated -= MainWindow_Activated;
        }

        private void UpdateCartVisibility(string? tag)
        {
            CartButton.Visibility = tag == "Merch" ? Visibility.Visible : Visibility.Collapsed;
        }

        private void ShellNavView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItemContainer is Microsoft.UI.Xaml.Controls.NavigationViewItem item && item.Tag is string tag)
            {
                NavigateTo(tag);
                UpdateCartVisibility(tag);
            }
        }

        private void UpdateCartBadge()
        {
            CartCountText.Text = CartCount.ToString();
        }

        private async void CartButton_Click(object sender, RoutedEventArgs e)
        {
            // Open a simple cart dialog
            var dlg = new ContentDialog();
            dlg.Title = "Cart";

            var panel = new StackPanel { Orientation = Orientation.Vertical, Spacing = 8 };

            foreach (var kv in _cart)
            {
                var id = kv.Key;
                var entry = kv.Value;

                var row = new StackPanel { Orientation = Orientation.Horizontal, Spacing = 8 };
                row.Children.Add(new TextBlock { Text = entry.Title, Width = 240 });
                row.Children.Add(new TextBlock { Text = entry.Price, Width = 80 });

                var minus = new Button { Content = "-", Tag = id, Width = 32 };
                minus.Click += (s, _) => { ChangeQty(id, -1); dlg.Hide(); CartButton_Click(null, null); };
                row.Children.Add(minus);

                row.Children.Add(new TextBlock { Text = entry.Qty.ToString(), Width = 28, TextAlignment = TextAlignment.Center });

                var plus = new Button { Content = "+", Tag = id, Width = 32 };
                plus.Click += (s, _) => { ChangeQty(id, +1); dlg.Hide(); CartButton_Click(null, null); };
                row.Children.Add(plus);

                var bin = new Button { Content = "🗑", Tag = id, Width = 40 };
                bin.Click += (s, _) => { RemoveFromCart(id); dlg.Hide(); CartButton_Click(null, null); };
                row.Children.Add(bin);

                panel.Children.Add(row);
            }

            if (_cart.Count == 0)
            {
                panel.Children.Add(new TextBlock { Text = "Cart is empty" });
            }

            // Checkout button builds shop-specific checkout URL and opens it in the user's default browser
            var checkout = new Button { Content = "Checkout", HorizontalAlignment = HorizontalAlignment.Right, Margin = new Thickness(0, 8, 0, 0) };
            checkout.Click += async (s, _) =>
            {
                if (_cart.Count == 0)
                    return;

                // Build products param: id:qty,id2:qty2
                var productsParam = string.Join(",", _cart.Select(kv => $"{kv.Key}:{kv.Value.Qty}"));
                var escaped = Uri.EscapeDataString(productsParam);

                // Use the known shop domain
                var shopDomain = "meowbah-shop.fourthwall.com";
                var url = $"https://{shopDomain}/cart/checkout?products={escaped}&currency=USD";

                dlg.Hide();
                await Launcher.LaunchUriAsync(new Uri(url));
            };
            panel.Children.Add(checkout);

            dlg.Content = new ScrollViewer { Content = panel, Height = 300 };
            dlg.CloseButtonText = "Close";
            dlg.XamlRoot = this.Content.XamlRoot;
            _ = dlg.ShowAsync();
        }

        private void ChangeQty(string id, int delta)
        {
            if (!_cart.TryGetValue(id, out var entry)) return;
            var newQty = entry.Qty + delta;
            if (newQty <= 0)
                _cart.Remove(id);
            else
                _cart[id] = (entry.Title, entry.Price, newQty);
            UpdateCartBadge();
        }

        public void AddToCart(string id, string title, string price)
        {
            if (_cart.TryGetValue(id, out var entry))
            {
                _cart[id] = (entry.Title, entry.Price, entry.Qty + 1);
            }
            else
            {
                _cart[id] = (title, price, 1);
            }
            UpdateCartBadge();
        }

        private void RemoveFromCart(string id)
        {
            if (_cart.ContainsKey(id)) _cart.Remove(id);
            UpdateCartBadge();
        }

        // Navigation now driven by TopTabView selection

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
                // MeowTalk and Settings pages removed
            }
        }
    }
}
