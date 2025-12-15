using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace Meowbah
{
    public sealed class ArtItem
    {
        public string ImageSource { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public sealed partial class ArtPage : Page
    {
        public ObservableCollection<ArtItem> ArtItems { get; } = new ObservableCollection<ArtItem>();

        public ArtPage()
        {
            InitializeComponent();

            // populate 14 placeholder art items
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 1", Description = "Placeholder artwork #1." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 2", Description = "Placeholder artwork #2." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 3", Description = "Placeholder artwork #3." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 4", Description = "Placeholder artwork #4." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 5", Description = "Placeholder artwork #5." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 6", Description = "Placeholder artwork #6." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 7", Description = "Placeholder artwork #7." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 8", Description = "Placeholder artwork #8." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 9", Description = "Placeholder artwork #9." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 10", Description = "Placeholder artwork #10." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 11", Description = "Placeholder artwork #11." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 12", Description = "Placeholder artwork #12." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 13", Description = "Placeholder artwork #13." });
            ArtItems.Add(new ArtItem { ImageSource = "/Assets/placeholder.png", Title = "Artwork 14", Description = "Placeholder artwork #14." });
        }
    }
}