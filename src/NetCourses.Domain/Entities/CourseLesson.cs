using System;
using System.Collections.Generic;
using System.Text;

namespace NetCourses.Domain.Entities
{
    public class CourseLesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string VideoUrl { get; set; }
        public int Order { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
