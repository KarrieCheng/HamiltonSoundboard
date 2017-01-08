using Foundation;
using System;
using System.Linq;
using UIKit;
using HamiltonSoundboard.Core;
using System.Collections.Generic;

namespace HamiltonSoundboard
{
    public partial class ClipTableViewController : UITableViewController
    {
        ClipsDataService dataService = new ClipsDataService();

        public ClipTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            var clips = new List<Clip>();
            string searchText = ClipSearchBar.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                clips = dataService.GetAllClips();
            }
            else {
                clips = PerformSearch(searchText);
            }
            //TODO: Find where to add search

            var dataSource = new ClipDataSource(clips, this);
            this.NavigationItem.Title = "Hamilton Menu";
            TableView.Source = dataSource;
        }

        List<Clip> PerformSearch(string searchString)
        {
            searchString = searchString.Trim();
            string[] searchItems = string.IsNullOrEmpty(searchString)
                ? new string[0]
                : searchString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filteredProducts = new List<Clip>();

            foreach (var item in searchItems)
            {
                var clips = dataService.GetAllClips();

                IEnumerable<Clip> query =
                    from p in clips
                        where p.Quote.IndexOf(item, StringComparison.OrdinalIgnoreCase) >= 0
                    orderby p.Quote
                    select p;

                filteredProducts.AddRange(query);
            }

            return filteredProducts.Distinct().ToList();
        }

    }
}