namespace DevBnbStart.Core.Entities
{
    public class Accomodation : BaseEntity
    {
        public Accomodation() { }
        public Accomodation(string name, string description, int maxGuests,
            decimal pricePerNight, Guid idProperty) : base()
        {
            Name = name;
            Description = description;
            MaxGuests = maxGuests;
            PricePerNight = pricePerNight;
            IdProperty = idProperty;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxGuests { get; set; }
        public decimal PricePerNight { get; set; }
        public Guid IdProperty { get; set; }
        public Property Property { get; set; }
        public ICollection<AccomodationAmenity> Amenities { get; set; }

        public void UpdateInfo(string name, string description, int maxGuest, decimal priceByNight)
        {
            Name = name;
            Description = description;
            MaxGuests = maxGuest;
            PricePerNight = priceByNight;
        }
    }
}
