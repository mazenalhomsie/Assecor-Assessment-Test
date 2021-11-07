using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Assecor_Assessment_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(@"C:\sample-input.csv"))
            {

                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ",",
                    HasHeaderRecord = false
                    // var records = csvreader.GetRecords<Information>().ToList();
                };
                using (var csvReader = new CsvReader(streamReader, csvConfig))
                {
                    var record = csvReader.GetRecords<PersonInformation>().ToList();
                }

            }
            Console.ReadKey();
        }
    }

    public class PersonInformation
    {

        public PersonInformation()
        {
            PersonInformation personInformation = new PersonInformation();
            personInformation.zipCode = cityName.Substring(0, 5);
            personInformation.Id = +1;
        }
        [Index(0)]
        public string firstName { get; set; }
        [Index(1)]
        public string lastName { get; set; }
        [Index(2)]
        public string zipCode { get; set; }
        [Index(2)]
        public string cityName { get; set; } 
        public enum color { };
        public int Id { get; set; }
    }

   
    enum Color
    {
        Blau,
        Green,
        Violett,
        Red,
        Turquoise,
        Yallow,
        White,
    }
}
