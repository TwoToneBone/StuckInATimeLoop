using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int spells = int.Parse(Console.ReadLine());

            for (int i = 0; i < spells; i++)
            {
                Console.WriteLine($"{i +1 } Abracadabra");
            }
        }
    }
}
