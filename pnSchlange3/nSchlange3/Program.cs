using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSchlange3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2, 2, '*');
            point.Zeichnen();

            SpielFeld spielFeld = new SpielFeld(120,30,'+');
            spielFeld.ZeichnenWaende();



            Console.ReadLine();
        }
    } 
}
