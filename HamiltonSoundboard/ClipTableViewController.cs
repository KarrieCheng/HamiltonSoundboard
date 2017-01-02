using Foundation;
using System;
using UIKit;
using HamiltonSoundboard.Core;

namespace HamiltonSoundboard
{
    public partial class ClipTableViewController: UITableViewController
    {
        ClipsDataService dataService = new ClipsDataService();
        public ClipTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            var clips = dataService.GetAllClips();
            var dataSource = new ClipDataSource(clips, this);

            TableView.Source = dataSource;
        }
    }
}