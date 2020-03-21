using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;

namespace BasketApp.ViewModels
{
    /// <summary>
    /// FormViewModel do przeniesienia danych potrzebnych do wyświetlenia informacji o drużynie
    /// </summary>
    public class TeamFormViewModel
    {

        public Team Team { get; set; }
        public List<Player> Players { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="team"></param>
        /// <param name="players"></param>
        public TeamFormViewModel(Team team, List<Player> players)
        {
            Team = team;
            Players = players;
        }
    }
}
