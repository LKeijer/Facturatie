using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows;

namespace Offerte_en_Facturatie_UI
{
    public class Klant
    {
        //Declarations
        string myConnecThong = ConfigurationManager.ConnectionStrings["conString"].ConnectionString; //Gets the connectionstring from the app.config file in this solution.
        List<string> inputList = new List<string>();

        public Klant (List<string> input)
        {
            this.inputList = input;
        }

        public void InsertKlant()
        {
            MessageBox.Show(inputList[0]);
        }
    }


}
