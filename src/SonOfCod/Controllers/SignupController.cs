using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;



namespace SonOfCod.Controllers
{
    [Authorize]
    public class SignupController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
        private readonly UserManager<ApplicationUser> _userManager;

        public SignupController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        //public SignupController()
        //{

        //}
        
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Signup signup)
        {
            var userEmail = _db.Users.ToList();
            foreach(var item in userEmail)
            {
                if(signup.userEmail == item.UserName)
                {
                    _db.Signups.Add(signup);
                    _db.SaveChanges();
                    return RedirectToAction("Index", "Newsletter");

                }
                else
                {
                    return RedirectToAction("Fail");
                }
            }
            return RedirectToAction("Fail");

        }

        public IActionResult Fail()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(_db.Signups.ToList());
        }
    }
}
