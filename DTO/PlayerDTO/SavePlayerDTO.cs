using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApp.Mapping
{
    public class SavePlayerDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public int TeamId { get; set; }

        public int PositionId { get; set; }

        public int YearOfBorn { get; set; }

        public string ImgUrl { get; set; }

        public string StatsUrl { get; set; }

    }
}
