using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.Services
{
    public interface IWeaponData
    {
        IEnumerable<Weapon> GetAllWeapons();
        Weapon GetWeaponById(int id);
        void CreateWeapon(Weapon weapon);
        void UpdateWeapon(Weapon weapon);
        void DeleteWeapon(int id);
    }
}
