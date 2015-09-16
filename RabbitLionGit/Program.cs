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
    class Grass
    {
        public double weight = 1.00;

        private void grow()
        {
            weight = weight + 0.25;
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
            int pOX = new Random().Next(-1, 2);
            int pOY = new Random().Next(-1, 2);
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
        private Field spot;
        public void godCreates()
        {
            Field [,] spot = new Field[20,20];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    spot[i,j] = new Field();
                }
            }
        }
    }
    class Field
    {
        private Animals ani;
        private Grass grass;
    }
}
