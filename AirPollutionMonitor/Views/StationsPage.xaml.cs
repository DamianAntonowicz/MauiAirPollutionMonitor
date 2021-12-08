using System;
using AirPollutionMonitor.Models;
using AirPollutionMonitor.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace AirPollutionMonitor
{
	public partial class StationsPage : ContentPage
	{
		private readonly StationsViewModel _stationsViewModel;

		public StationsPage()
		{
			InitializeComponent();
			BindingContext = _stationsViewModel = new StationsViewModel();
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (_stationsViewModel.Stations == null ||
				_stationsViewModel.Stations.Count == 0)
			{
				_stationsViewModel.LoadStationsCommand.Execute(null);
			}
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
			var bindableObject = sender as BindableObject;
			var station = bindableObject.BindingContext as Station;

			await Navigation.PushAsync(new StationDetailsPage(station.Id));
		}
    }
}
