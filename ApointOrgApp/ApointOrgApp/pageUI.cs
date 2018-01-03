using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CoreGraphics;

namespace ApointOrgApp
{
    class pageUI
    {
        UIButton Button1;

        public void ViewDidLoad ()
        {
            Button1 = UIButton.FromType(UIButtonType.RoundedRect);
            Button1.Frame = new CGRect(10, 80, 90, 40);
            Button1.SetTitle("Test", UIControlState.Normal);

        }
    }
}