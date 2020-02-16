﻿using IndicatorViewPopup.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace IndicatorViewPopup
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupPage popupPage = new PopupPage(new PopupViewModel());
            Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(popupPage);
        }
    }
}
