namespace BeigWeek6.Models
{
    using System;
    using System.Collections.Generic;
    /*Created by Beig.
     * These Model classes represent tables within the databse.
     * The properties in therse classes are columns within the table that will be created upon migration.
     * Data Annotations can be added to customize various columns setting and constraints (Kept the minimum in this lab for simplicity).
     */
    public class Student
    {
        public int ID { get; set; }
        public string? LastName { get; set; }
        public string? FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigation Property
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
