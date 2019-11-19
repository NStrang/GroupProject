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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void AskAboutDeploymentOption_Clicked(object sender, EventArgs e)
        {

        }

        private void DoNothingOption_Clicked(object sender, EventArgs e)
        {

        }
    }
}