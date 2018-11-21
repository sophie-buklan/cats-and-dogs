using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Viverridae : AbstractFeliformia
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private Viverridae()
        {

        }

        public Viverridae(string name):base(name)
        {

            Random rand = new Random();
            Age = (uint)rand.Next(20);
            Mass = (uint)rand.Next(2, 15);
            Length = (uint)rand.Next(50, 70);
            Speed = rand.Next(45);
        }
    }
}
