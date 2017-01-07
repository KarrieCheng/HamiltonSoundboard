using Foundation;
using UIKit;
using AudioToolbox;

namespace AVAudioPlayerSounds
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        #region Computed Properties
        public override UIWindow Window { get; set; }
        public AudioManager AudioManager { get; set; } = new AudioManager();
        #endregion

        #region Override Methods
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {

        }

        public override void DidEnterBackground(UIApplication application)
        {
            AudioManager.DeactivateAudioSession();
        }

        public override void WillEnterForeground(UIApplication application)
        {
            AudioManager.ReactivateAudioSession();
        }

        public override void OnActivated(UIApplication application)
        {

        }

        public override void WillTerminate(UIApplication application)
        {
            AudioManager.DeactivateAudioSession();
        }
        #endregion
    }
}