using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyResume.Entities
{
    public class Skill
    {
        [Required(ErrorMessage = "not be empty")]
        public int SkillId { get; set; }
        [Required(ErrorMessage = "not be empty")]
        public string Title { get; set; }
        [Required(ErrorMessage = "not be empty")]
        public string Icon { get; set; }
        [Required(ErrorMessage = "not be empty")]
        public string Description { get; set; }
        [Required(ErrorMessage = "not be empty")]
        public byte Rate { get; set; }
    }
}