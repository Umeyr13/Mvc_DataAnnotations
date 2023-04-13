using Mvc_DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_DataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Kullanici kullanici)
        {
            if (kullanici.kullaniciAdi=="deneme")
            {
             ModelState.AddModelError("","Bu kullanıcı adı daha önce eklenmiş");

            }
            return View();
        }
    }
}