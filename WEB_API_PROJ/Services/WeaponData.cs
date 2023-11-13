using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.Services
{
    public class WeaponData : IWeaponData
    {
        private static List<Weapon> _weapons = new List<Weapon>
    {
        new Weapon { Id = 1, Name = "Sword", Damage = 10, WeaponType = WeaponType.Melee },
        new Weapon { Id = 2, Name = "Bow", Damage = 5, WeaponType = WeaponType.Ranged },
        new Weapon { Id = 3, Name = "Staff", Damage = 3, WeaponType = WeaponType.Magic }
    };

        public IEnumerable<Weapon> GetAllWeapons()
        {
            return _weapons;
        }

        public Weapon GetWeaponById(int id)
        {
            return _weapons.Find(weapon => weapon.Id == id);
        }

        public void CreateWeapon(Weapon newweapon)
        {
            newweapon.Id = _weapons.Max(x => x.Id) + 1;
            _weapons.Add(newweapon);
        }

        public void UpdateWeapon(Weapon weapon)
        {
            var weaponToUpdate = _weapons.Find(weapon => weapon.Id == weapon.Id);

            if (weaponToUpdate != null)
            {
                weaponToUpdate.Name = weapon.Name;
                weaponToUpdate.Damage = weapon.Damage;
                weaponToUpdate.WeaponType = weapon.WeaponType;
            }
        }

        public void DeleteWeapon(int id)
        {
            var weaponToDelete = _weapons.Find(weapon => weapon.Id == id);

            if (weaponToDelete != null)
            {
                _weapons.Remove(weaponToDelete);
            }
        }
    }
}
