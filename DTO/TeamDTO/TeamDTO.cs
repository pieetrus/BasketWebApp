using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;

namespace BasketApp.DTO.TeamDTO
{
    public class TeamDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

       // public virtual List<Player> Players { get; set; }

        public string Location { get; set; }

        public string LogoUrl { get; set; }
    }
}
