using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace EternaApp.Controllers
{
    public class PortfolioController(EternaAppContext eternaAppContext) : Controller
    {
        public IActionResult Index()
        {
            PortfolioVm portfolioVm = new()
            {
                Categories=eternaAppContext.Categories.ToList(),
                Projects=eternaAppContext.Projects
                .Include(x=>x.Category)
                .Include(x=>x.ProjectImages)
                .ToList()
            };
            return View(portfolioVm);
        }
        public IActionResult Detail(int? id) 
        {
            if (id is null)
            {
                return NotFound();
            }
            var project = eternaAppContext.Projects
                .Include(p => p.ProjectImages)
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return  NotFound();
            }
            return View(project);
        }
    }
}
