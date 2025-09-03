using DevBnbStart.Core.ValueObjects;

namespace DevBnbStart.Core.Entities
{
    public class Host : BaseUser
    {
        public Host() { }
        public Host(string bio, string bankData, string email, string passwordHash, 
            string fullName, string phoneNumber, string document
            , DateTime dateOfBirth, Address address) 
            : base(email, passwordHash, fullName, phoneNumber, 
                  document, dateOfBirth, address)
        {
            Bio = bio;
            BankData = bankData;
            
        }

        public string Bio { get; set; }
        public string BankData { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}
