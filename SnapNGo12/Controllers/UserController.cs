using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SnapNGo12.Models;

namespace SnapNGo12.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        //public Task<ActionResult> Register(User model)
        public void Login(User model)
        {
            if (ModelState.IsValid)
            {
                if (model.userName == "admin")
                {
                    
                }

            }

        }

        public ActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        //public Task<ActionResult> Register(User model)
        public void Register(User model)
        {
            if (ModelState.IsValid)
            {
               var s = model.userName;

            }

        }
    }
}