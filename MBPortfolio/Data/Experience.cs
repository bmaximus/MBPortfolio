using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBPortfolio.Data
{
    public class Experience
    {
        public Experience(DateTime dateFrom, DateTime? dateTo, string jobTitle, string companyName, List<string> duties)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
            JobTitle = jobTitle;
            CompanyName = companyName;
            Duties = duties;
        }

        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public List<string> Duties { get; set; }
    }
}
