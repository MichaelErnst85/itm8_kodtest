using itm8_kodtest.Method;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net;

namespace itm8_kodtest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherInformationController : ControllerBase
    {
        private const string Url = "https://opendata-download-metfcst.smhi.se/";

        private readonly PopulateListMethod populateList;
        private readonly ILogger<WeatherInformationController> _logger;

        public WeatherInformationController(ILogger<WeatherInformationController> logger)
        {
            _logger = logger;
            populateList = new PopulateListMethod();
        }

        [EnableCors("Test")]
        [HttpGet]
        public async Task<IActionResult> CityTemp()
        {
            var cityInformation = populateList.PopulateList();

            foreach (var city in cityInformation)
            { 
                var completeUrl = $"{Url}api/category/pmp3g/version/2/geotype/point/lon/{city.Longitude}/lat/{city.Latitude}/data.json";

                using HttpClient client = new HttpClient();

                HttpResponseMessage message = await client.GetAsync(completeUrl);

                if (message == null || message.StatusCode != HttpStatusCode.OK)
                {
                    _logger.LogError($"Error calling SMHI for city {city.City}");
                    return NotFound();
                }

                var content = await message.Content.ReadAsStringAsync();

                JObject temperatureData = JObject.Parse(content);

                JToken jsonParameter = null!;

                foreach (JToken parameter in temperatureData["timeSeries"][0]["parameters"])
                {
                    if (parameter["name"].ToString() == "t")
                    {
                        jsonParameter = parameter;
                        break;
                    }
                }

                if (jsonParameter != null)
                {
                    double temperature = jsonParameter["values"][0].ToObject<double>();
                    city.Temperature = temperature;
                }
                else
                {
                    _logger.LogWarning($"Problem when fetching data for city: {city.City}");
                }
                _logger.LogInformation($"Successfully called SMHI for city {city.City}");
            }

            return Ok(cityInformation);
        }
    }
}