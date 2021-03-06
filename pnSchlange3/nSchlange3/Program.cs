﻿using System;
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
            //Spielfeld
            SpielFeld spielFeld = new SpielFeld(120,30,'+');
            spielFeld.ZeichnenWaende();

            //Schlange
            Point point = new Point(3, 15, '*');
            Schlange schlange = new Schlange(point, 3, Richtung.RECHTS);

            //Nahrung
            Nahrung nahrung = new Nahrung();
            Point pNahrung = nahrung.Erzeugen(spielFeld, '$');
            pNahrung.Zeichnen();

            Console.ReadKey();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo taste = Console.ReadKey();
                    schlange.Steuern(taste);
                }
                Thread.Sleep(100);
                schlange.Zeichnen();
                schlange.Bewegen();
            }
        }
    } 
}
