namespace TAFEEnrollmentSystem.Model
{
    public class Address
    {
        // Default values used when no address information is provided.

        private const string DEFAULT_STREETNUM = "No street number provided";
        private const string DEFAULT_STREETNAME = "No street name provided";
        private const string DEFAULT_SUBURB = "No suburb provided";
        private const string DEFAULT_POSTCODE = "No postcode provided";
        private const string DEFAULT_STATE = "No state provided";

        // Street number of the address
        public string StreetNum { get; set; }

        // Street name
        public string StreetName { get; set; }

        // Suburb of the address
        public string Suburb { get; set; }

        // Postcode of the address
        public string Postcode { get; set; }

        // State where the address is located
        public string State { get; set; }


        // Default constructor
        public Address() : this(DEFAULT_STREETNUM, DEFAULT_STREETNAME, DEFAULT_SUBURB, DEFAULT_POSTCODE, DEFAULT_STATE)
        {

        }

        // Constructor with parameters
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // Returns address information as a string
        public override string ToString()
        {
            return 
            "Street Number: " + StreetNum + 
            ", Street Name: " + StreetName + 
            ", Suburb: " + Suburb + 
            ", State: " + State + 
            ", Postcode: " + Postcode;
        }
    }
}