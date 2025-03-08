using EternaApp.Data;
using EternaApp.Models;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EternaApp.Controllers
{
    public class HomeController(EternaAppContext eternaDbContext) : Controller
    {
        public IActionResult Index()
        {
            HomeVm homeVm = new()
            {
                Sliders = eternaDbContext.Sliders.OrderBy(s => s.Order).ToList()
            };
            return View(homeVm);
        }   
    }
}
