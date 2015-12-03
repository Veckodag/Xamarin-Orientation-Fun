using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MainLibrary
{
    //Makes the entry color Mace Windu Light Saber colored
    public class MyCustomTextbox : Entry
    {
        public MyCustomTextbox()
        {
            TextColor = Color.Fuchsia;
        }
    }
}
