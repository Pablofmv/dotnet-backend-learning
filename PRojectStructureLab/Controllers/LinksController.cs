using Microsoft.AspNetCore.Mvc;
using ProjectStructureLab.Models;

namespace ProjectStructureLab.Controllers;

[ApiController]
[Route("links")]
public class LinksController : ControllerBase
{
    [HttpGet("{subdomain}")]
    public string GetLink(
        [FromRoute] string subdomain,
        [FromBody] bool IncludeAnalytics = false)
    {
        return $"Looking up: {subdomain}, Include Analytics : {IncludeAnalytics}";
    }

    [HttpPost]
    public string CreateLink(
        [FromBody] CreateLinkRequest request
    )
    {
        return $"Creating {request.Subdomain} -> {request.DestinationUrl}";
    }
}