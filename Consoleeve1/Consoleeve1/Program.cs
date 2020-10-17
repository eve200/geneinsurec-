using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleeve1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<vehicle> lstvehicle = new List<vehicle>();
            lstvehicle.Add(new vehicle());
            lstvehicle[0].Vehicle_reg = "ACU";
            lstvehicle[0].Owner_natid = 678999021;
            lstvehicle[0].Amount = 100;
            lstvehicle[0].time = Convert.ToDateTime("10/17/2020");

            lstvehicle.Add(new vehicle());
            lstvehicle[1].Vehicle_reg = "AEK";
            lstvehicle[1].Owner_natid = 090987676;
            lstvehicle[1].Amount = 100;
            lstvehicle[1].time = Convert.ToDateTime("10/16/2020");

            foreach (vehicle oStud in lstvehicle)
            {
                Console.WriteLine(oStud.getData());
            }
            Console.ReadLine();
        }
    }
}
