using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Ursidae:AbstractCaniformia
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private Ursidae()
        {

        }

        public Ursidae(string name) : base(name)
        {
            Random rand = new Random();
            Age = (uint)rand.Next(20);
            Mass = (uint)rand.Next(60, 900);
            Length = (uint)rand.Next(150, 300);
            Speed = rand.Next(40);
        }
    }
}
