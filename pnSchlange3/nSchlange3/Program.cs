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
            Point point = new Point(3, 3, '+');
            point.Zeichnen();

            LinieHorizontal linieHorizontalOben = new LinieHorizontal(0, 0, 5, 'H');
            LinieHorizontal linieHorizontalUnten = new LinieHorizontal(0, 4, 5, 'H');
            LinieVertikal linieVertikalLinks = new LinieVertikal(0, 0, 5, 'v');
            LinieVertikal linieVertikalRechts = new LinieVertikal(4, 0, 5, 'v');
            linieHorizontalOben.Zeichnen();
            linieHorizontalUnten.Zeichnen();
            linieVertikalLinks.Zeichnen();
            linieVertikalRechts.Zeichnen();


            Console.ReadLine();
        }
    } 
}
