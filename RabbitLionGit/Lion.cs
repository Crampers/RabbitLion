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
            s.africa[x, y].ani.weight = 50;
            int gend = s.r.Next(0, 10);
            if (gend %2 != 0)
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
            do
            {
                if (detect())
                {
                    
                }
            } while (true);
        }
    }
}
