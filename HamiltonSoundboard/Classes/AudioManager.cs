using System;
using AVFoundation;
using AudioToolbox;
using Foundation;
using UIKit;

namespace AudioToolbox
{
    public class AudioManager
    {
        private AVAudioPlayer soundEffect;

        #region Constructors
        public AudioManager()
        {
            // Initialize
            ActivateAudioSession();
        }
        #endregion

        #region Public Methods
        public void ActivateAudioSession()
        {
            // Initialize Audio
            var session = AVAudioSession.SharedInstance();
            session.SetCategory(AVAudioSessionCategory.Ambient);
            session.SetActive(true);
        }

        public void DeactivateAudioSession()
        {
            var session = AVAudioSession.SharedInstance();
            session.SetActive(false);
        }

        public void ReactivateAudioSession()
        {
            var session = AVAudioSession.SharedInstance();
            session.SetActive(true);
        }

        public void PlaySound(string filename)
        {
            NSUrl songURL;
            string pathUrl = "Sounds/" + filename;
            var fileUrl = new NSUrl(NSBundle.MainBundle.PathForResource(pathUrl.ToString(), "m4a"), false);

            songURL = fileUrl;
            NSError err;

            soundEffect = new AVAudioPlayer(songURL, "mp3", out err);

            soundEffect.FinishedPlaying += delegate
            {
                soundEffect = null;
            };
            soundEffect.NumberOfLoops = 0;
            soundEffect.Play();
        }
        #endregion
    }
}