using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NetCourses.Domain.Extensions
{
    public class Enums
    {
        public enum Status
        {
            Pending,
            Approved,
            Rejected
        }

        public enum EntityType
        {
            Users,
            Categories,
            Courses
        }

        public enum IncomeType
        {
            Total,
            CompanyTotal,
            TeacherTotal
        }
    }
}
