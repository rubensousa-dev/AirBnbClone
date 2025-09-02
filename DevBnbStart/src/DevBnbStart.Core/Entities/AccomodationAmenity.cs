namespace DevBnbStart.Core.Entities
{
    public class AccomodationAmenity : BaseEntities
    {
        public AccomodationAmenity(Guid idAccomodation, Guid idAmenity, int quantity) : base()
        {
            IdAccomodation = idAccomodation;
            IdAmenity = idAmenity;
            Quantity = quantity;
        }

        public Guid IdAccomodation { get; set; }
        public Guid IdAmenity{ get; set; }
        public int Quantity { get; set; }
    }
}
