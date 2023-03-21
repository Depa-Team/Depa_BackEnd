using System.ComponentModel.DataAnnotations;

namespace Hostlify.API.Resources
{
    public class FlatResource
    {

        [Microsoft.Build.Framework.Required]
        [MaxLength(15)]
        public string flatName { get; set; }
        [Microsoft.Build.Framework.Required]
        public int ManagerId { get; set; }

    }
}
