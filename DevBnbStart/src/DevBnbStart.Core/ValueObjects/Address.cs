namespace DevBnbStart.Core.ValueObjects
{
    public record Address (string Street, string Number, 
        string Neighborhood, string City, string State, string Country, string ZipCode)
    {
        public override string ToString()
        {
            return $"{Street}, {Number}, {Neighborhood}, {City}, {State}, {Country}, {ZipCode}";
        }
    }
}
