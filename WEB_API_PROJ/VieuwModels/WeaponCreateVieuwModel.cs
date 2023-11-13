using System.ComponentModel.DataAnnotations;
using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.VieuwModels
{
    public class WeaponCreateVieuwModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Damage { get; set; }
        [Required]
        public WeaponType WeaponType { get; set; }
    }
}
