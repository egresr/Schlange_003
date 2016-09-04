using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nSchlange3
{
    class Program
    {
        static void Main(string[] args)
        {
            SpielFeld spielFeld = new SpielFeld(120,30,'+');
            spielFeld.ZeichnenWaende();

            Point point = new Point(3, 15, '*');
            Schlange schlange = new Schlange(point, 3, Richtung.RECHTS);

            while(true)
            {
                Thread.Sleep(100);
                schlange.Zeichnen();
                schlange.Bewegen();
            }





            Console.ReadLine();
        }
    } 
}
