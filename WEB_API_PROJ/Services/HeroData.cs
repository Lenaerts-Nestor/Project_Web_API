using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.Services
{
    public class HeroData : IHeroData
    {
        static List<Hero> _heroes;

        static HeroData()
        {
            _heroes = new List<Hero>
            {
                new Hero
                 {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 30,
                    Race = Race.Humans,
                    Specialication = Specialication.Warrior
                 },
                new Hero
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Age = 25,
                    Race = Race.Dwarfs,
                    Specialication = Specialication.Priest
                },
                new Hero
                {
                    Id = 3,
                    FirstName = "Peter",
                    LastName = "Smith",
                    Age = 40,
                    Race = Race.Orcs,
                    Specialication = Specialication.Hunter
                },
                new Hero
                {
                    Id = 4,
                    FirstName = "Mary",
                    LastName = "Jones",
                    Age = 35,
                    Race = Race.Elfs,
                    Specialication = Specialication.Shaman
                },
                new Hero
                {
                    Id = 5,
                    FirstName = "Bill",
                    LastName = "Johnson",
                    Age = 20,
                    Race = Race.Trols,
                    Specialication = Specialication.Warrior
                },
                new Hero
                {
                    Id = 6,
                    FirstName = "Susan",
                    LastName = "Williams",
                    Age = 18,
                    Race = Race.Humans,
                    Specialication = Specialication.Priest
                },
                new Hero
                {
                    Id = 7,
                    FirstName = "David",
                    LastName = "Brown",
                    Age = 50,
                    Race = Race.Humans,
                    Specialication = Specialication.Shaman
                }
            };
        }

        public Hero Add(Hero newHero)
        {
            newHero.Id = _heroes.Max(x => x.Id) + 1;
            _heroes.Add(newHero);

            return newHero;
        }

        public void Delete(long id)
        {
            var hero = _heroes.Find(h => h.Id == id);

            if (hero != null)
            {
                _heroes.Remove(hero);
            }
        }

        public Hero Get(long id)
        {
            return _heroes.Find(h => h.Id == id);
        }

        public IEnumerable<Hero> GetAll()
        {
            return _heroes;
        }

        public void Update(Hero newPerson)
        {
            var hero = _heroes.Find(h => h.Id == newPerson.Id);

            if (hero != null)
            {
                hero.FirstName = newPerson.FirstName;
                hero.LastName = newPerson.LastName;
                hero.Age = newPerson.Age;
                hero.Race = newPerson.Race;
                hero.Specialication = newPerson.Specialication;
            }
        }
    }
}
