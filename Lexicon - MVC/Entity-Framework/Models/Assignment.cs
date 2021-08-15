using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFW_Assignment.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<StudentCourseViewModel> StudentCourseViewModels { get; set; }

    }
}
