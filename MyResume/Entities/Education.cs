using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Entities
{
    public class Education
    {
        public int EducationId { get; set; }
        public string SchoolName { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public string Grade { get; set; }
        public string Description { get; set; }
        public string GradePointAverage { get; set; }
        public DateTime StartingMonth { get; set; }
        public DateTime StartingYear { get; set; }
        public DateTime EndingMonth { get; set; }
        public DateTime EndingYear { get; set; }
    }
}