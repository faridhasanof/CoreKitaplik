using CoreKitaplik.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKitaplik.ViewComponents
{
    public class YeniKitaplar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplistesi = new List<Kitablar>()
            {
                new Kitablar
                {
                    ID=6,
                    KitabAd="Beyaz",
                    Yazar="Reng6"
                },
                new Kitablar
                {
                    ID=7,
                    KitabAd="Cehrayi",
                    Yazar="Reng7"
                }
            };
            return View(kitaplistesi);
        }
    }
}
