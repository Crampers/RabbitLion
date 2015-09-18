using System;
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
            throw new NotImplementedException();
        }
    }
}
