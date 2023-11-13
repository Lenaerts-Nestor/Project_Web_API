using System.ComponentModel.DataAnnotations;
using WEB_API_PROJ.Entities;

namespace WEB_API_PROJ.VieuwModels
{
    public class HeroCreateVieuwModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public Specialication Specialisation { get; set; }

        public Race Race { get; set; }
    }
}
