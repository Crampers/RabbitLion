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
            s.africa[x, y].ani.weight = 10;
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
        }
    }
}
