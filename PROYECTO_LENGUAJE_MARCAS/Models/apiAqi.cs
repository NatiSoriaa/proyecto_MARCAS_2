namespace PROYECTO.Models;

public class ApiAqi
{
     public class Datum
    {
        public double aqi { get; set; }
        public double o3 { get; set; }
        public double so2 { get; set; }
        public double no2 { get; set; }
        public double co { get; set; }
        public double pm10 { get; set; }
        public double pm25 { get; set; }
        public int pollen_level_tree { get; set; }
        public int pollen_level_grass { get; set; }
        public int pollen_level_weed { get; set; }
        public int mold_level { get; set; }
        public string predominant_pollen_type { get; set; }
    }

    public class Aqi
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public string city_name { get; set; }
        public string country_code { get; set; }
        public string state_code { get; set; }
        public List<Datum> data { get; set; }
    }


}