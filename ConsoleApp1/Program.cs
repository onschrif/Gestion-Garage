using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Automobile Auto1 = new Automobile(2015, "2500 TU 195");
            Console.WriteLine(Auto1.ToString());
        }
    }
}
