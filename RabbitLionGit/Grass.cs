using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitLionGit
{
    class Grass
    {
        public double weight = 1.00;

        //Grow makes the grass increase in size with every tick
        private void grow()
        {
            weight = weight * 1.1;
        }
    }
}
