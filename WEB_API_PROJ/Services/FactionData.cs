using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.Services
{
    public class FactionData : IFactionData
    {
        private static List<Faction> _factions = new List<Faction>
        {
        new Faction { Id = 1, Continent = Continent.Kalimdor, Factions = Factions.Horde },
        new Faction { Id = 2, Continent = Continent.Eastern_Kingdoms, Factions = Factions.Aliance },
        new Faction { Id = 3, Continent = Continent.Northrend, Factions = Factions.Neutral }
        };

        public IEnumerable<Faction> GetAllFactions()
        {
            return _factions;
        }

        public Faction GetFactionById(int id)
        {
            return _factions.Find(faction => faction.Id == id);
        }

        public void CreateFaction(Faction newfaction)
        {
            _factions.Add(newfaction);
        }

        public void UpdateFaction(Faction faction)
        {
            var factionToUpdate = _factions.Find(faction => faction.Id == faction.Id);

            if (factionToUpdate != null)
            {
                factionToUpdate.Continent = faction.Continent;
                factionToUpdate.Factions = faction.Factions;
            }
        }

        public void DeleteFaction(int id)
        {
            var factionToDelete = _factions.Find(faction => faction.Id == id);

            if (factionToDelete != null)
            {
                _factions.Remove(factionToDelete);
            }
        }
    }
}
