namespace TAFEEnrollmentSystem.Model
{
    public class Student : Person, IComparable<Student>
    {
        // Default values when no information is provided
        private const string DEFAULT_ID = "No student ID provided";
        private const string DEFAULT_PROGRAM = "No program provided";
        private static readonly DateTime DEFAULT_DATEREGISTER = DateTime.Now;

        // Unique ID of the student
        public string StudentID { get; set; }

        // Program that the student is enrolled in
        public string Program { get; set; }

        // Date when the student registered
        public DateTime DateRegister { get; set; }

        public Enrollment Enrollment { get; set; }


        // Default constructor
        public Student() : this(DEFAULT_ID, DEFAULT_PROGRAM, DEFAULT_DATEREGISTER, DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE, new Address(), new Enrollment())
        {

        }

        // Constructor with StudentID only
        public Student(string studentID) : this(studentID, DEFAULT_PROGRAM, DEFAULT_DATEREGISTER, DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE, new Address(), new Enrollment())
        {

        }

        // Constructor with all properties
        public Student(string studentID, string program, DateTime dateRegister,string name, string email, string phoneNumber, Address address, Enrollment enrollment)
            : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegister = dateRegister;
            Enrollment = enrollment;
        }

        // Returns subject information as a string
        public override string ToString()
        {
            return base.ToString() +
            "\nStudent ID: " + StudentID + 
            ", Program: " + Program+ 
            ", Date register: " + DateRegister+
            "\nEnrollment: " + Enrollment;
        }

        
        // override the virtual Equals() method
       
        public override bool Equals(object? obj)
        {
            if (obj == null)//check null object to avoid NullReferenceException
                return false;
            if (ReferenceEquals(obj, this))//check reference equality
                return true;
            if (obj.GetType() != this.GetType())//check different object types
                return false;
            Student student1 = (Student)obj;
            return student1.StudentID == this.StudentID;
        }


        // Overloads the == operator to compare two Student objects.
        public static bool operator ==(Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }


        // Overloads the != operator to compare two Student objects.
        public static bool operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }

        // Generates a hash code for the Student object using the StudentID.
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;

            return this.StudentID.CompareTo(other.StudentID);
        }
        
        public static bool operator <(Student student1, Student student2)
        {
            return student1.CompareTo(student2) < 0;
        }

        public static bool operator <=(Student student1, Student student2)
        {
            return student1.CompareTo(student2) <= 0;
        }

        public static bool operator >(Student student1, Student student2)
        {
            return student1.CompareTo(student2) > 0;
        }

        public static bool operator >=(Student student1, Student student2)
        {
            return student1.CompareTo(student2) >= 0;
        }
    }
}