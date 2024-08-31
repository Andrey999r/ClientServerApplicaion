using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyNewWebsite.Data;
using MyNewWebsite.Models;
using System.Reflection.PortableExecutable;

namespace MyNewWebsite.Controllers
{
    public class RegistrationController : Controller
    {
        ApplicationDbContext db;
        public RegistrationController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Registrations() => View();
        [HttpPost]
         public IActionResult Registrations(Users users)
         {
           
                db.User.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
      
              
         }
        public IActionResult Index()
        {
            ViewBag.Message = "Вы успешно добавили пользователя!";
            return View(db.User.ToList<Users>());
        }
        [HttpPost]
        public IActionResult Login(Users users)
        {
            var valid = db.User.FirstOrDefault(u => u.Login ==users.Login);
            if (valid != null && valid.Password==users.Password)
            {
                return RedirectToAction("MainPage", "MainPage");
            }
            return View();
        }
    }


}

