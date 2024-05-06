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
                new DateTime(2022, 1, 1),
                jobTitle: "Software Developer C#/SQL",
                companyName: "Odyssey Consultants - Nicosia, Cyprus",
                duties: new List<string>()
                {
                    "- Working with BigData and Elastic",
                    "- Working on web application with .NET Framework / Core",
                    "- Developing and maintaining iOS/Adroid applications based on Xamarin"
                }
                ),
                new Experience(
                new DateTime(2022, 1, 1),
                new DateTime(2023,1,1),
                jobTitle: "Sr. Software Developer C#",
                companyName: "Isx Financial - Nicosia, Cyprus",
                duties: new List<string>()
                {
                    "- Working with online payments infrastructire",
                    "- Working on web application with .NET Framework / Core"
                }),
                new Experience(
                new DateTime(2023, 1, 1),
                null,
                jobTitle: "Sr. Software Developer C#",
                companyName: "Viva Wallet BI Data Service - Nicosia, Cyprus",
                duties: new List<string>()
                {
                    "- Developing integration with varius Regulation Authorities for each European country",
                    "- Working on application with .NET Core / Azure Datawarehouse / Azure Blob Storage"
                }
                )
            }.OrderByDescending(d => d.DateFrom).ToList());
        }

    }
}
