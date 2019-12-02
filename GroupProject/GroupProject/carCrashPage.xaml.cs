using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class carCrashPage : ContentPage
    {
        public carCrashPage()
        {
            InitializeComponent();
        }

        private void youDied_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}