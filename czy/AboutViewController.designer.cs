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

namespace czy
{
    [Register ("AboutViewController")]
    partial class AboutViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonClose { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonClose != null) {
                buttonClose.Dispose ();
                buttonClose = null;
            }
        }
    }
}