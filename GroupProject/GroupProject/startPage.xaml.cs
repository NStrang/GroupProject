﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GroupProject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class startPage : ContentPage
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void startButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new airportPage());
        }
    }
}
