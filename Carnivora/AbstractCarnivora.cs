using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace Carnivora
{
    
    abstract class AbstractCarnivora
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private uint age;
        private string name;
        private uint mass;
        private uint length;
        private double speed;

        public uint Age { get => age; set => age = value; }
        [Name(DefaultName = "Котопёс")]
        public string Name { get => name; set => name = value; }
        public uint Mass { get => mass; set => mass = value; }
        public uint Length { get => length; set => length = value; }
        public double Speed { get => speed; set => speed = value; }

        protected AbstractCarnivora()
        {

        }

        public AbstractCarnivora(string name)
        {
            //var props = typeof(AbstractCarnivora).GetProperties();//.GetCustomAttributes(false);
           // NameAttribute nameAttr = props[0] as NameAttribute;
           // name = nameAttr.DefaultName;
            logger.Debug("имя " + name);
            if (name != "")
                Name = name;
            else
            {
                logger.Warn("Пустое имя");
                throw new ArgumentException("Имя не должно быть пустым");
            }
        }

        public void Sleep(double hours)
        {
            logger.Debug("Метод Sleep запущен с параметром hours=" + hours);
            Console.WriteLine("Животное проспало "+ hours+ " часов");
        }

        public void Eat(string food)
        {
            logger.Debug("Метод Eat запущен с параметром food=" + food);
            Console.WriteLine("Съедена порция "+ food);
        }

        public void Breed(AbstractCarnivora partner)
        {
            logger.Debug("Метод Breed запущен с параметром partner=" + partner.ToString(true));
            Console.WriteLine("Животное спарилось с "+ partner.Name);
        }

        public void Move(double distance)
        {
            logger.Debug("Метод Move запущен с параметром distance=" + distance);
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
