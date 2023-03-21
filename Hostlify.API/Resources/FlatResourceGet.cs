namespace Hostlify.API.Resources
{
    public class FlatResourceGet
    {
        public int Id { get; set; }
        public string flatName { get; set; }
        public int managerId { get; set; }
        public int GuestId { get; set; }
        public string InitialDate { get; set; }
        public string EndDate { get; set; }

        public bool Status { get; set; }
        public int Price { get; set; }
    }
}
