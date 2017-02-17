using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;



namespace SonOfCod.Controllers
{
    
    public class NewsletterController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public NewsletterController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
