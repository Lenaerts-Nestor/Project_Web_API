using Microsoft.AspNetCore.Mvc;
using WEB_API_PROJ.Entities;
using WEB_API_PROJ.Services;
using WEB_API_PROJ.VieuwModels;

namespace WEB_API_PROJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //opletten op de naam, ik heb het veranderd van herocontroller naar => HeroesController
    public class HeroesController : Controller
    {
        private readonly IHeroData _heroData;

        public HeroesController(IHeroData heroData)
        {
            this._heroData = heroData;
        }

        // GET: api/Hero
        [HttpGet]
        public IActionResult GetAll()
        {
            var heroes = _heroData.GetAll();

            return Ok(heroes);
        }

        // GET: api/Hero/1
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var hero = _heroData.Get(id);

            if (hero == null)
            {
                return NotFound();
            }

            return Ok(hero);
        }

        // POST: api/Hero
        [HttpPost]
        public IActionResult Add([FromBody] HeroCreateVieuwModel hero)
        {
            //TODO: TESTEN DE ADD METHOD !! 
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newHero = new Hero
            {
                FirstName = hero.FirstName,
                LastName = hero.LastName,
                Age = hero.Age,
                Specialication = hero.Specialisation,
                Race = hero.Race
            };

            newHero = _heroData.Add(newHero);

            return CreatedAtAction(nameof(Get), new { id = newHero.Id }, newHero);
        }

        // PUT: api/Hero/1
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Hero hero)
        {
            if (id != hero.Id)
            {
                return BadRequest();
            }

            _heroData.Update(hero);

            return NoContent();
        }

        // DELETE: api/Hero/1
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _heroData.Delete(id);

            return NoContent();
        }
    }
}
