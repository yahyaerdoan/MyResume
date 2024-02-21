using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Entities
{
    public class Award
    {
        public int AwardId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Category { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string IssuedFrom  { get; set; }
        public DateTime IssuedDate  { get; set; }
    }
}