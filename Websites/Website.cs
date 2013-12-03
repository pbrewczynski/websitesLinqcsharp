using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Website
    {

       
        public string URL;
        public DateTime creationDate;
        public String[] keyWords;
        public int averageVisitorsMonthly;

        public Website(string URL, DateTime creationDate, string[] keyWords, int averageVisitorsMonthly)
        {
            this.URL = URL;
            this.creationDate = creationDate;
            this.keyWords = keyWords;
            this.averageVisitorsMonthly = averageVisitorsMonthly;
        }
    }
}
