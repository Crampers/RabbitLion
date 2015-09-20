using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RabbitsLions;

namespace RabbitLionGit
{
    class Rabbit : Animals
    {
        public Rabbit(Savannah s, int x, int y)
            : base(s, x, y)
        {
        }

        public override void move()
        {
            int nposX = posX;
            int nposY = posY;


            nposX = nposX + s.r.Next(-2, 3);
            nposY = nposY + s.r2.Next(-2, 3);
            nposY = check(nposY);
            nposX = check(nposX);
            if (s.africa[nposX, nposY].ani == null)
            {
                s.africa[nposX, nposY].ani = this;
                Thread.Sleep(20);
                s.africa[posX, posY].ani = null;
            }

            posX = nposX;
            posY = nposY;
            detectFRabbit();
            s.godDraws();
        }

        public override void devour()
        {
            Grass killMe = detectGrass();
            var xGrass = killMe.posX;
            var yGrass = killMe.posY;
            s.africa[xGrass, yGrass].grass = null;
            weight = weight * (killMe.weight * -1.75);
            s.godDraws();
        }

        public override void mate(Animals detecter, Animals detectee)
        {
            int ranX2 = s.r.Next(0, 20);
            int ranY2 = s.r2.Next(0, 20);
            if (detecter is Rabbit && detectee is Rabbit)
            {
                if (detecter.gender != detectee.gender)
                {
                    for (int i = 0; i < 4;)
                    {
                        s.africa[ranX2, ranY2].ani = new Rabbit(s, ranX2, ranY2);
                        i++;
                        s.godDraws();
                    }
                }
            }
        }
    }
}
