using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class SmallCats:Felidae
    {
        private SmallCats()
        {

        }

        public SmallCats(string name)
        {
            Random rand = new Random();
            Age = (uint)rand.Next(30);
            Name = name;
            Mass = (uint)rand.Next(1, 15);
            Length = (uint)rand.Next(40, 70);
            Speed = rand.Next(50);
        }
    }
}
