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
    public partial class carTalkPage : ContentPage
    {
        public carTalkPage()
        {
            InitializeComponent();
        }

        private void Storyline1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new homeAgain());
        }

        private void homeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new startPage());
        }
    }
}