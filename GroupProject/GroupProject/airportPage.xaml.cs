﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class airportPage : ContentPage
    {
        public airportPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            homeButton.FadeTo(1, 2500);
            airportText.FadeTo(1, 2500);
            
        }
        private void yellOption_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new reunitedPage());
        }

        private void throwOption_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new brothersPage());
        }

        private void homeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}