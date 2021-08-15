using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFW_Assignment.Models
{
    public class Course
    {
        //[Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string TimePeriod { get; set; }                
        public IList<StudentCourse> StudentCourses { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<StudentCourseViewModel> StudentCourseViewModels { get; set; }
    }
}
