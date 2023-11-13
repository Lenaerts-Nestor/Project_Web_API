namespace WEB_API_PROJ.Entities
{
    public enum WeaponType { Melee, Ranged, Magic }
    public class Weapon
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public WeaponType WeaponType { get; set; }


    }
}
