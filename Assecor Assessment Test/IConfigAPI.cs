using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assecor_Assessment_Test
{
    public interface  IConfigAPI
    {
        string Path { get; set; }
        string color { get; set; }
        string data_sources { get; set; }

        string ReadFile();
        string GetPerson();
       // void Aktualisieren(DataSources dataSources);


        

    }
}
