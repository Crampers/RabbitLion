﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            throw new NotImplementedException();
        }

        public override void devour()
        {
            Grass killMe = detectGrass();
            var xGrass = killMe.posX;
            var yGrass = killMe.posY;
            s.africa[xGrass, yGrass].grass = null;
            this.weight = weight * (killMe.weight * -1.75);
        }

        public override void mate(Animals detecter, Animals detectee)
        {
            int ranX2 = s.r.Next(0, 20);
            int ranY2 = s.r2.Next(0, 20);
            if (detecter is Rabbit && detectee is Rabbit)
            {
                if (detecter.gender != detectee.gender)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        s.africa[ranX2, ranY2].ani = new Rabbit(s, ranX2, ranY2);
                    }
                }
            }
        }
    }
}
