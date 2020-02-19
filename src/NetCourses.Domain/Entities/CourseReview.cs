using System;
using System.Collections.Generic;
using System.Text;

namespace NetCourses.Domain.Entities
{
    public class CourseReview
    {
        public int Id { get; set; }
        public decimal rating { get; set; }
        public string Comment { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
