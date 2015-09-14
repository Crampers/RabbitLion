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
            Savannah savannah = new Savannah();
            savannah.godCreates();
        }
    }
    //A class for the animals
     abstract class Animals
    {
        //the char type is to determine the animal ex. R - Rabbit, L - Lion, X - Dead
        private char type;
        //Selfexplanatory
        private bool alive = true;
        private double weight;
        private int amount;
        public abstract void move();
        public abstract void eats();

         public bool checkNear()
         {
             bool confirmed = false;
             return confirmed;
         }
    }

    class Lion : Animals
    {
        public override void move()
        {
            int pOX = new Random().Next(-1, 1);
            int pOY = new Random().Next(-1, 1);
        }

        public override void eats()
        {
            if (checkNear() == true)
            {
                
            }
        }
    }

    class Rabbit : Animals
    {
        public override void move()
        {
            int pOX = new Random().Next(-2, 2);
            int pOY = new Random().Next(-2, 2);
        }

        public override void eats()
        {
            if (checkNear() == true)
            {
                
            }
        }
    }
    class Savannah
    {
        private int posX;
        private int posY;
        private Animals ani;

        public Savannah()
        {
            posY = 20;
            posX = 20;
        }

        public void godCreates()
        {
            Savannah [,] spot = new Savannah[posX, posY];
        }
    }
}
