// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Xam.iOS.ScreenRotation
{
    [Register ("ViewController")]
    partial class StartViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnOpen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView StartView { get; set; }

        [Action ("BtnOpen_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnOpen_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnOpen != null) {
                btnOpen.Dispose ();
                btnOpen = null;
            }

            if (StartView != null) {
                StartView.Dispose ();
                StartView = null;
            }
        }
    }
}