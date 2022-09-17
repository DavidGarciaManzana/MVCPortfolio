using MVC_APP.Models;

namespace MVC_APP.Services
{
    public interface IProjectsRepository
    {
        List<ProjectViewModel> GetProjects();
    }
    public class ProjectsRepository : IProjectsRepository
    {
        public List<ProjectViewModel> GetProjects()
        {
            return new List<ProjectViewModel>() { new ProjectViewModel
            {
                Name = "Amazon",
                Description = "E-Commerce built with ASP.NET Core",
                URL = "Https://amazon.com",
                URLImage = "/Media/Img/amazon.PNG"
            }, new ProjectViewModel
            {
                Name = "New York Times",
                Description = "Blog",
                URL = "Https://nyt.com",
                URLImage = "/Media/Img/nyt.PNG"
            }, new ProjectViewModel
            {
                Name = "Reddit",
                Description = "Multiple Blog Website",
                URL = "Https://reddit.com",
                URLImage = "/Media/Img/reddit.PNG"
            }, new ProjectViewModel
            {
                Name = "Nintendo",
                Description = "E-commerce to sell videogames",
                URL = "Https://Nintendo.com",
                URLImage = "/Media/Img/Nintendo.png"
            },
            };
        }
    }
}
