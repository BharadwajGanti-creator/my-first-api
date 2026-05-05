using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreetingController : ControllerBase
{
    [HttpGet]
    public ActionResult<GreetingResponse> GetGreeting()
    {
        var response = new GreetingResponse
        {
            Message = "Hello, Bharadwaj! This is YOUR custom endpoint.",
            Timestamp = DateTime.Now,
            ApiVersion = "1.0",
            Status = "Success"
        };
        
        return Ok(response);
    }
    
    [HttpGet("{name}")]
    public ActionResult<GreetingResponse> GetGreetingByName(string name)
    {
        var response = new GreetingResponse
        {
            Message = $"Hello, {name}! Welcome to MyFirstAPI built on May 5, 2026.",
            Timestamp = DateTime.Now,
            ApiVersion = "1.0",
            Status = "Success"
        };
        
        return Ok(response);
    }
}

public class GreetingResponse
{
    public string Message { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public string ApiVersion { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}