using Foundation;
using System;
using UIKit;
using HamiltonSoundboard.Core;

namespace HamiltonSoundboard
{
    public partial class ClipDetailViewController : UIViewController
    {
        
        public Clip SelectedClip { get; set; }
        public ClipDetailViewController (IntPtr handle) : base (handle)
        {
            ClipsDataService clipDataService = new ClipsDataService();
            SelectedClip = clipDataService.GetClipById(1);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            DatabindUI();

            PlayButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                //TODO: Add functionality
            };

            ReplayButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                //TODO: Add functionality
            };

            CancelButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                //TODO: Add functionality
            };
        }

        private void DatabindUI()
        {
            SongLabel.Text = SelectedClip.Song;
            LyricsText.Text = SelectedClip.Quote;
        }
    }
}