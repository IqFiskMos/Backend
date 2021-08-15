using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFW_Assignment.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Qualification { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
        public ICollection<StudentCourseViewModel> StudentCourseViewModels { get; set; }

    }
}
