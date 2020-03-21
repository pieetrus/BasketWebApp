using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BasketApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasketApp.Controllers
{
    public class PlayerController : Controller
    {

        private ApplicationDbContext _context;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context"></param>
        public PlayerController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Przejście do strony z listą wszystkich zawodników posortowanych  alfabetycznie
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            //Iteracja w celu wczytania danych, gdy tego nie zrobimy dostaniemy błąd
            _context.Positions.ToList();
            _context.Teams.ToList();

            var players = _context.Players.ToList();

            //Sortowanie po nazwie
            var playersSorted = players.OrderBy(p => p.Name).ToList();


            return View(playersSorted);
        }

        /// <summary>
        /// Przejście do strony z przeglądem informacji o zawodniku
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PlayerView(int Id)
        {

            var player = _context.Players.SingleOrDefault(p =>p.Id == Id);

            //Iteracja w celu wczytania danych, gdy tego nie zrobimy dostaniemy błąd
            _context.Positions.SingleOrDefault(p => p.Id == player.PositionId);
            _context.Teams.SingleOrDefault(t => t.Id == player.TeamId);

            return View(player);
        }



        /// <summary>
        /// Przejście do strony z formularzem do dodawania zawodników
        /// </summary>
        /// <returns></returns>
        public IActionResult AddPlayer()
        { 

            //Dane zapisane w ViewBagu w celu późniejszego wyświetlenia ich w liście wyboru
            //Lepszym rozwiązaniem byłoby zastosowanie ViewModelu, jednak w treści zadania
            //Założone było użycie ViewBagów, stąd to rozwiązanie
            ViewBag.Positions = _context.Positions.ToList();
            ViewBag.Teams = _context.Teams.ToList();


            

            return View();
        }

        /// <summary>
        /// Metoda dodająca zawodnika do bazy i zapsująca zmiany
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Player player)
        {
            ViewBag.Positions = _context.Positions.ToList();
            ViewBag.Teams = _context.Teams.ToList();


            //Walidacja wprowadzonych danych
            if (!ModelState.IsValid)
            {
                return View("AddPlayer");
            }

            //Dodanie zawodnika do bazy lokalnej
            _context.Players.Add(player);
            //Zapisanie zawodnika w bazie danych
            _context.SaveChanges();

            return RedirectToAction("PlayerView", "Player", new {Id = player.Id});
        }


        /// <summary>
        /// Przekierowuje na dany adres
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GoToLink(string url)
        {
            return Redirect(url);
        }

    }
}