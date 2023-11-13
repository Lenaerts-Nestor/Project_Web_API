using Microsoft.AspNetCore.Mvc;
using WEB_API_PROJ.Entities;
using WEB_API_PROJ.Services;
using WEB_API_PROJ.VieuwModels;

namespace WEB_API_PROJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController : Controller
    {
        private readonly IWeaponData _weaponService;

        public WeaponController(IWeaponData weaponService)
        {
            _weaponService = weaponService;
        }

        // GET: api/weapons
        [HttpGet]
        [Route("api/weapons")]
        public IActionResult GetAllWeapons()
        {
            var weapons = _weaponService.GetAllWeapons();
            return Ok(weapons);
        }

        // GET: api/weapons/id
        [HttpGet]
        [Route("api/weapons/{id}")]
        public IActionResult GetWeaponById(int id)
        {
            var weapon = _weaponService.GetWeaponById(id);

            if (weapon == null)
            {
                return NotFound();
            }

            return Ok(weapon);
        }

        // POST: api/weapons
        [HttpPost]
        [Route("api/weapons")]
        public IActionResult CreateWeapon([FromBody] WeaponCreateVieuwModel weapon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newWeapon = new Weapon
            {
                WeaponType = weapon.WeaponType,
                Name = weapon.Name,
                Damage = weapon.Damage,
                
                
            };
            _weaponService.CreateWeapon(newWeapon);

            return CreatedAtAction(nameof(GetWeaponById), new { id = newWeapon.Id }, newWeapon);
        }

        // PUT: api/weapons/id
        [HttpPut]
        [Route("api/weapons/{id}")]
        public IActionResult UpdateWeapon(int id, [FromBody] Weapon weapon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var weaponToUpdate = _weaponService.GetWeaponById(id);

            if (weaponToUpdate == null)
            {
                return NotFound();
            }

            weaponToUpdate.Name = weapon.Name;
            weaponToUpdate.Damage = weapon.Damage;
            weaponToUpdate.WeaponType = weapon.WeaponType;

            _weaponService.UpdateWeapon(weaponToUpdate);

            return NoContent();
        }

        // DELETE: api/weapons/id
        [HttpDelete]
        [Route("api/weapons/{id}")]
        public IActionResult DeleteWeapon(int id)
        {
            var weaponToDelete = _weaponService.GetWeaponById(id);

            if (weaponToDelete == null)
            {
                return NotFound();
            }

            _weaponService.DeleteWeapon(id);

            return NoContent();
        }
    }
}
