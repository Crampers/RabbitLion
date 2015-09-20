﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RabbitLionGit
{
    public partial class Form1 : Form
    {
        private Savannah savannah;
        /*
         * Reason for the DateTime call in ran2 is to create a necessary delay
         * This delay is made so when running the program it actually creates
         * a different random. If there was no delay both randoms would have
         * exact same attributes meaning all the work done with them would
         * have the same output eventhough they are different objects.
         */
        private Random ran = new Random();
        private Random ran2 = new Random(DateTime.Now.Millisecond + 5);
        
        public Form1()
        {
            InitializeComponent();
            savannah = new Savannah(pictureBox1, ran, ran2);
            savannah.godDraws();
            /*foreach (var animal in savannah.africa)
            {
                if (animal.ani != null)
                    Console.WriteLine(animal.ani.GetType());
            }
            
            for (int ikeepGoing = 0; ikeepGoing < 10; ikeepGoing++)
            {
                int counter = 0;

                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        //Creating a Console App to test and see if the objects are in fact created
                        if (savannah.africa[i, j].ani is Rabbit)
                        {
                            Console.Write("R ");
                        }
                        if (savannah.africa[i, j].ani is Lion)
                        {
                            Console.Write("L ");
                            savannah.africa[i,j].ani.move();
                        }
                        if (savannah.africa[i, j].ani == null && savannah.africa[i, j].grass == null)
                        {
                            Console.Write("  ");
                        }
                        if (savannah.africa[i, j].grass != null)
                        {
                            Console.Write("G ");
                            savannah.africa[i, j].grass.grow();
                            counter = counter + 1;
                    
                        }
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("----------------------------------------/");
                Console.WriteLine("There is {0} amount of grass", counter);
            }
            //Sleep is made to test if the objects does in fact move
                Thread.Sleep(1000);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savannah.godDraws();
            /*Bitmap bmp;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics grp;
            grp = Graphics.FromImage(bmp);
            grp.Clear(Color.White);
            Pen p = new Pen(Color.Black);
            for (int i = 0; i < 401; i += 20)
            {
                for (int j = 0; j < 401; j += 20)
                {
                    grp.DrawRectangle(p, i, j, 20, 20);
                }
            }
            pictureBox1.Image = bmp;*/

            foreach (var animal in savannah.africa.Cast<Field>().Where(animal => animal.ani != null))
            {
                Console.WriteLine(animal.ani.gender);
            }
            foreach (var grass in savannah.africa.Cast<Field>().Where(grass => grass.grass != null))
            {
                Console.WriteLine(grass.grass.GetType());
            }
            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    //Creating a Console App to test and see if the objects are in fact created
                    if (savannah.africa[i, j].ani is Rabbit)
                    {
                        Console.Write("R ");
                        savannah.africa[i,j].ani.move();
                    }
                    if (savannah.africa[i, j].ani is Lion)
                    {
                        Console.Write("L ");
                        savannah.africa[i, j].ani.move();
                    }
                    if (savannah.africa[i, j].ani == null && savannah.africa[i, j].grass == null)
                    {
                        Console.Write("  ");
                    }
                    if (savannah.africa[i, j].grass != null)
                    {
                        Console.Write("G ");
                        savannah.africa[i, j].grass.grow();
                    }
                }
                Console.WriteLine("|");
                savannah.godDraws();
            }
            int amount = savannah.africa.Cast<Field>().Count(animal => animal.ani is Lion);
            int amountR = savannah.africa.Cast<Field>().Count(animal => animal.ani is Rabbit);
            Console.WriteLine("----------------------------------------/");
            Console.WriteLine(amount + " Amount of Lions");
            Console.WriteLine(amountR + " Amount of Rabbits");
            savannah.godDraws();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
