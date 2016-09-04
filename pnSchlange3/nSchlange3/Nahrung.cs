using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSchlange3
{
    class Nahrung
    {
        static int nahrungsNr = 1;
        static int nahrungsNrPositionX = 100;
        static int nahrungsNrPositionY = 3;

        int maxPositionX;
        int maxPositionY;
        int randomPositionX;
        int randomPositionY;
        SpielFeld spielfeld;
        Random random = new Random();
        
        public Nahrung(SpielFeld _spielfeld, char _nahrungSymbol)
        {
            spielfeld = _spielfeld;
           
            randomPositionX = GenerierenRandomPositionX();
            randomPositionY = GenerierenRandomPositionY();
        }    

        public Point Erzeugen(Schlange schlange)
        {

            foreach(Point p in schlange.GetSchlangenPointsList())
            {
                if(p.Kollision(randomPositionX, randomPositionY))
                {
                    nahrungsNr++;
                    Console.SetCursorPosition(nahrungsNrPositionX, nahrungsNrPositionY);
                    Console.Write(nahrungsNr);

                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("--- NAHRUNG VERSTECKT ---");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine(randomPositionX);
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine(randomPositionY);
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine(nahrungsNr);
                    Console.ReadLine();

                    randomPositionX = GenerierenRandomPositionX();
                    randomPositionY = GenerierenRandomPositionY();
                }
            }

            return new Point(randomPositionX, randomPositionY, '$');
        }

        private int GenerierenRandomPositionX()
        {
            maxPositionX = spielfeld.GetBreite();
            return random.Next(1, maxPositionX);
        }

        private int GenerierenRandomPositionY()
        {
            maxPositionY = spielfeld.GetHohe();
            return random.Next(1, maxPositionY);
        }

    }
}
