using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }
}