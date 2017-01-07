using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace HamiltonSoundboard
{
    public partial class ClipListCell: UITableViewCell
    {
        UILabel clipLabel;
        UILabel songLabel;
        UILabel timeLabel;
        UIImageView clipStateImageView;

        public ClipListCell(NSString cellId) : base (UITableViewCellStyle.Default, cellId)
        {
            clipStateImageView = new UIImageView();

            clipLabel = new UILabel();

            songLabel = new UILabel()
            {
                Font = UIFont.ItalicSystemFontOfSize(UIFont.SmallSystemFontSize)
            };

            timeLabel = new UILabel();
            ContentView.Add(clipStateImageView);
            ContentView.Add(clipLabel);
            ContentView.Add(songLabel);
            ContentView.Add(timeLabel);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            clipStateImageView.Frame = new RectangleF(10, 5, 33, 33);
            clipLabel.Frame = new RectangleF(50, 5, 100, 33);
            songLabel.Frame = new RectangleF((float)ContentView.Bounds.Width - 150, 5, 100, 33);
            timeLabel.Frame = new RectangleF((float)ContentView.Bounds.Width - 50, 5, 50, 33);
        }

        public void UpdateCell(string clipName, string songName, string timeLength, UIImage image)
        {
            clipStateImageView.Image = image;
            clipLabel.Text = clipName;
            songLabel.Text = songName;
            timeLabel.Text = timeLength;
        }
    }
}
