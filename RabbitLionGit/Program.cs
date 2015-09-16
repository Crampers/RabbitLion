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

            for (int iii = 0; iii < 100; iii++)
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int ii = 0; ii < 20; ii++)
                    {
                        if (savannah.spot[1,1] is Lion)
                        {
                            Console.Write("L ");
                        }
                        if (savannah.spot.ani is Rabbit)
                        {
                            Console.Write("R ");
                        }
                        if (savannah.spot == null)
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine("|");
                }
            }
            Console.WriteLine("----------------------------------------");
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
             /*
              for(int i = -2; i < 3; i++)
              for(int j = -2; j < 3; j++)
              if(spot[í,j] is Lion||Rabbit)
              confirmed == true
              */
             
             return confirmed;
         }
    }
    class Grass
    {
        public double weight = 1.00;

        private void grow()
        {
            weight = weight * 1.1;
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
        public Field spot;
        public Savannah()
        {
            Field [,] spot = new Field[20,20];
            for (int i = 0; i == 20; i++)
            {
                for (int j = 0; j == 20; j++)
                {
                    spot[i,j] = new Field();
                }
            }
            for (int i = 0; i < 12; i++)
            {
                int ranX = new Random().Next(0, 21);
                int ranY = new Random().Next(0, 21);
                if(i < 7)
                {
                    spot[ranX, ranY].ani = new Rabbit();
                }
                else
                {
                    spot[ranX, ranY].ani = new Lion();
                }
            }
        }
    }
    class Field
    {
        public Animals ani;
        public Grass grass;
    }
}
