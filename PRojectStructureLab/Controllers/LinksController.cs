using Microsoft.AspNetCore.Mvc;
using ProjectStructureLab.Models;

namespace ProjectStructureLab.Controllers;

[ApiController]
[Route("links")]
public class LinksController : ControllerBase
{
    [HttpGet("{subdomain}")]
    public IActionResult GetLink(
        [FromRoute] string subdomain,
        [FromBody] bool IncludeAnalytics = false)
    {
        
        if (subdomain != "git")
        {
            return NotFound();
        }

        return Ok(new{
            Subdomain = "git",
            DestinationUrl = "https://github.com",
            IncludeAnalytics = IncludeAnalytics
        });
    }

    [HttpPost]
    public IActionResult CreateLink(
        [FromBody] CreateLinkRequest request
    )
    {
        if (string.IsNullOrWhiteSpace(request.Subdomain) ||
        string.IsNullOrWhiteSpace(request.DestinationUrl))
        {
            return BadRequest();
        }

        return CreatedAtAction(
            nameof(GetLink),
            new{ subdomain = request.Subdomain },
            request
        );
    }


    [HttpGet("{subdomain}/redirect")]
    public IActionResult RedirectLink([FromRoute] string subdomain)
    {
        if (subdomain != "git")
        {
            return NotFound();
        }

        Console.Writeline("Completed");

        return Redirect("https://github.com");
    }

}