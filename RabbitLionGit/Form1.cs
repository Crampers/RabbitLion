using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Random ran;
        private Random ran2;
        private PictureBox pictureBox;
        
        public Form1()
        {
            InitializeComponent();
            ran = new Random();
            ran2 = new Random(DateTime.Now.Millisecond + 5);
            pictureBox = new PictureBox();
            savannah = new Savannah(pictureBox, ran, ran2);
            foreach (var animal in savannah.spot)
            {
                if (animal.ani != null)
                    Console.WriteLine(animal.ani.GetType());
            }
            for (int i1 = 0; i1 < 1; i1++)
            {
                for (int i2 = 0; i2 < 20; i2++)
                {
                    for (int i3 = 0; i3 < 20; i3++)
                    {
                        //Creating a Console App to test and see if the objects are in fact created
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
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("----------------------------------------/");
                //Sleep is made to test if the objects does in fact move
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            savannah.draw();
        }
    }
}
