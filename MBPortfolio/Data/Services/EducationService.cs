using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBPortfolio.Data
{
    public class EducationService
    {
        public Task<List<MBPortfolio.Data.Education>> GetEducations()
        {

            return Task.FromResult(new List<Education>
            {
                new Education(
                new DateTime(2010, 11, 1),
                new DateTime(2016, 8, 31),
                universityName: "University of Macedonia",
                location: "Thessaloniki, Greece",
                department: "Information Technology",
                icon: "../img/barchelors.png",
                degreeLevel: DegreeLevel.Bachelors),
               
                new Education(
                new DateTime(2018, 9, 1),
                new DateTime(2019, 8, 31),
                universityName: "University of Cyprus",
                location: "Nicosia, Cyprus",
                department: "Computer Science",
                icon: "../img/masters.png",
                degreeLevel: DegreeLevel.Masters)
            }.OrderByDescending(d => d.DateFrom).ToList());
        }
    }
}
