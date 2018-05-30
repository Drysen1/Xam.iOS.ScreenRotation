using Foundation;
using System;
using UIKit;

namespace Xam.iOS.ScreenRotation
{
    public partial class StartViewController : UIViewController
    {
		public StartViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        partial void BtnOpen_TouchUpInside(UIButton sender)
        {

            var secondPage = Storyboard.InstantiateViewController("secondview") as SecondViewController;
            this.NavigationController.PushViewController(secondPage, true);
        }
    }
}