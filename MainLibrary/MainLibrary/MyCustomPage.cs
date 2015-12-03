using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;
using Xamarin.Forms;

namespace MainLibrary
{
    //Page testing customized text boxes for android
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
            //TestingInsightByThrowingACrazyException();
        }

        // Will show up in my Xamarin Insights when you run the app as a Divide by zero ex. Pretty nice.
        private void TestingInsightByThrowingACrazyException()
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception ex)
            {
               Insights.Report(ex, new Dictionary<string, string>
               {
                   {"Woaw dude! You tried to divide by zero!", "Truly a classic mistake" }
               });
            }
        }
    }
}
