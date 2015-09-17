using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitsLions;

namespace RabbitLionGit
{
    class Savannah
    {
        public Field[,] africa = new Field[20, 20];
        public PictureBox pictureBox1;
        public Savannah(PictureBox picBox, Random ranX, Random ranY)
        {
            pictureBox1 = picBox;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    africa[i, j] = new Field();
                }
            }
            for (int i = 0; i < 22; i++)
            {
                int ranX2 = ranX.Next(0, 20);
                int ranY2 = ranY.Next(0, 20);
                if (i < 7 && africa[ranX2, ranY2].ani == null)
                {
                    africa[ranX2, ranY2].ani = new Rabbit(this, ranX2, ranY2);
                }
                else if (i > 6 && i < 13 && africa[ranX2, ranY2].ani == null)
                {
                    africa[ranX2, ranY2].ani = new Lion(this, ranX2, ranY2);
                }
                else if (i > 12 && africa[ranX2, ranY2].ani == null)
                {
                    africa[ranX2, ranY2].grass = new Grass();
                }
            }
        }

        public void draw()
        {
            Bitmap bmp;
            bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
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
            pictureBox1.Image = bmp;
        }

        public void drawGrass()
        {
            foreach (var grass in africa)
            {
                if(grass.grass != null)
                    
            }
        }
    }
}
