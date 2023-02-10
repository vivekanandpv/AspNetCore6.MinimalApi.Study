namespace AspNetCore6.MinimalApi.Study.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public List<Contact> Contacts { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}{Environment.NewLine}{City}{Environment.NewLine}{Contacts[0].Email}";
        }
    }

    public class Contact
    {
        public string Email { get; set; }
    }
}
