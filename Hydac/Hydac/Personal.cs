using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac
{
    public class Personal
    {
        public string getUsr = "";
        public int getId = 0;


        private bool idMedarbejder()
        {
            if (getUsr == "Archie" && getId == 69420)
            {
                return true;
            }
            else if (getUsr == "Alex" && getId == 1234)
            {
                return true;
            }
            else return false;
        }

        public string Checkpoint()
        {
            if (idMedarbejder() == true)
                return "I.D. Valid";
            else if (idMedarbejder() == false)
                return "I.D. not valid";
            else
                return "Error";
        }
    }
}
