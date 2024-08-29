using CosmicExplorer.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CosmicExplorer.UI.Controllers
{
    public class NasaApodController : Controller
    {
        private readonly NasaApodService _nasaApodService;

        public NasaApodController(NasaApodService nasaApodService)
        {
            _nasaApodService = nasaApodService;
        }

        public async Task<IActionResult> Index()
        {
            var apodData = await _nasaApodService.GetApodAsync();
            return View(apodData);
        }
    }
}