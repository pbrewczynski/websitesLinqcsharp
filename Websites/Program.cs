using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Program
    {
        const int WEBSITE_COUNT     = 100;
        const int MAX_KEYWORD_COUNT = 100;
        const int MAX_VISITORS_MONTHLY = 100000;
        static Random R = new Random();

        private static string generateRandomAddress()
        {
            int adressLength = R.Next(50);
            adressLength += 3;              // add space to domain.
            Char[] address = new Char[adressLength];
            for (int i = 0; i < adressLength-3; i++)
            {
                address[i] = Convert.ToChar(Convert.ToByte(R.Next(97, 123)));
            }
            address[adressLength - 3] = '.';
            for (int i = adressLength - 2; i < adressLength; i++)
            {
                address[i] = Convert.ToChar(Convert.ToByte(R.Next(97, 123)));
            }

            return (new String(address));
        }

        static string[] keywordArr = {"first keyword", "second keyword", "third keyword", "forth keyword", "fith keyword"};
        private static string[] generateRandomKeywords () {
            int keywordCount = R.Next(MAX_KEYWORD_COUNT + 1);
            string[] keywords = new string[keywordCount];
            for (int i = 0; i < keywordCount; i++)
            {
                keywords[i] = Program.keywordArr[R.Next(keywordArr.Length)];
            }
           
            
            return keywords;
        }

        private static Dictionary<string, Website> generateWebsites()
        {

            Dictionary<string, Website> databaseOfWebsites = new Dictionary<string, Website>(WEBSITE_COUNT);

            for (int i = 0; i < Program.WEBSITE_COUNT; ++i)
            {
                DateTime creationTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                creationTime = creationTime.AddSeconds(Program.R.Next(1386094752));
                string address = Program.generateRandomAddress();
                Website w = new Website(Program.generateRandomAddress(), creationTime, Program.generateRandomKeywords(), R.Next(MAX_VISITORS_MONTHLY));
                databaseOfWebsites.Add(address, w);
            }

            return databaseOfWebsites;
        }

        static private void show (IEnumerable<Website> websiteIENumerable ) {
            foreach (Website w in websiteIENumerable) {
                 Console.WriteLine(w.URL + " ");
                 foreach(string s in w.keyWords) {
                     Console.Write("-" + s);
                 }
                 Console.WriteLine();
                 Console.WriteLine(w.creationDate.ToString());
                 Console.WriteLine(w.averageVisitorsMonthly + "\n\n");
                 
            }
        }

        //static StaticInitializing foo = new StaticInitializing();
        static void Main(string[] args)
        {

            Dictionary<string, Website> webDatabase = Program.generateWebsites();

            // Exercise 1 :

            var over8000Monthl = from website in webDatabase
                                 where website.Value.averageVisitorsMonthly > 8000
                                 select website.Value;

            Program.show(over8000Monthl);

            var after2000year = from website in webDatabase
                                where website.Value.creationDate.Year > 
            
        }
    }
}
