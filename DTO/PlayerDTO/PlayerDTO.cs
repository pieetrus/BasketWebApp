using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;

namespace BasketApp.DTO
{
    public class PlayerDTO
    {
        
        public int Id { get; set; }

        public string Team { get; set; }

        public int TeamId { get; set; }

        public string Position { get; set; } 
        
        public int PositionId { get; set; }


        public string ImgUrl { get; set; }


        public string StatsUrl { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

    }
}
