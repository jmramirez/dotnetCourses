using System;
using System.Collections.Generic;
using System.Text;

namespace NetCourses.Domain.Entities
{
    public class LessonTakenbyStudent
    {
        public int Id { get; set; }
        public CourseLesson Lesson { get; set; }
        public UserModel User { get; set; }
    }
}
