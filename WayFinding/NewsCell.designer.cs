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

namespace WayFinding
{
    [Register ("NewsCell")]
    partial class NewsCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel infor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NewsName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (infor != null) {
                infor.Dispose ();
                infor = null;
            }

            if (NewsName != null) {
                NewsName.Dispose ();
                NewsName = null;
            }
        }
    }
}