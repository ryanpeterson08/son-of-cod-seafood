﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;



namespace SonOfCod.Controllers
{
    
    public class NewsletterController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
        private readonly UserManager<ApplicationUser> _userManager;

        public NewsletterController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        //public NewsletterController()
        //{

        //}

        public IActionResult Index()
        {
            return View(_db.Newsletters.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Newsletter newsletter)
        {
            _db.Newsletters.Add(newsletter);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
