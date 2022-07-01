using System.ComponentModel.DataAnnotations.Schema;

namespace BeigWeek6.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }

        // Navigation property
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
