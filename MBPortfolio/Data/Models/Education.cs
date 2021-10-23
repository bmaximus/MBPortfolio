using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBPortfolio.Data
{
    public class Education
    {
        public Education(DateTime dateFrom, DateTime dateTo, DegreeLevel degreeLevel, string department, string universityName, string location, string icon)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
            DegreeLevel = degreeLevel;
            Department = department;
            UniversityName = universityName;
            Location = location;
            Icon = icon;
        }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DegreeLevel DegreeLevel { get; set; }
        public string Department { get; set; }
        public string UniversityName { get; set; }
        public string Location { get; set; }
        public string Icon { get; set; }
    }

    public enum DegreeLevel
    {
        Bachelors,
        Masters

    }

}
