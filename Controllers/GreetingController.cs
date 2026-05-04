using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreetingController : ControllerBase
{
    [HttpGet]
    public string SayHello()
    {
        return "Hello, Bharadwaj! This is YOUR custom endpoint.";
    }
    
    [HttpGet("{name}")]
    public string SayHelloTo(string name)
    {
        return $"Hello, {name}! Welcome to MyFirstAPI built on May 5, 2026.";
    }
}