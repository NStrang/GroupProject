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
    public partial class suicidePage : ContentPage
    {
        public suicidePage()
        {
            InitializeComponent();
        }

        private void BackToHome_Clicked(object sender, EventArgs e)
        {
            
            
        }

        private void homeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new startPage());
        }

        private void policeButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}