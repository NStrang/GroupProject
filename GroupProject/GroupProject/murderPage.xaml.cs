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
    public partial class murderPage : ContentPage
    {
        public murderPage()
        {
            InitializeComponent();
        }

        private void homeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new startPage());
        }
    }
}