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
        public Random r;
        public Random r2;
        public Savannah(PictureBox picBox, Random rX, Random rY)
        {
            r = rX;
            r2 = rY;
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
                int ranX2 = rX.Next(0, 20);
                int ranY2 = rY.Next(0, 20);
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
                    africa[ranX2, ranY2].grass = new Grass(this, ranX2, ranY2);
                }
            }
        }
        Bitmap bmp;
        Graphics grp;

        void startup()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
        }
        public void drawField()
        {
            startup();
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

        private void drawGrass()
        {
            Pen pGrass = new Pen(Color.GreenYellow, 10);
            foreach (var field in africa)
            {
                if (field.grass is Grass)
                {
                    grp.DrawRectangle(pGrass, (field.grass.posY * 20 + 6), (field.grass.posX * 20 + 6), 9, 9);
                }
            }
        }

        private void drawAnimals()
        {
            Pen pRabbit = new Pen(Color.Khaki, 10);
            Pen pLion = new Pen(Color.Goldenrod, 10);
            foreach (var field in africa)
            {
                if (field.ani is Lion)
                {
                    grp.DrawRectangle(pLion, (field.ani.posY * 20 + 6), (field.ani.posX * 20 + 6), 9, 9);
                }
                if (field.ani is Rabbit)
                {
                    grp.DrawRectangle(pRabbit, (field.ani.posY * 20 + 6), (field.ani.posX * 20 + 6), 9, 9);
                }
            }
        }

        public void godDraws()
        {
            drawField();
            drawGrass();
            drawAnimals();
        }

        //public void checkBorder()
        //{
        //    if (nposX == 19)
        //    {

        //    }
        //    if (nposY == 19)
        //    {

        //    }
        //    if (nposX == 0)
        //    {

        //    }
        //    if (africa[ == 0)
        //    {

        //    }
        //}
    }
}
