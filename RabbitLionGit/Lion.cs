using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RabbitsLions;

namespace RabbitLionGit
{
    class Lion : Animals
    {
        // Creating reference to animals constructor to ease creating new objects
        public Lion(Savannah s, int x, int y)
            : base(s, x, y)
        {
            int gend = s.r.Next(0, 100);
            if (gend < 50)
                gender = false;
            else
            {
                gender = true;
            }
        }

        public override void move()
        {
            //haven't been made like Rabbit... YET
            int nposX = posX;
            int nposY = posY;

            nposX = nposX + s.r.Next(-1, 2);
            nposY = nposY + s.r2.Next(-1, 2);
            //Having while loops to make sure animals don't cross the border to uncreated fields
            while (nposX > 19)
            {
                nposX--;
            }

            while (nposY > 19)
            {
                nposY--;
            }
            while (nposX < 0)
            {
                nposX++;
            }
            while (nposY < 0)
            {
                nposY++;
            }
            if (s.africa[nposX, nposY].ani == null)
            {
                s.africa[nposX, nposY].ani = this;
                Thread.Sleep(20);
                s.africa[posX, posY].ani = null;
            }

            posX = nposX;
            posY = nposY;
            s.godDraws();
        }

        public override void devour()
        {
            Animals killMe = detectRabbit();
            var xRabbit = killMe.posX;
            var yRabbit = killMe.posY;
            s.africa[xRabbit, yRabbit].ani = null;
            weight = weight * (killMe.weight * -1.75);
        }

        public override void mate(Animals detecter, Animals detectee)
        {
            int ranX2 = s.r.Next(0, 20);
            int ranY2 = s.r2.Next(0, 20);
            if (detecter is Lion && detectee is Lion)
            {
                if (detecter.gender != detectee.gender)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        s.africa[ranX2, ranY2].ani = new Lion(s, ranX2, ranY2);
                    }
                }
            }
        }
    }
}
