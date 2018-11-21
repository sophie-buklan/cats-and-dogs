using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Felidae : AbstractFeliformia
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public enum Cat
        {
            Big,
            Small,
            Medium
        }

        private Felidae()
        {

        }

        public Felidae(string name, Cat subfamilia):base(name)
        {
            Random rand = new Random();
            switch (subfamilia)
            {
                case Cat.Small:
                    Age = (uint)rand.Next(30);
                    Mass = (uint)rand.Next(1, 15);
                    Length = (uint)rand.Next(40, 70);
                    Speed = rand.Next(50);
                    break;
                case Cat.Big:
                    Age = (uint)rand.Next(20);
                    Mass = (uint)rand.Next(150, 380);
                    Length = (uint)rand.Next(220, 290);
                    Speed = rand.Next(65);
                    break;
                default:
                    throw new System.ArgumentException("В конструктор передано неподходящее значение");
            }
        }
    }
}
