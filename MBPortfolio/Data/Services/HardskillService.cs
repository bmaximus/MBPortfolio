using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBPortfolio.Data
{
    public class HardskillService
    {

        public Task<List<MBPortfolio.Data.Skill>> GetHardskills()
        {
            return Task.FromResult(new List<Skill>
            {
                new Skill(0.9d, " Microsoft C# - Framework / Core", 1, "../img/cs.png", "Deep knowledge and experience"),
                new Skill(0.85d, " Microsoft SQL Server", 2, "../img/sql.png", "Deep knowledge and experience"),
                new Skill(0.6d, " Microsoft Xamarin", 3, "../img/xamarin.png", "Extensive knoledge and experience"),
                new Skill(0.5d, "HTML", 5, "../img/html.png", "Regular skills"),
                new Skill(0.49d, "CSS", 5, "../img/css.png", "Regular skills"),
                new Skill(0.2d, "Java", 4, "../img/java.png", "Basic knowledge"),
                
            }.OrderByDescending(d => d.Percentage).ToList());
        }
    }
}


//  1200 x 513