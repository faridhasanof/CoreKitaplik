using CoreKitaplik.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKitaplik.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var ktb = new List<Kitablar>()
            {
                new Kitablar(){ID=1,KitabAd="Ag",Yazar="Reng1"},
                new Kitablar(){ID=2,KitabAd="Sari",Yazar="Reng2"},
                new Kitablar(){ID=3,KitabAd="Goy",Yazar="Reng3"},
                new Kitablar(){ID=4,KitabAd="Yasil",Yazar="Reng4"},
                new Kitablar(){ID=5,KitabAd="Mavi",Yazar="Reng5"}
            };
            return View(ktb);
        }
        public IActionResult Yoxlama()
        {
            return View();
        }
        public IActionResult StatikTema()
        {
            return View();
        }
    }
}
