using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Viverridae : AbstractFeliformia
    {
        private Viverridae()
        {

        }

        public Viverridae(string name)
        {
            Random rand = new Random();
            Age = (uint)rand.Next(20);
            Name = name;
            Mass = (uint)rand.Next(2, 15);
            Length = (uint)rand.Next(50, 70);
            Speed = rand.Next(45);
        }
    }
}
