using Microsoft.AspNetCore.Mvc;
using FeiraLivre.Services.Api.Models;

namespace FeiraLivre.Services.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FeiraController : ControllerBase
{
    private readonly ILogger<FeiraController> _logger;

    public FeiraController(ILogger<FeiraController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "ListFeira")]
    public IEnumerable<Feira> Get()
    {
        return Enumerable.Empty<Feira>();
    }
}
