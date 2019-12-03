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
    public partial class HectorScreams : ContentPage
    {
        public HectorScreams()
        {
            InitializeComponent();
        }

        private void GoingHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new homeAgain());
        }

        private void crashButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new carCrashPage());
        }
    }
}