# Xam.iOS.ScreenRotation

I had a project where the requirement was that all but one page was supposed to be portrait mode and had to find a solution for this. Later this requirement changed to that rotation should be allowed on iPads but still the same on iPhone.

To support this I added a public bool in the appdelegate

```C#
        public static bool disableAllOrientation = true;
  ```
  
  
And override the GetSupportedInterfaceOrientation

```C#
        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, UIWindow forWindow)
        {
            if (UIDevice.CurrentDevice.UserInterfaceIdiom != UIUserInterfaceIdiom.Pad)
            {
                if (disableAllOrientation == true)
                {
                    return UIInterfaceOrientationMask.Portrait;
                }
            }
            return UIInterfaceOrientationMask.AllButUpsideDown;
        }
  ```
  
  Then how to use this is on whatever page you need to allow rotation on you override the ViewWillAppear and ViewWillDisappear, please note that the first if checks if the user is on an iPad and will thus not restrict any orientation.
  
  ```C#
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
```
