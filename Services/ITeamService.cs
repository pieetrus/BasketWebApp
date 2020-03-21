using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;

namespace BasketApp.Services
{
    public interface ITeamService
    {
        public void LoadDb(ApplicationDbContext context);

        List<Team> Get();
        Team GetTeam(int id);
        bool Post(Team team);
        bool Put(Team team, int id);
        bool Delete(int id);



    }
}
