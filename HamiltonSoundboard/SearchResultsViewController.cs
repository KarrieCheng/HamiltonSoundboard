using System;
using System.Linq;
using System.Collections.Generic;
using AVAudioPlayerSounds;
using Foundation;
using HamiltonSoundboard.Core;
using UIKit;

namespace HamiltonSoundboard
{
        public class SearchResultsViewController : UITableViewController
        {
            static readonly string mapItemCellId = "mapItemCellId";
            public List<Clip> clips { get; set; }
            ClipsDataService dataService = new ClipsDataService();
            ClipTableViewController searchDisplayController;


            public SearchResultsViewController(ClipTableViewController searchDisplayController)
            {
                this.searchDisplayController = searchDisplayController;
                clips = new List<Clip>();
            }

            public override nint RowsInSection(UITableView tableView, nint section)
            {
                return clips.Count;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell(mapItemCellId);

                if (cell == null)
                    cell = new UITableViewCell();

                cell.TextLabel.Text = clips[indexPath.Row].Quote;
                return cell;
            }

            public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
            {
                App.AudioManager.PlaySound(clips[indexPath.Row].Filename);

                tableView.DeselectRow(indexPath, true);
            }


            public static AppDelegate App
            {
                get { return (AppDelegate)UIApplication.SharedApplication.Delegate; }
            }

            public void Search(string forSearchString)
            {
                this.clips = PerformSearch(forSearchString);

                var dataSource = new ClipDataSource(clips, this);
                this.NavigationItem.Title = "Hamilton Menu";
                TableView.Source = dataSource;

                this.TableView.ReloadData();
            }      

            List<Clip> PerformSearch(string searchString)
            {
                searchString = searchString.Trim();
                string[] searchItems = string.IsNullOrEmpty(searchString)
                    ? new string[0]
                    : searchString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var filteredProducts = new List<Clip>();
                var clips = dataService.GetAllClips();
            
                foreach (var item in searchItems)
                {
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
