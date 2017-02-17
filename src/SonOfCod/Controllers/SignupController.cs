using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;



namespace SonOfCod.Controllers
{
    [Authorize]
    public class SignupController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public SignupController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Signup signup)
        {
            _db.Signups.Add(signup);
            _db.SaveChanges();
            return RedirectToAction("Index", "Newsletter");
        }
    }
}
