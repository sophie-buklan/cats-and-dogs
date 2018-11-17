using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    abstract class AbstractCarnivora
    {
        private uint age;
        private string name;
        private uint mass;
        private uint length;
        private double speed;

        public uint Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public uint Mass { get => mass; set => mass = value; }
        public uint Length { get => length; set => length = value; }
        public double Speed { get => speed; set => speed = value; }

        public void Sleep(double hours)
        {
            Console.WriteLine("Животное проспало "+ hours+ " часов");
        }

        public void Eat(string food)
        {
            Console.WriteLine("Съедена порция "+ food);
        }

        public void Breed(AbstractCarnivora partner)
        {
            Console.WriteLine("Животное спарилось с "+ partner.Name);
        }

        public void Move(double distance)
        {
            Console.WriteLine("Животное прошло "+ distance+ " километров за "+ (distance / Speed)+ " часов");
        }

        public override string ToString()
        {
            return "Возраст " + Age + "\n" + "Имя " + Name + "\n" + "Масса " + Mass + "\n" + "Длина тела " + Length + "\n" + "Скорость " + Speed + "\n";
        }

        public string ToString(bool inLine)
        {
            if (inLine)
                return "Возраст " + Age + " \t" + "Имя " + Name + " \t" + "Масса " + Mass + " \t" + "Длина тела " + Length + " \t" + "Скорость " + Speed + " \t";
            else return ToString();
        }
    }
}
