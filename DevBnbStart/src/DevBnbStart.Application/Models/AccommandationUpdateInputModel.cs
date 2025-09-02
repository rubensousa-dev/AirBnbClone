

namespace DevBnbStart.Application.Models
{
    public class AccommandationUpdateInputModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxGuests { get; set; }
        public decimal PricePerNight { get; set; }
    }
}
