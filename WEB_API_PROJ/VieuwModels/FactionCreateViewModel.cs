using System.ComponentModel.DataAnnotations;
using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.VieuwModels
{
    public class FactionCreateViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Continent Continent { get; set; }

        [Required]
        public Factions Factions { get; set; }
    }
}
