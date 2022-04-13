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
    public class StationsViewModel : BaseViewModel
    {
        private readonly IGiosApi _giosApi;

        private List<Station> _stations;
        public List<Station> Stations
        {
            get => _stations;
            set => SetProperty(ref _stations, value);
        }

        public Command LoadStationsCommand { get; }

        public StationsViewModel(IGiosApi giosApi)
        {
            _giosApi = giosApi;
            LoadStationsCommand = new Command(async () => await LoadStations());
        }

        private async Task LoadStations()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                Stations = null;
                var stations = await _giosApi.GetStations();
                Stations = stations.OrderBy(x => x.StationName).ToList();
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
