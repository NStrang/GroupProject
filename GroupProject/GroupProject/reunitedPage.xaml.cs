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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void TalkOption_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new carTalkPage());
        }

        private void DoNothingOption_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HectorScreams());
        }
    }
}