using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApp.Models
{
    /// <summary>
    /// Tabela przechowująca dane zawodnika
    /// </summary>
    public class Player
    {
        public int Id { get; set; }



        [DisplayName("Link do zdjęcia")]
        public string ImgUrl { get; set; }


        [DisplayName("Link do statystyk")]
        public string StatsUrl { get; set; }


        [DisplayName("Drużyna")]
        public Team Team { get; set; }

        [DisplayName("Drużyna")]
        public int TeamId { get; set; }


        [DisplayName("Pozycja")]
        public Position Position { get; set; }

        [Required]
        [DisplayName("Pozycja")]
        public int PositionId { get; set; }

        [DisplayName("Imię")]
        [StringLength(30)]
        [Required]
        public string FirstName { get; set; }


        [DisplayName("Nazwisko")]
        [StringLength(30)]
        [Required]
        public string LastName { get; set; }

        
        [DisplayName("Rok urodzenia")]
        public int YearOfBorn { get; set; }

        public string Name
        {
            get { return FirstName + " " + LastName; }
        }  
        public int Age
        {
            get { return (DateTime.Now.Year - YearOfBorn); }
        }




    }
}