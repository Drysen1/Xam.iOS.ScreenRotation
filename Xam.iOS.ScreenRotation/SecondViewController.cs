using Foundation;
using System;
using UIKit;

namespace Xam.iOS.ScreenRotation
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            AppDelegate.disableAllOrientation = false;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            AppDelegate.disableAllOrientation = true;
        }

        partial void BtnGoBack_TouchUpInside(UIButton sender)
        {
            this.NavigationController.PopViewController(true);
        }
    }
}