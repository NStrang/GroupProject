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
    public partial class brothersPage : ContentPage
    {
        public brothersPage()
        {
            InitializeComponent();
        }

        private void AskAboutDeploymentOption_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new carTalkPage());
        }

        private void DoNothingOption_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HectorScreams());

        }

        private void homeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new startPage());
        }
    }
}