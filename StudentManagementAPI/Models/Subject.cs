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





    }

}