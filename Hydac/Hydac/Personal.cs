using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac
{
    public class Personal
    {
        public bool id(string usr, int id)
        {
            if (usr == "Archie" && id == 69420)
            {
                return true;
            }
            else if (usr == "Alex" && id == 1234)
            {
                return true;
            }
            else return false;
        }
    }
}
