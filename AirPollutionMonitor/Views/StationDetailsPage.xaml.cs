using System;
using AirPollutionMonitor.ViewModels;
using Microsoft.Maui.Controls;

namespace AirPollutionMonitor
{
	public partial class StationDetailsPage : ContentPage
	{
        private readonly StationDetailsViewModel _viewModel;

        public StationDetailsPage(int stationId)
        {
            InitializeComponent();
            BindingContext = _viewModel = new StationDetailsViewModel(stationId);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel.StationDetails == null)
            {
                _viewModel.LoadStationDetailsCommand.Execute(null);
            }
        }
    }
}
