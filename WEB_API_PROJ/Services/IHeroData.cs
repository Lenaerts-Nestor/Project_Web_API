using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.Services
{
    public interface IHeroData
    {
        IEnumerable<Hero> GetAll();
        Hero Get(long id);
        Hero Add(Hero newPerson);
        void Delete(long id);
        void Update(Hero newPerson);

    }
}
