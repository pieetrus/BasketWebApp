using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;

namespace BasketApp.DTO.TeamDTO
{
    public class SaveTeamDTO
    {

        public string Name { get; set; }

        public string Location { get; set; }

        public string LogoUrl { get; set; }
    }
}
