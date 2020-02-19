using NetCourses.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCourses.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public Price Price { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public Enums.Status Status { get; set; } 
        public decimal Rating { get; set; }
        public ICollection<CourseLesson> Lessons { get; set; }
        public ICollection<UserModel> Users { get; set; }
        public UserModel Author { get; set; }
    }
}
