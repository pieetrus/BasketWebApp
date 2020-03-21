using System.Collections.Generic;
using AutoMapper;
using BasketApp.DTO.TeamDTO;
using BasketApp.Models;
using BasketApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasketApp.Controllers.API
{
    [Route("api/team")]
    [ApiController]
    public class TeamControllerAPI : ControllerBase
    {

        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Konstruktor z dependency injection oraz ładowanie contextu bazy danych
        /// </summary>
        /// <param name="context"></param>
        /// <param name="teamService"></param>
        /// <param name="mapper"></param>
        public TeamControllerAPI(ApplicationDbContext context, ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _teamService.LoadDb(context);
            _mapper = mapper;
        }
        /// <summary>
        /// Metoda Get zwracająca listę wszystkich drużyn wraz z informacjami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var teams = _teamService.Get();
            var teamsMapped =_mapper.Map<IEnumerable<Team>, IEnumerable<TeamDTO>>(teams);

            return Ok(teamsMapped);
        }
        /// <summary>
        /// Metoda zwracająca informacje o drużynie o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetTeam([FromRoute] int id)
        {
            var team = _teamService.GetTeam(id);

            var teamMapped = _mapper.Map<Team, TeamDTO>(team);

            return Ok(teamMapped);
        }
        /// <summary>
        /// Metoda do dodania nowej drużyny
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] SaveTeamDTO team)
        {
            var teamMapped = _mapper.Map<SaveTeamDTO, Team>(team);

            if (_teamService.Post(teamMapped))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        /// <summary>
        /// Metoda do edycji drużyny o podanym Id
        /// </summary>
        /// <param name="team"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] UpdateTeamDTO team, [FromRoute] int id)
        {
            var teamMapped = _mapper.Map<UpdateTeamDTO, Team>(team);

            if (_teamService.Post(teamMapped))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        /// <summary>
        /// Metoda do usuwania drużyny o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            if (_teamService.Delete(id))
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