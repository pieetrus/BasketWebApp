using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BasketApp.Services
{
    public class TeamService : ITeamService
    {

        private ApplicationDbContext _context;


        /// <summary>
        /// Ładowanie bazy danych
        /// </summary>
        /// <param name="context"></param>
        public void LoadDb(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Team> Get()
        {
            //iteruje żeby załadować dane
            _context.Players.ToList();
            return _context.Teams.ToList();
        }

        public Team GetTeam(int id)
        {
            //iteruje żeby załadować dane
            _context.Players.ToList();

            var team = _context.Teams.SingleOrDefault(t => t.Id.Equals(id));

            return team;
        }

        public bool Post(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();

            return true;
        }

        public bool Put(Team team, int id)
        {
            var teamToUpdate = _context.Teams.SingleOrDefault(t => t.Id.Equals(id));

            if (teamToUpdate == null)
            {
                return false;
            }
            else
            {
                if (team.Location !=null)
                    teamToUpdate.Location = team.Location;
                if (team.LogoUrl != null)
                    teamToUpdate.LogoUrl = team.LogoUrl;
                teamToUpdate.Name = team.Name;

                _context.SaveChanges();

                return true;
            }
        }

        public bool Delete(int id)
        {
            var teamToDelete = _context.Teams.SingleOrDefault(t => t.Id.Equals(id));

            if (teamToDelete == null)
            {
                return false;
            }
            else
            {
                _context.Remove(teamToDelete);
                return true;
            }


        }
    }
}
