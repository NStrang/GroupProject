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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Storyline1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HectorScreams());
        }

        private void Storyline2_Clicked(object sender, EventArgs e)
        {

        }
    }
}