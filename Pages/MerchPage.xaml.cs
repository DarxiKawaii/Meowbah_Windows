using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml;
using System;
using System.Net;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Meowbah
{
    public sealed class MerchItem
    {
        // Use a BitmapImage with a decode pixel size to avoid loading huge images into memory
        public BitmapImage? ImageSource { get; set; }
        public string Id { get; set; }
        // PrimaryVariantId is the variant GUID Fourthwall expects for cart operations
        public string PrimaryVariantId { get; set; }
        public bool IsSoldOut { get; set; }
        public Visibility SoldOutVisibility => IsSoldOut ? Visibility.Visible : Visibility.Collapsed;
        public bool CanAddToCart => !IsSoldOut;
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }


    public sealed partial class MerchPage : Page
    {
        public ObservableCollection<MerchItem> MerchItems { get; } = new ObservableCollection<MerchItem>();

        public MerchPage()
        {
            this.InitializeComponent();

            // Clear loaded images when the page is unloaded to release memory
            this.Unloaded += (s, e) =>
            {
                MerchItems.Clear();
                GC.Collect();
            };

            _ = LoadMerchAsync();
        }

        private void AddToCartButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
                if (sender is Button b && b.DataContext is MerchItem item)
            {
                // Use PrimaryVariantId (variant GUID) for checkout compatibility
                App.MainWindowInstance?.AddToCart(item.PrimaryVariantId ?? item.Id, item.Title, item.Price);
            }
        }

        private async Task LoadMerchAsync()
        {
            string basePath = @"C:\Users\DarxiKawaii\source\repos\DarxiKawaii\Meowbah_Windows\Data";

            string[] files =
            {
                "1.json",
                "2.json",
                "3.json",
                "4.json"
            };

            MerchItems.Clear();

            foreach (var file in files)
            {
                string path = Path.Combine(basePath, file);

                if (!File.Exists(path))
                    continue;

                string json = await File.ReadAllTextAsync(path);

                var root = JsonSerializer.Deserialize<FourthwallRoot>(json);

                if (root?.products == null)
                    continue;

                foreach (var p in root.products)
                {
                    // Skip null or invalid product entries (some source files contain empty objects)
                    if (p == null)
                        continue;
                    if (string.IsNullOrWhiteSpace(p.id) || string.IsNullOrWhiteSpace(p.title) || string.IsNullOrWhiteSpace(p.price))
                        continue;
                    BitmapImage? bmp = null;
                    try
                    {
                        if (!string.IsNullOrEmpty(p.image))
                        {
                            bmp = new BitmapImage();
                            // Keep decode width modest; item image displays at 150x150
                            bmp.DecodePixelWidth = 400;
                            bmp.UriSource = new Uri(p.image);
                        }
                    }
                    catch
                    {
                        // If creating the BitmapImage fails, leave it null (image will be blank)
                        bmp = null;
                    }

                    MerchItems.Add(new MerchItem
                    {
                        Id = p.id,
                        PrimaryVariantId = (p.variants != null && p.variants.Count > 0) ? p.variants[0].id : p.id,
                        Title = WebUtility.HtmlDecode(p.title ?? string.Empty),
                        ImageSource = bmp,
                        IsSoldOut = p.available == false,
                        Description = string.Empty,
                        Price = $"{p.price} USD"
                    });
                }
            }
        }
    }

    public class FourthwallRoot
    {
        public List<ProductJson> products { get; set; }
    }

    public class ProductJson
    {
        public string id { get; set; }
        public List<ProductVariant> variants { get; set; }
        public bool? available { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string price { get; set; }
    }

    public class ProductVariant
    {
        public string id { get; set; }
    }
}