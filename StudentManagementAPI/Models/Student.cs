using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [MaxLength(100)]
        public string StudentName { get; set; }

        public DateTime DOB { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [NotMapped] // This means it's not saved in the database directly
        public int SelectedSubjectId { get; set; }

        // Many-to-Many Relationship with Subjects
        public List<StudentSubject>? StudentSubjects { get; set; }
    }
}
