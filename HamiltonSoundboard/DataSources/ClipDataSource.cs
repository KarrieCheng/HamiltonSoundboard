using System;
using UIKit;
using System.Collections.Generic;
using HamiltonSoundboard.Core;
using Foundation;

namespace HamiltonSoundboard
{
    public class ClipDataSource : UITableViewSource
    {
        private List<Clip> clips;
        NSString cellIdentifier = new NSString("ClipCell");

        public ClipDataSource(List<Clip> clips, UITableViewController callingController)
        {
            this.clips = clips;
        }

		public Clip GetItem(int row)
		{
			return clips[row];
		}

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return clips.Count;
        }

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            ClipListCell cell = tableView.DequeueReusableCell(cellIdentifier) as ClipListCell;

            if (cell == null)
                cell = new ClipListCell(cellIdentifier);

            cell.UpdateCell(clips[indexPath.Row].Quote,
                            clips[indexPath.Row].Song,
                            "00:10",
                            UIImage.FromFile("Images/hamilton_bg.png"));
            //TODO: 3rd argument should eventually be time :\
            var clip = clips[indexPath.Row];
            //cell.TextLabel.Text = clip.Quote;

            return cell;
        }

}
}
