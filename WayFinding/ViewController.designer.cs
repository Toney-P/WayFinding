// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WayFinding
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView NewsTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (NewsTableView != null) {
                NewsTableView.Dispose ();
                NewsTableView = null;
            }
        }
    }
}