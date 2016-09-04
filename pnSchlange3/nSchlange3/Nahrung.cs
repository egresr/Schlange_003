using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSchlange3
{
    class Nahrung
    {
        Random random = new Random();    

        public Point Erzeugen(SpielFeld spielfeld, char nahrungSymbol)
        {
            int maxPositionX = spielfeld.GetBreite();
            int maxPositionY = spielfeld.GetHohe();
            int randomPositionX = random.Next(1, maxPositionX);
            int randomPoitionY = random.Next(1, maxPositionY);
            return new Point(randomPositionX, randomPoitionY, nahrungSymbol);
        }
    }
}
