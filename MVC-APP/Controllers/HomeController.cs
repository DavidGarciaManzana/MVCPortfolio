using Microsoft.AspNetCore.Mvc;
using MVC_APP.Models;
using MVC_APP.Services;
using System.Diagnostics;

namespace MVC_APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepository projectsRepository;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IProjectsRepository projectsRepository, IConfiguration configuration)
        {
            _logger = logger;
            this.projectsRepository = projectsRepository;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            var apellido = configuration.GetValue<string>("Apellido");
            _logger.LogInformation("Mensaje informativo");
            _logger.LogWarning("Mensaje warning");
            _logger.LogError("Mensaje error");
            _logger.LogCritical("Mensaje critico" + apellido);
            ViewBag.Apellido = "García";
            var projects = projectsRepository.GetProjects().Take(3).ToList();
            var model = new HomeIndexViewModel() { Projects = projects };
            return View(model);
        }
       

        public IActionResult Projects()
        {
            var projects = projectsRepository.GetProjects();
            return View(projects);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}