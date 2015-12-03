using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using DeviceOrientation.Forms.Plugin.Droid;
using Xamarin;
using Xamarin.Forms;
using Application = Android.App.Application;
namespace MainLibrary.Droid
{
    [Activity(Label = "MainLibrary", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {

        //TODO: The commented out code is related to the orientation stuff
        //public override void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig)
        //{
        //    base.OnConfigurationChanged(newConfig);
        //    DeviceOrientationImplementation.NotifyOrientationChange(newConfig);
        //}
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Insights.HasPendingCrashReport += (sender, isStartupCrash)
                =>
            {
                if (isStartupCrash)
                    Insights.PurgePendingCrashReports().Wait();
            };
            Insights.Initialize("c3073d3e8d28a2b889bdd692f98ece61abfb3090", Application.Context);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            #region Old Code Related to Device Orientation
            //DeviceOrientationImplementation.Init();
            // Locks the device into portrait mode
            //if (Device.Idiom == TargetIdiom.Phone)
            //{
            //    this.RequestedOrientation = ScreenOrientation.SensorPortrait;
            //}
            #endregion

            LoadApplication(new App());
        }
    }
}

