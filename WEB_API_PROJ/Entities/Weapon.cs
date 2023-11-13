namespace WEB_API_PROJ.Entities
{
    public enum Type { Sword, Shield, Mace, Bow, Breath, Fist }
    public enum Grade { Normal, Advance, Special, Epic, Mythic }
    public class Weapon
    {

        public int Id { get; set; }
        public Type Type { get; set; }
        public Grade Grade { get; set; }
        public double Durability { get; set; }


    }
}
