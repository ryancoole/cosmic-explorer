using CosmicExplorer.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ApodController : ControllerBase
{
    private readonly NasaApodService _nasaApodService;

    public ApodController(NasaApodService nasaApodService)
    {
        _nasaApodService = nasaApodService;
    }

    [HttpGet]
    public async Task<ActionResult<NasaApodResponseDto>> Get()
    {
        var apodData = await _nasaApodService.GetApodAsync();
        return Ok(apodData);
    }
}