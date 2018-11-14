using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Phocidae:AbstractCaniformia
    {
        private double crawlSpeed;

        public double CrawlSpeed { get => crawlSpeed; set => crawlSpeed = value; }

        private Phocidae()
        {

        }

        public Phocidae(string name)
        {
            Random rand = new Random();
            Age = (uint)rand.Next(30);
            Name = name;
            Mass = (uint)rand.Next(90, 3500);
            Length = (uint)rand.Next(125, 650);
            Speed = rand.Next(25);
            CrawlSpeed = rand.Next(2);
        }

        public new void Move(double distance)
        {
            Console.WriteLine("Животное проплыло "+ distance, " километров за "+ (distance / Speed)+ " часов");
        }

        public void Crawl(double distance)
        {
            Console.WriteLine("Животное проползло "+ distance+ " километров за "+ (distance / CrawlSpeed)+ " часов");
        }
    }
}
