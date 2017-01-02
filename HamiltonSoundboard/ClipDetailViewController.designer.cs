// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HamiltonSoundboard
{
    [Register ("ClipDetailViewController")]
    partial class ClipDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CancelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView LyricsText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PlayButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ReplayButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SongLabel { get; set; }

        [Action ("PlayButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PlayButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ReplayButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ReplayButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CancelButton != null) {
                CancelButton.Dispose ();
                CancelButton = null;
            }

            if (LyricsText != null) {
                LyricsText.Dispose ();
                LyricsText = null;
            }

            if (PlayButton != null) {
                PlayButton.Dispose ();
                PlayButton = null;
            }

            if (ReplayButton != null) {
                ReplayButton.Dispose ();
                ReplayButton = null;
            }

            if (SongLabel != null) {
                SongLabel.Dispose ();
                SongLabel = null;
            }
        }
    }
}