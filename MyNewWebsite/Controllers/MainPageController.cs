using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyNewWebsite.Data;
using MyNewWebsite.Models;

namespace MyNewWebsite.Controllers
{
    public class MainPageController : Controller
    {
        ApplicationDbContext db;
        public MainPageController(ApplicationDbContext context)
        {
            db=context; 
        }

        public IActionResult MainPage()
        {
            var lastUserId = db.User.Max(u => u.Id);
            
            
            return View();
        }
    }
}
