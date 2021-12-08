using AirPollutionMonitor.Models;
using AirPollutionMonitor.Services;
using Microsoft.Maui.Controls;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPollutionMonitor.ViewModels
{
    public class StationDetailsViewModel : BaseViewModel
    {
        private readonly IGiosApi _giosApi = RestService.For<IGiosApi>("https://api.gios.gov.pl");
        private int _stationId;

        private StationDetails _stationDetails;
        public StationDetails StationDetails
        {
            get => _stationDetails;
            set => SetProperty(ref _stationDetails, value);
        }

        public Command LoadStationDetailsCommand { get; }

        public StationDetailsViewModel(int stationId)
        {
            _stationId = stationId;
            LoadStationDetailsCommand = new Command(async () => await LoadStationDetails());
        }

        private async Task LoadStationDetails()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                StationDetails = await _giosApi.GetStationDetails(_stationId);
            }
            catch (Exception e)
            {
                App.Current.MainPage.DisplayAlert("", e.ToString(), "ok");
                Debug.WriteLine(e);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
