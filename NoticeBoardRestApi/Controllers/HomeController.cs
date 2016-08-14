using NoticeBoardDtos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using User;

namespace NoticeBoardRestApi.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            //return View();
        }
        public void Login(Login input)
        {
            new UserLogic().Login(input);
        }
    }
}
