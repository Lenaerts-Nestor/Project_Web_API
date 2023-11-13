namespace WEB_API_PROJ.Entities
{

    public enum Continent { Kalimdor, Northrend, Eastern_Kingdoms }
    public enum Factions { Horde, Aliance, Neutral }
    public class Faction
    {

        public int Id { get; set; }
        public Continent Continent { get; set; }
        public Factions Factions { get; set; }


    }
}
