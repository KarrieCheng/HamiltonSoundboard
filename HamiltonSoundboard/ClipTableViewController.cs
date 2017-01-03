using Foundation;
using System;
using UIKit;
using HamiltonSoundboard.Core;

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
            var clips = dataService.GetAllClips();
            var dataSource = new ClipDataSource(clips, this);

            TableView.Source = dataSource;

			this.NavigationItem.Title = "Hamilton Menu";
        }


		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier == "ClipDetailSegue")
			{
				var clipDetailViewController = segue.DestinationViewController as ClipDetailViewController;
				if (clipDetailViewController != null)
				{
					var source = TableView.Source as ClipDataSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var item = source.GetItem(rowPath.Row);
					clipDetailViewController.SelectedClip = item;
				}
			}
		} 
    }
}