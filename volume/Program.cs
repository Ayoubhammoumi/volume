using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            radio radio = new radio();

            radio.volume = 100;

            Console.WriteLine("{0}", radio.aumentavolume(radio.volume));

            Console.WriteLine("{0}", radio.abbassavolume(radio.volume));

            Console.ReadLine();
        }
    }
}
