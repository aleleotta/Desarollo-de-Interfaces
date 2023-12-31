﻿namespace Unidad5_ejercicio1_HolaMundo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre.Text))
            {
                string lastNames = "";
                lastNames = await DisplayPromptAsync("Hello buddy!", "Introduce your last names:");
                while(string.IsNullOrWhiteSpace(lastNames) || string.IsNullOrEmpty(lastNames))
                {
                    if(string.IsNullOrWhiteSpace(lastNames) || string.IsNullOrEmpty(lastNames))
                    {
                        lastNames = await DisplayPromptAsync("Error!", "You must introduce your last names.");
                    }
                }
                await DisplayAlert("Hello!", "Hello "+txtNombre.Text+" "+lastNames+"!", "Close");
            }
        }
    }
}