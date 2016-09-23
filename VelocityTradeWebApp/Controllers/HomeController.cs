﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;

namespace VelocityTradeWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search(SignInStatus? Auth)
        {
            if (Auth == null) { return RedirectToAction("Login", "Account"); }

            switch (Auth)
            {
                case SignInStatus.Success:
                    return View();
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return RedirectToAction("Index", "Home");
            }
        }
    }
}