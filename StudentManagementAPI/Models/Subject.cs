﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }

        [Required]
        [MaxLength(100)]
        public string SubjectName { get; set; }

        [Required]
        [MaxLength(100)]
        public string SubjectLecturer { get; set; }

        // Many-to-Many Relationship with Students
        public List<StudentSubject> StudentSubjects { get; set; }
    }
}
