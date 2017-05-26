
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(String ReturnUrl)
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(LoginViewModelcs loginViewModel, String BtnSubmit, String returnURL)
        {
            if (loginViewModel.Username == "admin" && loginViewModel.Password == "admin")
            {
                //String baseHost = Request.Url.GetLeftPart(UriPartial.Authority) + Url.Content("~");
                //String host = baseHost.Remove(baseHost.Length - 1);
                //String request = host + returnURL;
                //return Redirect(request);
                FormsAuthentication.SetAuthCookie(loginViewModel.Username, false);
                return Redirect(returnURL);
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                return View("Login");
            }
            return View("Login");
        }

        public ActionResult Test()
        {
            LoginViewModelcs loginViewModel = new LoginViewModelcs() { Username = "", Password = "Password" };
            return View(loginViewModel);
        }

        public ActionResult JJPartial()
        {
            return PartialView("JJPartialView");
        }

    }
}