using Microsoft.AspNetCore.Mvc;

namespace ProjectStructureLab.Controllers;

[ApiController]
[Route("links")]

public class LinksController : ControllerBase
{
    [HttpGet("{subdomain}")]
    public string GetLink(string subdomain)
    {
        return $"Looking up: {subdomain}";
    }
}