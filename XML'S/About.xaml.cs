﻿
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloudGamingApplication.XML_S
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class About : ContentPage
	{
        string role;
		public About (string r)
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);

            role = r; 
            about_Label.Text = "'Cloud Gaming Application' \n"; 
        }

        private async void Return_OnClicked(object sender, EventArgs e) =>
           await Navigation.PushAsync(new XML_S.MainPage(role));

    }
}