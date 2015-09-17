using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using RabbitLionGit;

namespace RabbitsLions
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Random r2 = new Random(DateTime.Now.Millisecond + 5);
            Savannah savannah = new Savannah(r,r2);
            foreach (var animal in savannah.spot)
            {
                if(animal.ani !=null)
                Console.WriteLine(animal.ani.GetType());
            }
            for (int i1 = 0; i1 < 1; i1++)
            {
                for (int i2 = 0; i2 < 20; i2++)
                {
                    for (int i3 = 0; i3 < 20; i3++)
                    {
                        //Console.WriteLine(savannah.spot[i2,i3]);
                        if (savannah.spot[i2, i3].ani is Rabbit)
                        {
                            Console.Write("R ");
                        }
                        if (savannah.spot[i2, i3].ani is Lion)
                        {
                            Console.Write("L ");
                        }
                        if (savannah.spot[i2, i3].ani == null)
                        {
                            Console.Write("  ");
                        }
                        if (savannah.spot[i2, i3].grass is Grass)
                        {
                            Console.Write("G ");
                        }
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("----------------------------------------/");
                Thread.Sleep(1000);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.ReadKey();
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
        private int posX;
        private int posY;
        private Savannah s;
        public abstract void move();
        public abstract void eats();

        public Animals(Savannah s, int x, int y)
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
        public Lion(Savannah s, int x, int y) : base(s, x, y)
        {
            
        }
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
        public Rabbit(Savannah s, int x, int y) : base(s,x,y)
        {
            
        }
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
        public Field[,] spot;
        public Savannah(Random ranX, Random ranY)
        {
            spot = new Field[20, 20];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    spot[i, j] = new Field();
                }
            }
            for (int i = 0; i < 22; i++)
            {
                int ranX2 = ranX.Next(0,20);
                int ranY2 = ranY.Next(0,20);
                if (i < 7 && spot[ranX2, ranY2].ani == null)
                {
                    spot[ranX2, ranY2].ani = new Rabbit(this, ranX2, ranY2);
                }
                else if(i > 6 && i < 13 && spot[ranX2,ranY2].ani == null )
                {
                    spot[ranX2, ranY2].ani = new Lion(this, ranX2, ranY2);
                }
                else if (i > 12 && spot[ranX2, ranY2].ani == null)
                {
                    spot[ranX2, ranY2].grass = new Grass();
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
