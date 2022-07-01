namespace BeigWeek6.Models
{
    /*Created by Beig.
     * These Model classes represent tables within the databse.
     * The properties in therse classes are columns within the table that will be created upon migration.
     * Data Annotations can be added to customize various columns setting and constraints (Kept the minimum in this lab for simplicity).
     */
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        //Naviagation properties
        public Course? Course { get; set; }
        public Student? Student { get; set; }
    }
}
