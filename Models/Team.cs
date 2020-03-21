using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApp.Models
{

    /// <summary>
    /// Tabela przechowująca informację o drużynie
    /// </summary>
    public class Team
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Nazwa drużyny")]
        public string Name { get; set; }


        [DisplayName("Zawodnicy")]
        public List<Player> Players { get; set; }


        [Required]
        [DisplayName("Lokalizacja klubu")]
        public string Location { get; set; }


        [DisplayName("Link do logo")]
        public string LogoUrl { get; set; }



    }
}