using MVCEntityFrameworkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEntityFrameworkCodeFirst.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public AccountController()
        {

        }

        // GET: Account
        [AllowAnonymous]
        public ActionResult Register()
        {
            AccountViewModel model = new AccountViewModel();
            return View(model);
        }
    }
}