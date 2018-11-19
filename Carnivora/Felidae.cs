using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Felidae : AbstractFeliformia
    {
        public enum Cat
        {
            Big,
            Small
        }

        private Felidae()
        {

        }

        public Felidae(string name, Cat size)
        {
            Random rand = new Random();
            if (size == Cat.Small)
            {
                Age = (uint)rand.Next(30);
                Name = name;
                Mass = (uint)rand.Next(1, 15);
                Length = (uint)rand.Next(40, 70);
                Speed = rand.Next(50);
            }
            else
            {
                Age = (uint)rand.Next(20);
                Name = name;
                Mass = (uint)rand.Next(150, 380);
                Length = (uint)rand.Next(220, 290);
                Speed = rand.Next(65);
            }
        }
    }
}
