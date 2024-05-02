using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeaveManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var requestedId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            var excHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (excHandlerPathFeature != null)
            {
                Exception ex = excHandlerPathFeature.Error;
                _logger.LogError(ex, $"error encountered by user:{this.User?.Identity?.Name} reuested by {requestedId}");
            }
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
