using System;
using AirPollutionMonitor.Services;
using AirPollutionMonitor.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace AirPollutionMonitor
{
	public partial class CodeSharingPage : ContentPage
	{
        public CodeSharingPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var message = MessageService.GetMessage();
            DisplayAlert(title: "", message: message, cancel: "ok");
        }
    }
}
