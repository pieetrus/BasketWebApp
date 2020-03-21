using System.Collections.Generic;
using AutoMapper;
using BasketApp.DTO;
using BasketApp.Mapping;
using BasketApp.Models;
using BasketApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasketApp.Controllers.API
{

    //ścieżka pod jaką znajduje się strona
    [Route("api/player")]
    [ApiController]
    public class PlayerControllerAPI : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="playerService"></param>
        public PlayerControllerAPI(ApplicationDbContext context, IPlayerService playerService, IMapper mapper)
        {
            //Dependency Injection
            _playerService = playerService;
            _mapper = mapper;

            _playerService.LoadDb(context);
        }


        /// <summary>
        /// Metoda Get do wyświetlania wszystkich zawodników
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var players = _playerService.Get();

            var mappedPlayers = _mapper.Map<IEnumerable<Player>, IEnumerable<PlayerDTO>>(players);


            return Ok(mappedPlayers);
        }

        /// <summary>
        /// Metoda Get do wyświetlania danych zawodnika o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetPlayer([FromRoute] int id)
        {
            var player = _playerService.GetPlayer(id);

            var mappedPlayer = _mapper.Map<Player, PlayerDTO>(player);

            return Ok(mappedPlayer);
        }

        /// <summary>
        /// Metoda Post do dodawania zawodnika
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] SavePlayerDTO player)
        {
            var playerMapped = _mapper.Map<SavePlayerDTO, Player>(player);

            if (_playerService.Post(playerMapped))
            {
                return Ok("Dodano!");
            }
            else
            {
                return Conflict("Nie można dodać zawodnika!");
            }
        }
        /// <summary>
        /// Metoda Put do edycji zawodnika
        /// </summary>
        /// <param name="player"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody]UpdatePlayerDTO player, [FromRoute] int id)
        {
            var playerMapped = _mapper.Map<UpdatePlayerDTO, Player>(player);

                if (_playerService.Put(playerMapped, id))
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
        }

        /// <summary>
        /// Metoda Delete do usuwania zawodnika
        /// </summary>
        /// <param name="player"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {

                var isUpdateSuccesfull = _playerService.Delete(id);

                if (isUpdateSuccesfull)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
        }

    }
}
