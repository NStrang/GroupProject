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
    public partial class youCallPolice : ContentPage
    {
        public youCallPolice()
        {
            InitializeComponent();
        }

        private void homeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new startPage());
        }

        private void clickForWin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new youWinPage());
        }
    }
}