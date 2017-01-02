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

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return clips.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;

            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

            var clip = clips[indexPath.Row];
            cell.TextLabel.Text = clip.Quote;

            return cell;
        }
    }
}
