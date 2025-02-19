using System;
using System.ComponentModel.DataAnnotations;



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

    }

}