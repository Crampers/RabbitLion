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
            throw new NotImplementedException();
        }

        public override void devour()
        {
            Animals killMe = detectRabbit();
            var xRabbit = killMe.posX;
            var yRabbit = killMe.posY;
            s.africa[xRabbit, yRabbit].ani = null;
        }

        public override void mate(Animals detecter, Animals detectee)
        {
            int ranX2 = s.r.Next(0, 20);
            int ranY2 = s.r2.Next(0, 20);
            if (detecter is Lion && detectee is Lion)
            {
                if (detecter.gender != detectee.gender)
                {
                    s.africa[ranX2, ranY2].ani = new Lion(s, ranX2, ranY2);
                }
            }
        }
    }
}
