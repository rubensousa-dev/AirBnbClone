using DevBnbStart.Core.Entities;


namespace DevBnbStart.Infrastructure.Persistence
{
    public class AppDbContext
    {
        public AppDbContext()
        {
            Hosts = [];
            Clients = [];
            Properties = [];
            Accomodations = [];
            Amenities = [];
        }
        public List<Host> Hosts { get; set; }
        public List<Client> Clients { get; set; }
        public List<Property> Properties { get; set; }
        public List<Accomodation> Accomodations { get; set; }
        public List<Amenity> Amenities { get; set; }
        public void SaveChanges(){}
    
    }
}
