using System.Diagnostics;
using System.Text.Json;

using Microsoft.AspNetCore.Mvc;
using PROYECTO.Models;
using PROYECTO_LENGUAJE_MARCAS.Models;

namespace PROYECTO_LENGUAJE_MARCAS.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        List<CountriesID> countriesIDs=CreateCountrysList();
        
        return View(countriesIDs);
    }

    public struct CountriesID{
        public string countryName;
        public string capitalCountry;

        public string urlImagen;
        public string urlCityImage;
        public int id;
    }
    static List <CountriesID> CreateCountrysList(){
        List <CountriesID> countriesIDs= new List <CountriesID> ()
        {
        new CountriesID {countryName="Albania",capitalCountry="Tirana",urlImagen="Content/Images/flags/banderaAlbania.jpeg", urlCityImage="Content/Images/countries/tirana.jpg", id=3183875},
        new CountriesID {countryName="Germany",capitalCountry="Berlín",urlImagen="Content/Images/flags/banderaAlemania.jpeg",urlCityImage="Content/Images/countries/berlin.jpg",id=2950159},
        new CountriesID {countryName="Andorra",capitalCountry="Andorra la vieja",urlImagen="Content/Images/flags/banderaAndorra.jpeg",urlCityImage="Content/Images/countries/andorra.jpg",id=7730819},
        new CountriesID {countryName="Austria",capitalCountry="Vienna",urlImagen="Content/Images/flags/banderaAustria.jpeg", urlCityImage="Content/Images/countries/vienna.jpg",id=2761367},
        new CountriesID {countryName="Azerbaijan",capitalCountry="Baku",urlImagen="Content/Images/flags/banderaBelgica.jpeg", urlCityImage="Content/Images/countries/baku.jpg",id=587084},
        new CountriesID {countryName="Belgium",capitalCountry="Brussels ",urlImagen="",urlCityImage="Content/Images/countries/brussels.jpg",id=2800867},
        new CountriesID {countryName="Belarus",capitalCountry="Minsk ",urlImagen="",urlCityImage="Content/Images/countries/minsk.jpg",id=625144},
        new CountriesID {countryName="Bosnia and Herzegovina",capitalCountry="Sarajevo",urlImagen="",urlCityImage="Content/Images/countries/sarajevo.jpg",id=3191281},
        new CountriesID {countryName="Bulgaria",capitalCountry="Sofia",urlImagen="",urlCityImage="Content/Images/countries/sofia.jpg",id=727011},
        new CountriesID {countryName="Croatia",capitalCountry="Zagreb",urlImagen="",urlCityImage="Content/Images/countries/zagreb.jpg",id=3186886},
        new CountriesID {countryName="Cyprus",capitalCountry="Nicosia",urlImagen="",urlCityImage="Content/Images/countries/nicosia.jpg",id=146268},
        new CountriesID {countryName="Chezchia",capitalCountry="Prague",urlImagen="",urlCityImage="Content/Images/countries/prague.jpg",id=3067695},
        new CountriesID {countryName="Denmark",capitalCountry="Copenhagen",urlImagen="",urlCityImage="Content/Images/countries/copenaguen.jpg",id=2618425},
        new CountriesID {countryName="Estonia",capitalCountry="Tallinn",urlImagen="",urlCityImage="Content/Images/countries/tallin.jpg",id=588409},
        new CountriesID {countryName="Finland",capitalCountry="Helsinki",urlImagen="",urlCityImage="Content/Images/countries/hellsinki.jpg",id=658225},
        new CountriesID {countryName="France",capitalCountry="Paris",urlImagen="",urlCityImage="Content/Images/countries/paris.jpg",id=2988507},
        new CountriesID {countryName="Georgia",capitalCountry="Tbilisi",urlImagen="",urlCityImage="Content/Images/countries/tibilisi.jpeg",id=611717},
        new CountriesID {countryName="Greece",capitalCountry="Athens",urlImagen="",urlCityImage="Content/Images/countries/athens.jpg",id=24505546},
        new CountriesID {countryName="Hungary",capitalCountry="Budapest",urlImagen="",urlCityImage="Content/Images/countries/budapest.jpg",id=3054643},
        new CountriesID {countryName="Iceland",capitalCountry="Reykjavik",urlImagen="",urlCityImage="Content/Images/countries/reykjavik.jpg",id=3413829},
        new CountriesID {countryName="Ireland",capitalCountry="Dublin",urlImagen="",urlCityImage="Content/Images/countries/dublin.jpg",id=2964574},
        new CountriesID {countryName="Italy",capitalCountry="Rome",urlImagen="",urlCityImage="Content/Images/countries/rome.jpg",id=3169070},
        new CountriesID {countryName="Kazakhstan",capitalCountry="Astana",urlImagen="",urlCityImage="Content/Images/countries/astana.jpg",id=1538317},
        new CountriesID {countryName="Kosovo",capitalCountry="Pristina",urlImagen="",urlCityImage="Content/Images/countries/pristina.jpg",id=786714},
        new CountriesID {countryName="Latvia",capitalCountry="Riga",urlImagen="",urlCityImage="Content/Images/countries/riga.jpg",id=456172},
        new CountriesID {countryName="Liechtenstein",capitalCountry="Vaduz",urlImagen="",urlCityImage="Content/Images/countries/vaduz.jpg",id=3042030},
        new CountriesID {countryName="Lithuania",capitalCountry="Vilnius",urlImagen="",urlCityImage="Content/Images/countries/vilnius.jpg",id=593116},
        new CountriesID {countryName="Luxembourg",capitalCountry="Luxembourg(City)",urlImagen="",urlCityImage="Content/Images/countries/luxemburgo.jpg",id=2960316},
        new CountriesID {countryName="Malta",capitalCountry="Valletta",urlImagen="",urlCityImage="Content/Images/countries/valletta.jpg",id=2562305},
        new CountriesID {countryName="Moldava",capitalCountry="Chisinau",urlImagen="",urlCityImage="Content/Images/countries/chisinau.jpg",id=618426},
        new CountriesID {countryName="Monaco",capitalCountry="Monaco",urlImagen="",urlCityImage="Content/Images/countries/monaco.jpg",id=2993458},
        new CountriesID {countryName="Montenegro",capitalCountry="Podgorica",urlImagen="",urlCityImage="Content/Images/countries/podgorica.jpg",id=3193044},
        new CountriesID {countryName="Netherlands",capitalCountry="Amsterdam",urlImagen="",urlCityImage="Content/Images/countries/amestrdam.jpg",id=2759793},
        new CountriesID {countryName="North Macedonia",capitalCountry="Skopje",urlImagen="",urlCityImage="Content/Images/countries/skopje.jpg",id=785842},
        new CountriesID {countryName="Norway",capitalCountry="Oslo",urlImagen="",urlCityImage="Content/Images/countries/oslo.jpg",id=3143244},
        new CountriesID {countryName="Poland",capitalCountry="Warsaw",urlImagen="",urlCityImage="Content/Images/countries/warsaw.jpg",id=756135},
        new CountriesID {countryName="Portugal",capitalCountry="Lisbon",urlImagen="",urlCityImage="Content/Images/countries/lisbon.jpg",id=2267057},
        new CountriesID {countryName="Romania",capitalCountry="Bucharest",urlImagen="",urlCityImage="Content/Images/countries/bucharest.jpeg",id=6835056},
        new CountriesID {countryName="Russia",capitalCountry="Moscow",urlImagen="",urlCityImage="Content/Images/countries/moscow.jpg",id=524901},
        new CountriesID {countryName="San Marino",capitalCountry="San Marino",urlImagen="",urlCityImage="Content/Images/countries/san_marino.jpg",id=3168070},
        new CountriesID {countryName="Serbia",capitalCountry="Belgrade",urlImagen="",urlCityImage="Content/Images/countries/belgrade.jpg",id=792680},
        new CountriesID {countryName="Slovakia",capitalCountry="Bratislava",urlImagen="",urlCityImage="Content/Images/countries/bratislava.jpg",id=3060972},
        new CountriesID {countryName="Stovenia",capitalCountry="Ljubljana",urlImagen="",urlCityImage="Content/Images/countries/ljubljana.jpg",id=3196359},
        new CountriesID {countryName="Spain",capitalCountry="Madrid",urlImagen="",urlCityImage="Content/Images/countries/madrid.jpg",id=3117735},
        new CountriesID {countryName="Sweden",capitalCountry="Stockholm",urlImagen="",urlCityImage="Content/Images/countries/stockholm.jpg",id=2673730},
        new CountriesID {countryName="Switzerland",capitalCountry="Bern",urlImagen="",urlCityImage="Content/Images/countries/bern.jpg",id=2661552},
        new CountriesID {countryName="Turkey",capitalCountry="Ankara",urlImagen="",urlCityImage="Content/Images/countries/ankara.jpg",id=323786},
        new CountriesID {countryName="Ukraine",capitalCountry="Kyiv",urlImagen="",urlCityImage="Content/Images/countries/kyiv.jpg",id=703448},
        new CountriesID {countryName="United Kingdom",capitalCountry="London",urlImagen="",urlCityImage="Content/Images/countries/london.jpg",id=2643743},
        new CountriesID {countryName="Vatican City",capitalCountry="Vatican City",urlImagen="",urlCityImage="Content/Images/countries/vatican_city.jpg",id=6691831}
        };

        return countriesIDs;

    }

    public IActionResult WeatherInformation(string id, string background){

        
        var urlApiCountry = $"http://api.geonames.org/getJSON?geonameId={id}&username=nagasa";
        var clientCountry = new HttpClient();
        var responseCountry = clientCountry.GetAsync(urlApiCountry).Result;
        var contentCountry=responseCountry.Content.ReadAsStringAsync().Result;
        var informationCountry = JsonSerializer.Deserialize<ApiCountry.Country>(contentCountry);
        
        var countryList = new List<ApiCountry.Country>{informationCountry};



        var urlApiWeather=$"https://api.weatherbit.io/v2.0/current?lat={countryList[0].lat}&lon={countryList[0].lng}&key=b594f4848b42479cb1d61d4283ff8793&include=minutely";
        var clientWeather= new HttpClient();
        var responseWeather=clientWeather.GetAsync(urlApiWeather).Result;
        var contentWeather=responseWeather.Content.ReadAsStringAsync().Result;
        
        var informationWeather = JsonSerializer.Deserialize<ApiWeather.Root>(contentWeather);

        var listInformationWeather = new List<ApiWeather.Root>{informationWeather};

        ViewData["Background"]=background;
        
        
        if (listInformationWeather != null)
        {
            return View(listInformationWeather);
        }
        else
        {
            return View("no hay datos");
        }

    }


    
    

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
