using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MainLibrary
{
    public class MyCustomPage : ContentPage
    {
        public MyCustomPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Hello, Custom Renderer!",
                    },
                    new MyCustomTextbox
                    {
                        Text = "Woaw, I'm Customized!",
                    }
                },
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}
