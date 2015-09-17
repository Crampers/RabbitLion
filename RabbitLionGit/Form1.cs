using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RabbitLionGit
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private Graphics grp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            grp.Clear(Color.White);
            Pen p = new Pen(Color.Wheat);
            for (int i = 0; i < 401; i += 20)
            {
                for (int j = 0; j < 401; j += 20)
                {
                    grp.DrawRectangle(p, i, j, 20, 20);
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}
