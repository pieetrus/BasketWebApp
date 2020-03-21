using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BasketApp.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //Temp Data zastosowane by udowodnić że rozumiem jak działa
            TempData["Message"] =
                "Wiadomość pokazująca że użyłem TempData," +
                " bo nie znalazłem żadnego sensownego zastosowania tej funkcji u mnie w alikacji. "+
                "Jak wejdziesz na stronę główną i tu wrócisz to zobaczysz ten napis wchodząc tu z innej strony nie zobaczysz go :(((";


            return View();
        }


        /// <summary>
        /// Strona z informacjami kontaktowymi
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            ViewBag.PageTitle = "Kontakt";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
