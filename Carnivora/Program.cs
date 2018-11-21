using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace Carnivora
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            //демонстрация работы объектов классов
            Felidae tiger = null;
            Canidae dog = null;
            Canidae dog1 = null;
            AbstractCaniformia seal = null;
            Phocidae seal1 = null;
            Felidae myCat = null;
            AbstractFeliformia myCat1 = null;
            Ursidae bear = null;
            AbstractCarnivora viver = null;
            dog1 = new Canidae("Белый Бим");
            seal = new Phocidae("Лень");
            seal1 = new Phocidae("Тюлень любви");
            bear = new Ursidae("Винни-Пух");
            viver = new Viverridae("Кофеман");
            try
            {
                tiger = new Felidae("Тигра", Felidae.Cat.Big);
            }
            catch (ArgumentException ex)
            {
                logger.Warn($"{ex.Message}" + " Объект создан с параметром по умолчанию");
                tiger = new Felidae("Тигра", Felidae.Cat.Big);
            }
            try
            {
                myCat = new Felidae("Ксюха", Felidae.Cat.Small);
            }
            catch (ArgumentException ex)
            {
                logger.Warn($"{ex.Message}" + " Объект создан с параметром по умолчанию");
                myCat = new Felidae("Ксюха", Felidae.Cat.Small);
            }
            try
            {
                myCat1 = new Felidae("Макс", Felidae.Cat.Medium);
            }
            catch (ArgumentException ex)
            {
                logger.Warn($"{ex.Message}"+" Объект создан с параметром по умолчанию");
                myCat1 = new Felidae("Макс", Felidae.Cat.Big);
            }
            try
            {
                Console.WriteLine("Введите имя собаки");
                dog = new Canidae(Console.ReadLine());
            }
            catch (ArgumentException ex)
            {
                logger.Warn($"{ex.Message}" + " Объект создан с параметром по умолчанию");
                dog = new Canidae("Собака");
            }
            Console.WriteLine(tiger.Name);
            tiger.Sleep(3);
            tiger.Move(5);
            Console.WriteLine(viver.Name);
            viver.Move(5);
            viver.Eat("гусеница");
            Console.WriteLine(seal.Name);
            seal.Move(5);
            Console.WriteLine(seal1.Name);
            seal1.Breed(seal);
            Console.WriteLine(dog);
            Console.WriteLine(dog1);
            dog1.Eat("корм");
            Console.WriteLine(bear);
            bear.Move(30);
            Console.WriteLine(seal1.Name);
            seal1.Crawl(1.4);
            Console.WriteLine(myCat1);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();

            //демонстрация работы коллекций
            var catsAndDogs = new List<AbstractCarnivora>();
            catsAndDogs.Add(tiger);
            catsAndDogs.Add(dog);
            catsAndDogs.Add(dog1);
            catsAndDogs.Add(seal);
            catsAndDogs.Add(seal1);
            catsAndDogs.Add(myCat);
            catsAndDogs.Add(myCat1);
            catsAndDogs.Add(bear);
            catsAndDogs.Add(viver);
            Console.WriteLine("Сортировка животных по имени");
            catsAndDogs.Sort(delegate (AbstractCarnivora predator1, AbstractCarnivora predator2)
            { return predator1.Name.CompareTo(predator2.Name); });
            foreach(AbstractCarnivora predator in catsAndDogs)
            {
                Console.WriteLine(predator.ToString(true));
            }
            Console.WriteLine("Сортировка животных по массе");
            catsAndDogs.Sort(delegate (AbstractCarnivora predator1, AbstractCarnivora predator2)
            { return predator1.Mass.CompareTo(predator2.Mass); });
            foreach (AbstractCarnivora predator in catsAndDogs)
            {
                Console.WriteLine(predator.ToString(true));
            }
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
