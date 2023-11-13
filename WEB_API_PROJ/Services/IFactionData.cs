using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.Services
{
    public interface IFactionData
    {
        IEnumerable<Faction> GetAllFactions();
        Faction GetFactionById(int id);
        void CreateFaction(Faction faction);
        void UpdateFaction(Faction faction);
        void DeleteFaction(int id);
    }
}
