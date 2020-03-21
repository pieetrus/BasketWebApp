using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;
using BasketApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BasketApp.Controllers
{
    public class TeamController : Controller
    {

        private ApplicationDbContext _context;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context"></param>
        public TeamController(ApplicationDbContext context)
        {
            _context = context;

        }

        /// <summary>
        /// Akcja prowadząca do przejścia do strony z listą drużyn posortowanych alfabetycznie
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            //Iteracja w celu wczczytania danych, jeżeli tego nie zrobimy dostaniemy błąd
            _context.Players.ToList();
            _context.Positions.ToList();

            var teams = _context.Teams.ToList();
            //Sortowanie drużyn po nazwie
            var teamsSorted = teams.OrderBy(t => t.Name).ToList();

            return View(teamsSorted);
        }

        /// <summary>
        /// Przejście do strony z widokiem informacji o drużynie
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult TeamView(int id)
        {
            //Znalezienie drużyny wybranej przez użytkownika
            var team = _context.Teams.SingleOrDefault(t => t.Id == id);
            //Znalezienie graczy należącej do danej drużyny
            var players = _context.Players.Where(p => p.TeamId == team.Id).ToList();
            _context.Positions.ToList();

            var viewModel = new TeamFormViewModel(team, players);


            return View(viewModel);
        }

        

        /// <summary>
        /// Znajduje w mapach google lokalizację miasta gdzie znajduje się klub
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GoogleLocation(string location)
        {
            var parameters = location.Replace(' ', '+');

            string url = "https://www.google.com/maps/search/?api=1&query=" + parameters;

            return Redirect(url);
        }


        
        /// <summary>
        /// Zwraca widok formularza dodawania drużyn
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddTeam()
        {

            return View();
        }

        /// <summary>
        /// Metoda dodająca drużynę do bazy i zapisuje zmiany
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Team team)
        {

            if (!ModelState.IsValid)
            {
                return View("AddTeam");
            }


            _context.Teams.Add(team);
            _context.SaveChanges();

            return RedirectToAction("AddTeam","TeamController");
        }


    }
}