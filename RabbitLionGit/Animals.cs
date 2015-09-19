using System;
using System.Collections;
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
        protected Savannah s;
        public bool gender;

        /*
         * A bunch of abstract methods because Rabbits don't eat the same as lions
         * Nor are they capeable of moving the same amount of tiles
         * also they can't interspecies - that would create some weird hybrid
         * Liobbits or Rions - or something along those lines
         */
        
        public abstract void devour();
        public abstract void move();
        public abstract void mate(Animals detecter, Animals detectee);
        protected Animals(Savannah s, int x, int y)
        {
            this.s = s;
            posX = x;
            posY = y;
            
            if (s.africa[posX, posY].ani is Rabbit)
            {
                weight = s.r.Next(7,10);
            }
            else if (s.africa[posX,posY].ani is Lion)
            {
                weight = s.r2.Next(40, 60);
            }
            if (s.africa[posX, posY].ani == null)
            {
                
            }            
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
                    if (s.africa[x + i, y+j].ani is Lion)
                    {
                        return s.africa[x + i, y + j].ani;
                    }
                }
            }
            return null;
        }
        
        public Animals detectRabbit()
        {
            int x = posX;
            int y = posY;
            for (int i = -1; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (s.africa[x + i, y + j].ani is Rabbit)
                    {
                        return s.africa[x + i, y + j].ani;
                    }
                }
            }
            return null;
        }
        public Grass detectGrass()
        {
            int x = posX;
            int y = posY;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (x + i > 19 || y + j > 19)
                    {
                        this++;
                    }
                    if (s.africa[x, y].grass != null)
                    {
                        return s.africa[x, y].grass;
                    } 
                }
            }

            return null;
        }

        public void detectFRabbit()
        {
            detectGrass();
            detectRabbit();
        }

        
    }
}
