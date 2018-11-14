using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class Program
    {
        static void Main(string[] args)
        {
            BigCats tiger = new BigCats("Тигра");
            Canidae dog = new Canidae("Doge");
            Canidae dog1 = new Canidae("Белый Бим");
            AbstractCaniformia seal = new Phocidae("Лень");
            Phocidae seal1 = new Phocidae("Тюлень любви");
            Felidae myCat = new SmallCats("Ксюха");
            AbstractFeliformia myCat1 = new SmallCats("Макс");
            Ursidae bear = new Ursidae("Винни-Пух");
            AbstractCarnivora viver = new Viverridae("Кофеман");
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

            Console.ReadKey();
        }
    }
}
