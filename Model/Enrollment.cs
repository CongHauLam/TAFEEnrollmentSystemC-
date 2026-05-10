namespace TAFEEnrollmentSystem.Model
{
    public class Enrollment
    {
        // Default values
        private static readonly DateTime DEFAULT_DATEENROLLED = DateTime.Now;
        private const string DEFAULT_GRADE = "No grade provided";
        private const string DEFAULT_SEMESTER = "No semester provided";

        // Date when the student enrolled in the subject
        public DateTime DateEnrolled { get; set; }

        // Grade received for the subject
        public string Grade { get; set; }

        // Semester of the enrollment
        public string Semester { get; set; }


        // Subject that the student enrolled in
        public Subject Subject { get; set; }


        // Default constructor
        public Enrollment() : this(DEFAULT_DATEENROLLED, DEFAULT_GRADE, DEFAULT_SEMESTER, new Subject())
        {

        }

        // Constructor with parameters
        public Enrollment(DateTime dateEnrolled, string grade, string semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        // Returns enrollment information as a string
        public override string ToString()
        {
            return 
            "\nDate Enrolled: " + DateEnrolled +
            "\nGrade: " + Grade +
            "\nSemester: " + Semester +
            "\n" + Subject;
        }
    }
}