using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet]
    public ActionResult<WeatherForecastResponse> GetWeatherForecast()
    {
        var response = new WeatherForecastResponse
        {
            Temperature = 16.6,
	    Condition = "Sunny",
            City = "Dublin",
            Timestamp = DateTime.Now,
            ApiVersion = "1.0",
            Status = "Success"
        };
        
        return Ok(response);
    }
    
    [HttpGet("{city}")]
    public ActionResult<GreetingResponse> GetGreetingByName(string city)
    {
        var response = new WeatherForecastResponse
        {
            Temperature = 17,
            City = city,
            Condition = "Rainy",
            Timestamp = DateTime.Now,
            ApiVersion = "1.0",
            Status = "Success"
        };
        
        return Ok(response);
    }
}

public class WeatherForecastResponse
{
    public string Message { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public string Condition   {get;set;} = string.Empty;
    public string City {get;set;} = string.Empty;
    public DateTime Timestamp { get; set; }
    public string ApiVersion { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}