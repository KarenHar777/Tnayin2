using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class GarageClass:CarClass
    {

        public GarageClass()
        {
            name = "Mers";
            motion = 600;
           
        }

        public GarageClass(string n, int m)
        {
            name = n;
            motion = m;
        }
        
    }
}
