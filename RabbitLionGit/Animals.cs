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
        public double weight;
        public int posX;
        public int posY;
        private Random newX;
        private Random newY;
        protected Savannah s;
        public bool gender;

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

        //private void move()
        //{
        //    int x = posX;
        //    int y = posY;
        //    if (x == 0)
        //        x = x + s.r.Next(x, 2);
            
        //}
        public Animals detectLion()
        {
            int x = posX;
            int y = posY;
            for (int i = -1; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (s.africa[x, y].ani is Lion)
                    {
                        return s.africa[x, y].ani;
                    }

                }
            }
        }
        
        public Animals detectRabbit()
        {
            int x = posX;
            int y = posY;
            for (int i = -1; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (s.africa[x,y].ani is Rabbit)
                    {
                        return s.africa[x, y].ani;
                    }

                }
            }
        }
        public Grass detectGrass()
        {
            int x = posX;
            int y = posY;
            for (int i = -1; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (s.africa[x, y].grass != null)
                    {
                        return s.africa[x, y].grass;
                    }
                }
            }
        }

        public Animals mate(Animals detecter, Animals detectee)
        {
            if (detecter == detectee)
            {
                if (detecter.gender != detectee.gender)
                {
                    
                }
            }
        }
    }
}
