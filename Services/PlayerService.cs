using System;
using System.Collections.Generic;
using System.Linq;
using BasketApp.Models;

namespace BasketApp.Services
{
    public class PlayerService : IPlayerService
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

        /// <summary>
        /// Zwraca listę wszystkich zawodników
        /// </summary>
        /// <returns></returns>
        public List<Player> Get()
        {
            //iteruje żeby wczytać dane
            _context.Positions.ToList();
            _context.Teams.ToList();

            return _context.Players.ToList();

        }
        /// <summary>
        /// Zwraca pojedynczego zawodnika o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Player GetPlayer(int id)
        {
            //iteruje żeby wczytać dane
            _context.Positions.ToList();
            _context.Teams.ToList();

            var player = _context.Players.SingleOrDefault(p => p.Id.Equals(id));

            return player;
        }
        /// <summary>
        /// Metoda do dodawania nowego zawodnika
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool Post(Player player)
        {
            _context.Players.Add(player);

            _context.SaveChanges();

            return true;
        }
        /// <summary>
        /// Metoda do edytowania istniejącego zawodnika
        /// </summary>
        /// <param name="player"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(Player player, int id)
        {
            var playerToUpdate = _context.Players.SingleOrDefault(p => p.Id.Equals(id));

            if (playerToUpdate == null)
                return false;

            if (player.FirstName != null)
                playerToUpdate.FirstName = player.FirstName;
            if (player.LastName != null)
                playerToUpdate.LastName = player.LastName;
            if (player.ImgUrl != null)
                playerToUpdate.ImgUrl = player.ImgUrl;
            if (player.StatsUrl != null)
                playerToUpdate.StatsUrl = player.StatsUrl;
            //Pola required => nie wymagają sprawdzania
                playerToUpdate.TeamId = player.TeamId;
                playerToUpdate.YearOfBorn = player.YearOfBorn;
                playerToUpdate.PositionId = player.PositionId;

                //zapisanie zmian w bazie danych
                _context.SaveChanges();
            return true;

        }
        /// <summary>
        /// Metoda do usuwania zawodnika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var playerToDelete = _context.Players.SingleOrDefault(p => p.Id.Equals(id));

            if (playerToDelete == null)
            { 
                return false;
            }
            else
            {
                _context.Remove(playerToDelete);
                //zapisanie zmian w bazie danych
                _context.SaveChanges();
            }
            

            return true;
        }


        

    }
}
