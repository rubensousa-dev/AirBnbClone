namespace DevBnbStart.Core.Entities
{
    public class AccomodationAmenity : BaseEntity
    {
        public AccomodationAmenity() { }

        public AccomodationAmenity(Guid idAccommodation, Guid idAmenity, int quantity) : base()
        {
            IdAccommodation = idAccommodation;
            IdAmenity = idAmenity;
            Quantity = quantity;
        }

        public Guid IdAccommodation { get; set; }
        public Accomodation Accomodation { get; set; }
        public Guid IdAmenity{ get; set; }
        public Amenity Amenity { get; set; }
        public int Quantity { get; set; }
    }
}
