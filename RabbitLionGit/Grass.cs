using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitLionGit
{
    class Grass
    {
        //giving grass a 
        public double weight;
        public int posX;
        public int posY;
        private int nposX;
        private int nposY;
        private Savannah s;
        
        public Grass(Savannah s,int x, int y)
        {
            weight = 6.0;
            posX = x;
            posY = y;
            this.s = s;
        }
        //Grow makes the grass increase in size with every tick
        public void grow()
        {
            //Console.WriteLine("I got you mang");
            weight = weight*1.1;
            while (weight > 3.50)
            {
                spread();
                weight = weight - 1.0;
            }
        }
        //Spread is made for the grass to... well spread
        private void spread()
        {
            nposX = posX;
            nposY = posY;
            if (nposX == 19)
            {
                nposX = nposX + s.r.Next(-1, 0);
            }
            if (nposY == 19)
            {
                nposY = nposY + s.r.Next(-1, 0);
            }
            if (nposX == 0)
            {
                nposX = nposX + s.r.Next(0, 2);
            }
            if (nposY == 0)
            {
                nposY = nposY + s.r.Next(0, 2);
            }
            s.africa[nposX,nposY].grass = new Grass(s, nposX, nposY);
            s.godDraws();
        }
    }
}
