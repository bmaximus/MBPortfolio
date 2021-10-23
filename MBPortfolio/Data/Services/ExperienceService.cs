using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBPortfolio.Data
{
    public class ExperienceService
    {
        public Task<List<MBPortfolio.Data.Experience>> GetExperiences()
        {

            return Task.FromResult(new List<Experience>
            {
                new Experience(
                new DateTime(2014, 3, 1),
                new DateTime(2016, 4, 1),
                jobTitle: "Junior Software Developer C#/SQL",
                companyName: "Mouzenidis Group - Thessaloniki, Greece",
                duties: new List<string>()
                {
                    "- Working with users to establish requirements and determine priorities",
                    "- Enchancing features for existing systems on Web and Windows applications",
                    "- Developing new application components to improve existing proccesses"
                }
                ),

                new Experience(
                new DateTime(2016, 5, 1),
                new DateTime(2016, 10, 1),
                jobTitle: "Software Developer C#/SQL",
                companyName: "The Core Process - Nicosia, Cyprus",
                duties: new List<string>()
                {
                    "- Complete development of e-shop on MVC",
                    "- Complete development of ePOS for windows terminal machines"
                }
                ),

                new Experience(
                new DateTime(2016, 11, 1),
                new DateTime(2018, 4, 1),
                jobTitle: "Software Developer C#/SQL/Java/\"C/AL\" ",
                companyName: "NetU Consultants - Nicosia, Cyprus",
                duties: new List<string>()
                {
                    "- Developing new application components for existing public components",
                    "- Working on web application with .NET and Angular",
                    "- Participating on automotive industry integration development"
                }
                ),
                new Experience(
                new DateTime(2018, 5, 1),
                null,
                jobTitle: "Sr. Software Developer C#/SQL",
                companyName: "Odyssey Consultants - Nicosia, Cyprus",
                duties: new List<string>()
                {
                    "- Working with BigData and Elastic",
                    "- Working on web application with .NET Framework / Core",
                    "- Developing and maintaining iOS/Adroid applications based on Xamarin"
                }
                )
            }.OrderByDescending(d => d.DateFrom).ToList());
        }

    }
}
