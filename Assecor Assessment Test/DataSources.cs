using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assecor_Assessment_Test
{
    class DataSources
    {
        List<IConfigAPI> anzeigen = new List<IConfigAPI>();

        public void WerteGeaendert()
        {
            foreach (DataSources anzeige in anzeigen)
            {
                //anzeige.aktualisieren(this);
            }
        }
        public void TestController() // Nur für Testzwecke später
        {
            
            WerteGeaendert();
        }
    }
}
