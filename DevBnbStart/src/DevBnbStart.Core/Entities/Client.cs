using DevBnbStart.Core.ValueObjects;

namespace DevBnbStart.Core.Entities
{
    public class Client : BaseUser
    {
        public Client(string observations, string email, 
            string passwordHash, string fullName, string phoneNumber, 
            string document, DateTime dateOfBirth, Address address) 
            : base(email, passwordHash, fullName, phoneNumber, 
                  document, dateOfBirth, address)
        {
            Observations = observations;
        }

        public string Observations { get; set; }

        public void Update(string observations, string fullName, string phoneNumber, Address address)
        {
            Observations = observations;
            base.Update(fullName, phoneNumber, address);
        }
    }
}
