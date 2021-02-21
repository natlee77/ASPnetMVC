using schoolPortal.Data;
using System;
using System.Collections.Generic;

#nullable disable

namespace schoolPortal.Entities
{
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            SchoolClassCourses = new HashSet<SchoolClassCourse>();
            SchoolClassStudents = new HashSet<SchoolClassStudent>();
        }

        public Guid Id { get; set; }
        public string ClassName { get; set; }
        public string ProgramManagerId { get; set; }
        public DateTime Created { get; set; }

        public virtual  AppUser ProgramManager { get; set; }
        public virtual ICollection<SchoolClassCourse> SchoolClassCourses { get; set; }
        public virtual ICollection<SchoolClassStudent> SchoolClassStudents { get; set; }
    }
}
