namespace TAFEEnrollmentSystem.Model
{
    public class Subject
    {
        // Default values when no subject information is provided
        private const string DEFAULT_CODE = "No subject code provided";
        private const string DEFAULT_NAME = "No subject name provided";
        private const double DEFAULT_COST = 0.0;

        // Code that identifies the subject
        public string SubjectCode { get; set; }
        // Name of the subject
        public string SubjectName { get; set; }
        // Cost of the subject
        public double Cost { get; set; }


        // Default constructor
        public Subject() :this(DEFAULT_CODE, DEFAULT_NAME, DEFAULT_COST)
        {

        }

        // Constructor with parameters
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        // Returns subject information as a string
        public override string ToString()
        {
                return 
            "Subject Code: " + SubjectCode +
            "\nSubject Name: " + SubjectName +
            "\nCost: " + Cost;
        }
    }
}