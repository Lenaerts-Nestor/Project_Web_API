namespace WEB_API_PROJ.Entities
{
    public enum Race { Humans, Dwarfs, Orcs, Elfs, Trols }

    public enum Specialication { Warrior, Priest, Hunter, Shaman };
    public class Hero
    {

        public int Id { get; set; }
        public int Age { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Specialication Specialication { get; set; }
        public Race Race { get; set; }


    }
}
