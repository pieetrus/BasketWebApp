using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApp.Models
{
    /// <summary>
    /// Tabela przechowująca możliwe pozycja na których zawodnik może grać
    /// </summary>
    public class Position
    {
        public int Id { get; set; }


        [Required]
        [DisplayName("Pozycja")]

        public string Name { get; set; }


        [DisplayName("Gracze")]
        public List<Player> Players { get; set; }
    }
}