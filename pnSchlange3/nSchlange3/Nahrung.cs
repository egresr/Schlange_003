using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSchlange3
{
    class Nahrung
    {
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


            if (schlange.GetPositionX() == randomPositionX || schlange.GetPositionY() == randomPositionX)
            {
                randomPositionX = GenerierenRandomPositionX();
                randomPositionY = GenerierenRandomPositionY();

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
