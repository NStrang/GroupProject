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
    public partial class homeAgain : ContentPage
    {
        public homeAgain()
        {
            InitializeComponent();
        }

        private void suicideButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new suicidePage());
        }

        private void murderButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new murderPage());
        }



    }
}