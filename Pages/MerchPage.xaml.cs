using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace Meowbah
{
    public sealed class MerchItem
    {
        public string ImageSource { get; set; }
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

            // populate 83 different placeholder items
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 1", Description = "Placeholder description for merch item #1.", Price = "$9.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 2", Description = "Placeholder description for merch item #2.", Price = "$12.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 3", Description = "Placeholder description for merch item #3.", Price = "$14.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 4", Description = "Placeholder description for merch item #4.", Price = "$19.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 5", Description = "Placeholder description for merch item #5.", Price = "$24.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 6", Description = "Placeholder description for merch item #6.", Price = "$29.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 7", Description = "Placeholder description for merch item #7.", Price = "$9.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 8", Description = "Placeholder description for merch item #8.", Price = "$11.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 9", Description = "Placeholder description for merch item #9.", Price = "$13.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 10", Description = "Placeholder description for merch item #10.", Price = "$15.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 11", Description = "Placeholder description for merch item #11.", Price = "$17.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 12", Description = "Placeholder description for merch item #12.", Price = "$19.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 13", Description = "Placeholder description for merch item #13.", Price = "$21.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 14", Description = "Placeholder description for merch item #14.", Price = "$23.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 15", Description = "Placeholder description for merch item #15.", Price = "$25.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 16", Description = "Placeholder description for merch item #16.", Price = "$27.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 17", Description = "Placeholder description for merch item #17.", Price = "$8.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 18", Description = "Placeholder description for merch item #18.", Price = "$10.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 19", Description = "Placeholder description for merch item #19.", Price = "$12.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 20", Description = "Placeholder description for merch item #20.", Price = "$14.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 21", Description = "Placeholder description for merch item #21.", Price = "$16.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 22", Description = "Placeholder description for merch item #22.", Price = "$18.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 23", Description = "Placeholder description for merch item #23.", Price = "$20.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 24", Description = "Placeholder description for merch item #24.", Price = "$22.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 25", Description = "Placeholder description for merch item #25.", Price = "$24.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 26", Description = "Placeholder description for merch item #26.", Price = "$26.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 27", Description = "Placeholder description for merch item #27.", Price = "$28.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 28", Description = "Placeholder description for merch item #28.", Price = "$30.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 29", Description = "Placeholder description for merch item #29.", Price = "$5.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 30", Description = "Placeholder description for merch item #30.", Price = "$7.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 31", Description = "Placeholder description for merch item #31.", Price = "$9.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 32", Description = "Placeholder description for merch item #32.", Price = "$11.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 33", Description = "Placeholder description for merch item #33.", Price = "$13.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 34", Description = "Placeholder description for merch item #34.", Price = "$15.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 35", Description = "Placeholder description for merch item #35.", Price = "$17.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 36", Description = "Placeholder description for merch item #36.", Price = "$19.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 37", Description = "Placeholder description for merch item #37.", Price = "$21.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 38", Description = "Placeholder description for merch item #38.", Price = "$23.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 39", Description = "Placeholder description for merch item #39.", Price = "$25.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 40", Description = "Placeholder description for merch item #40.", Price = "$27.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 41", Description = "Placeholder description for merch item #41.", Price = "$29.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 42", Description = "Placeholder description for merch item #42.", Price = "$31.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 43", Description = "Placeholder description for merch item #43.", Price = "$33.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 44", Description = "Placeholder description for merch item #44.", Price = "$35.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 45", Description = "Placeholder description for merch item #45.", Price = "$37.49" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 46", Description = "Placeholder description for merch item #46.", Price = "$39.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 47", Description = "Placeholder description for merch item #47.", Price = "$41.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 48", Description = "Placeholder description for merch item #48.", Price = "$43.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 49", Description = "Placeholder description for merch item #49.", Price = "$45.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 50", Description = "Placeholder description for merch item #50.", Price = "$47.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 51", Description = "Placeholder description for merch item #51.", Price = "$49.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 52", Description = "Placeholder description for merch item #52.", Price = "$51.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 53", Description = "Placeholder description for merch item #53.", Price = "$53.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 54", Description = "Placeholder description for merch item #54.", Price = "$55.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 55", Description = "Placeholder description for merch item #55.", Price = "$57.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 56", Description = "Placeholder description for merch item #56.", Price = "$59.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 57", Description = "Placeholder description for merch item #57.", Price = "$61.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 58", Description = "Placeholder description for merch item #58.", Price = "$63.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 59", Description = "Placeholder description for merch item #59.", Price = "$65.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 60", Description = "Placeholder description for merch item #60.", Price = "$67.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 61", Description = "Placeholder description for merch item #61.", Price = "$69.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 62", Description = "Placeholder description for merch item #62.", Price = "$71.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 63", Description = "Placeholder description for merch item #63.", Price = "$73.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 64", Description = "Placeholder description for merch item #64.", Price = "$75.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 65", Description = "Placeholder description for merch item #65.", Price = "$77.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 66", Description = "Placeholder description for merch item #66.", Price = "$79.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 67", Description = "Placeholder description for merch item #67.", Price = "$81.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 68", Description = "Placeholder description for merch item #68.", Price = "$83.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 69", Description = "Placeholder description for merch item #69.", Price = "$85.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 70", Description = "Placeholder description for merch item #70.", Price = "$87.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 71", Description = "Placeholder description for merch item #71.", Price = "$89.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 72", Description = "Placeholder description for merch item #72.", Price = "$91.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 73", Description = "Placeholder description for merch item #73.", Price = "$93.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 74", Description = "Placeholder description for merch item #74.", Price = "$95.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 75", Description = "Placeholder description for merch item #75.", Price = "$97.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 76", Description = "Placeholder description for merch item #76.", Price = "$99.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 77", Description = "Placeholder description for merch item #77.", Price = "$101.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 78", Description = "Placeholder description for merch item #78.", Price = "$103.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 79", Description = "Placeholder description for merch item #79.", Price = "$105.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 80", Description = "Placeholder description for merch item #80.", Price = "$107.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 81", Description = "Placeholder description for merch item #81.", Price = "$109.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 82", Description = "Placeholder description for merch item #82.", Price = "$111.99" });
            MerchItems.Add(new MerchItem { ImageSource = "/Assets/placeholder.png", Title = "Merch Item 83", Description = "Placeholder description for merch item #83.", Price = "$113.99" });
        }
    }
}
