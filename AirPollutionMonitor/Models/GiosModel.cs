using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AirPollutionMonitor.Models
{
    public class Station
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("gegrLat")]
        public string GegrLat { get; set; }

        [JsonProperty("gegrLon")]
        public string GegrLon { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("addressStreet")]
        public string AddressStreet { get; set; }
    }

    public class City
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("commune")]
        public Commune Commune { get; set; }
    }

    public class Commune
    {
        [JsonProperty("communeName")]
        public string CommuneName { get; set; }

        [JsonProperty("districtName")]
        public string DistrictName { get; set; }

        [JsonProperty("provinceName")]
        public string ProvinceName { get; set; }
    }

    public class StationDetails
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        //[JsonProperty("stCalcDate")]
        //public DateTimeOffset? StCalcDate { get; set; }

        [JsonProperty("stIndexLevel")]
        public IndexLevel StIndexLevel { get; set; }

        //[JsonProperty("stSourceDataDate")]
        //public DateTimeOffset? StSourceDataDate { get; set; }

        //[JsonProperty("so2CalcDate")]
        //public DateTimeOffset? So2CalcDate { get; set; }

        [JsonProperty("so2IndexLevel")]
        public object So2IndexLevel { get; set; }

        //[JsonProperty("so2SourceDataDate")]
        //public object So2SourceDataDate { get; set; }

        //[JsonProperty("no2CalcDate")]
        //public long? No2CalcDate { get; set; }

        [JsonProperty("no2IndexLevel")]
        public IndexLevel No2IndexLevel { get; set; }

        //[JsonProperty("no2SourceDataDate")]
        //public DateTimeOffset? No2SourceDataDate { get; set; }

        //[JsonProperty("coCalcDate")]
        //public DateTimeOffset? CoCalcDate { get; set; }

        [JsonProperty("coIndexLevel")]
        public IndexLevel CoIndexLevel { get; set; }

        //[JsonProperty("coSourceDataDate")]
        //public DateTimeOffset? CoSourceDataDate { get; set; }

        //[JsonProperty("pm10CalcDate")]
        //public DateTimeOffset? Pm10CalcDate { get; set; }

        [JsonProperty("pm10IndexLevel")]
        public IndexLevel Pm10IndexLevel { get; set; }

        //[JsonProperty("pm10SourceDataDate")]
        //public DateTimeOffset? Pm10SourceDataDate { get; set; }

        //[JsonProperty("pm25CalcDate")]
        //public DateTimeOffset? Pm25CalcDate { get; set; }
        
        [JsonProperty("pm25IndexLevel")]
        public IndexLevel Pm25IndexLevel { get; set; }

        //[JsonProperty("pm25SourceDataDate")]
        //public DateTimeOffset? Pm25SourceDataDate { get; set; }

        //[JsonProperty("o3CalcDate")]
        //public object O3CalcDate { get; set; }

        [JsonProperty("o3IndexLevel")]
        public object O3IndexLevel { get; set; }

        //[JsonProperty("o3SourceDataDate")]
        //public object O3SourceDataDate { get; set; }

        //[JsonProperty("c6h6CalcDate")]
        //public DateTimeOffset? C6H6CalcDate { get; set; }

        [JsonProperty("c6h6IndexLevel")]
        public IndexLevel C6H6IndexLevel { get; set; }

        //[JsonProperty("c6h6SourceDataDate")]
        //public DateTimeOffset? C6H6SourceDataDate { get; set; }

        [JsonProperty("stIndexStatus")]
        public bool StIndexStatus { get; set; }

        [JsonProperty("stIndexCrParam")]
        public string StIndexCrParam { get; set; }
    }

    public class IndexLevel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("indexLevelName")]
        public string IndexLevelName { get; set; }
    }
}
