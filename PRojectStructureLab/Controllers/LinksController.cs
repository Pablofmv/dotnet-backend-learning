using Microsoft.AspNetCore.Mvc;
using ProjectStructureLab.Models;
using ProjectStructureLab.Services;

namespace ProjectStructureLab.Controllers;

[ApiController]
[Route("links")]
public class LinksController : ControllerBase
{

    private readonly ILinkService _linkService;

    public LinksController(ILinkService linkService)
    {
        _linkService = linkService;
    }

    [HttpGet("{subdomain}")]
    public IActionResult GetLink(
        [FromRoute] string subdomain,
        [FromBody] bool IncludeAnalytics = false)
    {
        
        var destinationUrl = _linkService.GetDestination(subdomain);

        if (destinationUrl is null)
        {
            return NotFound();
        }

        return Ok(new{
            Subdomain = subdomain,
            DestinationUrl = destinationUrl,
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

        var destinationUrl = _linkService.GetDestination(subdomain);

        if (destinationUrl is null)
        {
            return NotFound();
        }

        return Redirect(destinationUrl);
    }

}