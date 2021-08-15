using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFW_Assignment.Models
{
    public class CourseVM
    {
        public Course courselist { get; set; }
        public StudentCourse studentlist { get; set; }
        public Student slist { get; set; }
        public Teacher teacherlist { get; set; }
        public Assignment assignmentlist { get; set; }
    }
}
