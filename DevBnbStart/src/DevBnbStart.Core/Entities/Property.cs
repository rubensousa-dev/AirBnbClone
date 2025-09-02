using DevBnbStart.Core.Enums;
using DevBnbStart.Core.ValueObjects;

namespace DevBnbStart.Core.Entities
{
    public class Property : BaseEntities
    {
        public Property(string title, string description,
            Address address, Guid idHost) : base()
        {
            Title = title;
            Description = description;
            Address = address;
            IdHost = idHost;
            Status = PropertyStatus.Inactive;
            Accomodations = [];
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public Guid IdHost { get; set; }
        public Host Host { get; set; }
        public PropertyStatus Status { get; set; }
        public decimal AverageScore { get; set; } // only updates when as a new value
        public string CancellationPolicy { get; set; }
        public List<Accomodation> Accomodations { get; set; }
        
    }
}
