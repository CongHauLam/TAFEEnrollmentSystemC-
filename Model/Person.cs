namespace TAFEEnrollmentSystem.Model
{
    public class Person
    {
        // Default values when no information is provided
        public const string DEFAULT_NAME = "No name provided";
        public const string DEFAULT_EMAIL = "No email provided";
        public const string DEFAULT_PHONE = "No phone number provided";

        // Person's full name
        public string Name { get; set; }

        // Person's email address
        public string Email { get; set; }

        // Person's phone number
        public string PhoneNumber { get; set; }

        // Address of the person
        public Address Address { get; set; }


        // Default constructor
        public Person() : this(DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE, new Address())
        {

        }

        // Constructor with parameters
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // Returns person information as a string
        public override string ToString()
        {
                return 
            "Name: " + Name +
            "\nEmail: " + Email +
            "\nPhone Number: " + PhoneNumber +
            "\nAddress: " + Address;
        }
    }
}