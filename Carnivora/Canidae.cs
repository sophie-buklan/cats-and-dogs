using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Canidae:AbstractCaniformia
    {
        private Canidae()
        {

        }

        public Canidae(string name)
        {
            Random rand = new Random();
            Age = (uint)rand.Next(15);
            Name = name;
            Mass = (uint)rand.Next(1, 80);
            Length = (uint)rand.Next(20, 160);
            Speed = rand.Next(60);
        }
    }
}
