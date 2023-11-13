using Microsoft.AspNetCore.Mvc;
using WEB_API_PROJ.Entities;
using WEB_API_PROJ.Services;
using WEB_API_PROJ.VieuwModels;

namespace WEB_API_PROJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactionController: Controller
    {
        private readonly IFactionData _factionService;

        public FactionController(IFactionData factionService)
        {
            _factionService = factionService;
        }

        // GET: api/factions
        [HttpGet]
        [Route("api/factions")]
        public IActionResult GetAllFactions()
        {
            var factions = _factionService.GetAllFactions();
            return Ok(factions);
        }

        // GET: api/factions/id
        [HttpGet]
        [Route("api/factions/{id}")]
        public IActionResult GetFactionById(int id)
        {
            var faction = _factionService.GetFactionById(id);

            if (faction == null)
            {
                return NotFound();
            }

            return Ok(faction);
        }

        // POST: api/factions
        [HttpPost]
        [Route("api/factions")]
        public IActionResult CreateFaction([FromBody] FactionCreateViewModel faction)
        {
            //TODO: TESTEN DE CREATE FACTION ! 
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newfaction = new Faction
            {
                Continent = faction.Continent,
                Factions = faction.Factions
            };

            _factionService.CreateFaction(newfaction);

            return CreatedAtAction(nameof(GetFactionById), new { id = newfaction.Id }, newfaction);
        }

        // PUT: api/factions/id
        [HttpPut]
        [Route("api/factions/{id}")]
        public IActionResult UpdateFaction(int id, [FromBody] Faction faction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var factionToUpdate = _factionService.GetFactionById(id);

            if (factionToUpdate == null)
            {
                return NotFound();
            }

            factionToUpdate.Continent = faction.Continent;
            factionToUpdate.Factions = faction.Factions;

            _factionService.UpdateFaction(factionToUpdate);

            return NoContent();
        }

        // DELETE: api/factions/id
        [HttpDelete]
        [Route("api/factions/{id}")]
        public IActionResult DeleteFaction(int id)
        {
            var factionToDelete = _factionService.GetFactionById(id);

            if (factionToDelete == null)
            {
                return NotFound();
            }

            _factionService.DeleteFaction(id);

            return NoContent();
        }
    }
}
