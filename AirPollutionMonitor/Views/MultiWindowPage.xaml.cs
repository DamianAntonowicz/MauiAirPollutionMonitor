using System;
using AirPollutionMonitor.Services;
using AirPollutionMonitor.ViewModels;
using Microsoft.Maui.Controls;

namespace AirPollutionMonitor
{
	public partial class MultiWindowPage : ContentPage
	{
        public MultiWindowPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var secondWindow = new Window
            {
                Page = new ImagePage()
            };

            Application.Current.OpenWindow(secondWindow);
        }
    }
}
