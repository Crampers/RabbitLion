using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            int gend = s.r.Next(0, 10);
            if (gend % 2 != 0)
                gender = false;
            else
            {
                gender = true;
            }
        }

        public override void move()
        {
            int nposX = posX;
            int nposY = posY;
            
            if (nposX > 19)
            {
                nposX = nposX + s.r.Next(-1, 0);
            }
            if (nposY > 19)
            {
                nposY = nposY + s.r.Next(-1, 0);
            }
            if (nposX < 0)
            {
                nposX = nposX + s.r.Next(0, 2);
            }
            if (nposY < 0)
            {
                nposY = nposY + s.r.Next(0, 2);
            }
            else
            {
                nposX = nposX + s.r.Next(-1, 2);
                nposY = nposY + s.r2.Next(-1, 2);
            }
            Lion l = new Lion(s, nposX,nposY);
            l.weight = s.africa[posX, posY].ani.weight;
            l.gender = s.africa[posX, posY].ani.gender;
            s.africa[nposX, nposY].ani = l;
            s.africa[posX, posY].ani = null;
            s.godDraws();
        }

        public override void devour()
        {
            Animals killMe = detectRabbit();
            var xRabbit = killMe.posX;
            var yRabbit = killMe.posY;
            s.africa[xRabbit, yRabbit].ani = null;
            weight = weight*(killMe.weight * -1.75);
        }

        public override void mate(Animals detecter, Animals detectee)
        {
            int ranX2 = s.r.Next(0, 20);
            int ranY2 = s.r2.Next(0, 20);
            if (detecter is Lion && detectee is Lion)
            {
                if (detecter.gender != detectee.gender)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        s.africa[ranX2, ranY2].ani = new Lion(s, ranX2, ranY2);  
                    }
                }
            }
        }
    }
}
