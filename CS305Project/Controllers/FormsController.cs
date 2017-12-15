using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CS305Project.Models;

namespace CS305Project.Controllers
{
    public class FormsController : Controller
    {
        private ApplicationDbContext _dbContext; 
        // GET: Forms

        public FormsController()
        {
            _dbContext = new ApplicationDbContext(); 
        }
        public ActionResult Index()
        {
            var form = _dbContext.Forms.ToList(); 
            return View();
        }
    }
}