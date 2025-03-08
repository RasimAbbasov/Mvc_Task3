using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EternaApp.Controllers
{
    public class BlogController(EternaAppContext eternaAppContext) : Controller
    {
        public IActionResult Index()
        {
            BlogVm blogVm = new()
            {
                Blogs = eternaAppContext.Blogs.ToList(),
                RecentBlogs = eternaAppContext.Blogs.OrderByDescending(x => x.Id).Take(3).ToList(),
                BlogCategories = eternaAppContext.Categories.ToList()
            };
            return View(blogVm);
        }
    }
}
