using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MainLibrary;
using MainLibrary.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyCustomTextbox), typeof(MyCustomTextBoxAndroidRenderer))]
namespace MainLibrary.Droid.Renderers
{
    public class MyCustomTextBoxAndroidRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control?.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);

            // Old sample code taken from somewhere, the code above makes the android entries (textboxes) green.
            //if (Control != null)
            //{
            //    Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));
            //    Control.SetBackgroundDrawable(null);
            //}
        }
    }
}