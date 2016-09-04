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
            //Spielfeld
            SpielFeld spielFeld = new SpielFeld(120,30,'+');
            spielFeld.ZeichnenWaende();

            //Schlange
            Point point = new Point(3, 15, '*');
            Schlange schlange = new Schlange(point, 3, Richtung.RECHTS);
            schlange.Zeichnen();

            //Nahrung
            Nahrung nahrung = new Nahrung(spielFeld, '$');
            Point pNahrung = nahrung.Erzeugen(schlange);
            pNahrung.Zeichnen();

            //Spiel-Logik
            Console.ReadKey();
            while (true)
            {
                if(schlange.NahrungKollision(pNahrung))
                {
                    schlange.Wachsen(pNahrung);
                    nahrung = new Nahrung(spielFeld, '$');
                    pNahrung = nahrung.Erzeugen(schlange);
                    pNahrung.Zeichnen();

                    
                }
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
