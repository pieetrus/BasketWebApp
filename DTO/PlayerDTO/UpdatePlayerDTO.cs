using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BasketApp.Models;

namespace BasketApp.DTO
{
    public class UpdatePlayerDTO
    {

        public int Id { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int TeamId { get; set; }


        public int PositionId { get; set; }


        public int YearOfBorn { get; set; }

        public string ImgUrl { get; set; }


        public string StatsUrl { get; set; }
    }
}
