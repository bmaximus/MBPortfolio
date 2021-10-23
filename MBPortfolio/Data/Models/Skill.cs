using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBPortfolio.Data
{
    public class Skill
    {
        public Skill(double percentage, string skillName, int order, string imageLink, string details)
        {
            Percentage = percentage;
            SkillName = skillName;
            Order = order;
            ImageLink = imageLink;
            Details = details;
        }

        public double Percentage { get; set; }
        public string SkillName { get; set; }
        public int Order { get; set; }
        public string ImageLink { get; set; }
        public string Details { get; set; }
    }
}
