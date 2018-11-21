using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Canidae:AbstractCaniformia
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private Canidae()
        {

        }

        public Canidae(string name):base(name)
        {
            Random rand = new Random();
            Age = (uint)rand.Next(15);
            Mass = (uint)rand.Next(1, 80);
            Length = (uint)rand.Next(20, 160);
            Speed = rand.Next(60);
        }
    }
}
