using NetCourses.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCourses.Domain.Entities
{
    public class Income
    {
        public int Id { get; set; }
        public Enums.EntityType EntityType { get; set; }
        public Enums.IncomeType IncomeType { get; set; }
        public decimal Total { get; set; }
        public int EntityId { get; set; }
    }
}
