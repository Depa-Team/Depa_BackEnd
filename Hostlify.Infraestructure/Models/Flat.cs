using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostlify.Infraestructure.Models
{
    public class Flat : BaseModel
    {
        public int Id { get; set; }
        public string flatName { get; set; }
        public int? GuestId { get; set; }
        public int ManagerId { get; set; }
        public string? Initialdate { get; set; }
        public string? EndDate { get; set; }
        public bool Status { get; set; }
        public int? Price { get; set; }
    }
}
