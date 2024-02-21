using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartingMonth { get; set; }
        public DateTime StartingYear { get; set; } 
        public DateTime EndingMonth { get; set; }
        public DateTime EndingYear{ get; set; }
    }
}