using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class BigCats : Felidae
    {
        private BigCats()
        {

        }

        public BigCats(string name)
        {
            Random rand = new Random();
            Age = (uint)rand.Next(20);
            Name = name;
            Mass = (uint)rand.Next(150, 380);
            Length = (uint)rand.Next(220,290);
            Speed = rand.Next(65);
        }
    }
}
