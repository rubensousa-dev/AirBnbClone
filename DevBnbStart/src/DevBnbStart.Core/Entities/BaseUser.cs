using DevBnbStart.Core.ValueObjects;

namespace DevBnbStart.Core.Entities
{
    public abstract class BaseUser : BaseEntity
    {

        protected BaseUser(){}
        protected BaseUser(string email, string passwordHash, 
            string fullName, string phoneNumber
            , string document, DateTime dateOfBirth, Address address) : base()
        {
            Email = email;
            PasswordHash = passwordHash;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Document = document;
            DateOfBirth = dateOfBirth;
            Address = address;
        }

        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Document { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }

        public void Update(string fullName, string phoneNumber, Address address)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
