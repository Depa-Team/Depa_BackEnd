using System.ComponentModel.DataAnnotations;

namespace Hostlify.API.Resources
{
    public class HistoryResourceGet
    {
        [Required]
        public int id { get; set; }

        public string flatName { get; set; }
        public int managerId { get; set; }

        public string guestName { get; set; }

        public string initialDate { get; set; }

        public string endDate { get; set; }

        public int price { get; set; }
    }
}
