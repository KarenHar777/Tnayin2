using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class CarClass
    {
        public string name;
        public int motion;


        public CarClass()
        {
            name = "BMW";
            motion = 850;
        }

        public CarClass(string n, int m)
        {
            name = n;
            motion = m;
        }

        public void Print()
        {
            Console.Write(" " + name);
            Console.WriteLine(" " + motion);
        }
        
    }
}
