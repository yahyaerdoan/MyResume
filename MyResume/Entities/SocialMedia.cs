using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public int AboutId { get; set; }
        public About About { get; set; }
    }
}