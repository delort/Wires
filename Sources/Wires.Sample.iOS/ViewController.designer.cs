// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Wires.Sample.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIActivityIndicatorView activityIndicator { get; set; }


        [Outlet]
        UIKit.UIButton button { get; set; }


        [Outlet]
        UIKit.UIDatePicker datePicker { get; set; }


        [Outlet]
        UIKit.UITextField field { get; set; }


        [Outlet]
        UIKit.UIImageView image { get; set; }


        [Outlet]
        UIKit.UILabel label { get; set; }


        [Outlet]
        UIKit.UIProgressView progressView { get; set; }


        [Outlet]
        UIKit.UISegmentedControl segmented { get; set; }


        [Outlet]
        UIKit.UISlider slider { get; set; }


        [Outlet]
        UIKit.UITextView textView { get; set; }


        [Outlet]
        UIKit.UISwitch toggleSwitch { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (activityIndicator != null) {
                activityIndicator.Dispose ();
                activityIndicator = null;
            }

            if (button != null) {
                button.Dispose ();
                button = null;
            }

            if (datePicker != null) {
                datePicker.Dispose ();
                datePicker = null;
            }

            if (field != null) {
                field.Dispose ();
                field = null;
            }

            if (image != null) {
                image.Dispose ();
                image = null;
            }

            if (label != null) {
                label.Dispose ();
                label = null;
            }

            if (progressView != null) {
                progressView.Dispose ();
                progressView = null;
            }

            if (segmented != null) {
                segmented.Dispose ();
                segmented = null;
            }

            if (slider != null) {
                slider.Dispose ();
                slider = null;
            }

            if (textView != null) {
                textView.Dispose ();
                textView = null;
            }

            if (toggleSwitch != null) {
                toggleSwitch.Dispose ();
                toggleSwitch = null;
            }
        }
    }
}