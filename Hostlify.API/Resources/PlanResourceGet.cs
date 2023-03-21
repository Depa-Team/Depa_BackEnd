using System.ComponentModel.DataAnnotations;


namespace Hostlify.API.Resources
{
    public class PlanResourceGet
    {
        [Required]
        public int id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        public int Rooms { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
