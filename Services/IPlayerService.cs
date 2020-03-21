using System.Collections.Generic;
using BasketApp.Models;
using BasketApp.Mapping;

namespace BasketApp.Services
{
    public interface IPlayerService
    {

        public void LoadDb(ApplicationDbContext context);

        /// <summary>
        /// Zwraca listę wszystkich zawodników
        /// </summary>
        /// <returns></returns>
        List<Player> Get();

        /// <summary>
        /// Zwraca pojedynczego zawodnika o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Player GetPlayer(int id);

        /// <summary>
        /// Metoda do dodawania nowego zawodnika
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        bool Post(Player player);

        /// <summary>
        /// Metoda do edytowania istniejącego zawodnika
        /// </summary>
        /// <param name="player"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Put(Player player, int id);

        /// <summary>
        /// Metoda do usuwania zawodnika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}