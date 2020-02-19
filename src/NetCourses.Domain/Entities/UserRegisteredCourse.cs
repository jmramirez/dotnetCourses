using System;
using System.Collections.Generic;
using System.Text;

namespace NetCourses.Domain.Entities
{
    public class UserRegisteredCourse
    {
        public int Id { get; set; }
        public bool Complete { get; set; } = false;
        public Course Course { get; set; }
        public int CourseId { get; set; }

    }
}
