using DevBnbStart.Core.Enums;

namespace DevBnbStart.Core.Entities
{
    public class Amenity : BaseEntities
    {
        public Amenity(string title, string description, AmenityType amenityType) : base()
        {
            AmenityType = amenityType;
            Title = title;
            Description = description;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public AmenityType AmenityType { get; set; }
 
    }
}
