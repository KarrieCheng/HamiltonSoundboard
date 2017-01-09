using System;
using UIKit;
using System.Collections.Generic;
using HamiltonSoundboard.Core;
using Foundation;
using AVAudioPlayerSounds;

namespace HamiltonSoundboard
{
    public class ClipDataSource : UITableViewSource
    {
        private List<Clip> clips;
        NSString cellIdentifier = new NSString("ClipCell");
        String time = "00:00";

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
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;

            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);

            var clip = clips[indexPath.Row];

            cell.TextLabel.Text = clip.Quote;
            cell.DetailTextLabel.Text = clip.Song;

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
    }
}
