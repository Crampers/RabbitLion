using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RabbitsLions
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    //A class for the animals
     abstract class Animals
    {
        //the char type is to determine the animal ex. R - Rabbit, L - Lion, X - Dead
        private char type;
        //Selfexplanatory
        private bool alive = true;
        private double weight = 1.00;
        private int amount;

        public void TestAlive(bool alive)
        {
            if (alive != true)
            {
                type = 'X';
            }
        }

        public void rabbitOrLion()
        {
            char result;
            int ra = 0;
            Random r = new Random();
            lock (this)
            {
                ra = r.Next(0, 100);
            }
            if (ra > 50)
            {
                result = 'R';
            }
            else
                result = 'L';
            type = result;
        }
    }

    class Lion : Animals
    {
        
    }

    class Rabbit : Animals
    {
         
    }
    class Savannah
    {
        private int posX;
        private int posY;
        private Savannah[,] spot;
        private Animals ani;

        public Savannah()
        {
            posY = 20;
            posX = 20;
        }

        public void godCreates()
        {
            spot = new Savannah[posX, posY];
            for (int i = 0; i < posX; i++)
            {
                for (int j = 0; j < posY; j++)
                {
                    spot[i, j] = new Savannah();
                }
            }
        }
    }
}
