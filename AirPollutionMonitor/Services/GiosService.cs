using AirPollutionMonitor.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPollutionMonitor.Services
{
    public interface IGiosApi
    {
        [Get("/pjp-api/rest/station/findAll")]
        Task<List<Station>> GetStations();

        [Get("/pjp-api/rest/aqindex/getIndex/{stationId}")]
        Task<StationDetails> GetStationDetails(int stationId);
    }
}
