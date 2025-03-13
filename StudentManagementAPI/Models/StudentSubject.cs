using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementAPI.Models
{
    public class StudentSubject
    {
        [Key]
        public int ID { get; set; }

        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student Student { get; set; }

        public int SubjectID { get; set; }
        [ForeignKey("SubjectID")]
        public Subject Subject { get; set; }
    }
}
