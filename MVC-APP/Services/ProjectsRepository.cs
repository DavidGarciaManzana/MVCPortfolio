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
                Name = "Drilling Mud Mex",
                Description = "A project to solve problems for the Oil & Gas Industry.",
                URL = "https://davidgarxa.com/drilling-mud-mex/",
                URLImage = "/Media/Img/DMM.png"
            }, new ProjectViewModel
            {
                Name = "Rick & Morty API",
                Description = "Rick & Morty API Consuption",
                URL = "https://davidgarxa.com/code-challenge/API/rick_and_morty/",
                URLImage = "/Media/Img/API.png"
            }, new ProjectViewModel
            {
                Name = "Mars Rover",
                Description = "Videogame",
                URL = "https://davidgarxa.com/code-challenge/mars_rover/",
                URLImage = "/Media/Img/Game.png"
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
