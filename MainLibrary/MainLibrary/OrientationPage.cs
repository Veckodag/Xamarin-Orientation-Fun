using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceOrientation.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace MainLibrary
{
    public class OrientationPage : BaseOrientationPage
    {
        private Label myLabel;

        public OrientationPage()
        {
            myLabel = new Label();
            myLabel.VerticalOptions = LayoutOptions.Center;
            myLabel.HorizontalOptions = LayoutOptions.Center;
            Content = myLabel;

            var svc = DependencyService.Get<IDeviceOrientation>();
            if (svc != null)
            {
                var orientation = svc.GetOrientation();
                HandleOrientationMessage(orientation);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<DeviceOrientationChangeMessage>(this, DeviceOrientationChangeMessage.MessageId,
                (message) =>
                {
                    HandleOrientationMessage(message.Orientation);
                });
        }

        private void HandleOrientationMessage(DeviceOrientations orientation)
        {
            myLabel.Text = orientation.ToString();
            myLabel.TextColor = orientation.ToString() == "Landscape" ? Color.Fuchsia : Color.Green;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<DeviceOrientationChangeMessage>(this, DeviceOrientationChangeMessage.MessageId);
        }

        // Works really good
        //protected override void OrientationChanged(Orientations newOrientation)
        //{
        //    base.OrientationChanged(newOrientation);
        //    myLabel.Text = newOrientation == Orientations.Landscape ? "Landscape" : "Portrait";
        //}
    }
}
