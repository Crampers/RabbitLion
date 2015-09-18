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
        private double weight;
        public int posX;
        public int posY;
        private Savannah s;

        //Grow makes the grass increase in size with every tick
        public Grass(/*Savannah s,int x, int y*/)
        {
            //weight = 1.5;
            //posX = x;
            //posY = y;
            //this.s = s;
        }

        public void grow()
        {
            weight = weight*1.1;
            if (weight < 3.50)
            {
                spread();
            }
        }
        private void spread()
        {
           // s.africa[posX + s.,posY].grass = new Grass();
        }
    }
}
