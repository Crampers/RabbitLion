using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitLionGit
{
    abstract class Animals
    {
        //Selfexplanatory
        private double weight;
        public int posX;
        public int posY;
        private Random newX;
        private Random newY;
        protected Savannah s;

        public abstract void devour();
        public abstract void move();

        protected Animals(Savannah s, int x, int y)
        {
            this.s = s;
            posX = x;
            posY = y;
        }
        public bool checkNear()
        {
            bool confirmed = false;
            /*
             for(int i = -2; i < 3; i++)
             for(int j = -2; j < 3; j++)
             if(spot[í,j] is Lion||Rabbit)
             confirmed == true
             */

            return confirmed;
        }

    }
}
