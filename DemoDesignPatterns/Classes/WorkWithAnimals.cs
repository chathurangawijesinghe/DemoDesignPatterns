using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public class WorkWithAnimals
    {
        int justANumber = 10;

        static void Main(string[] args)
        {
            Dog fido = new Dog();
            fido.Name = "Fido";
            Console.WriteLine(fido.Name);
            fido.DigHole();
            fido.Weight = -1;

            // Pass by value
            int randomNumber = 10;

            PassByValue passByValue = new PassByValue();
            passByValue.ChangeRandomNumber(randomNumber);

            Console.WriteLine("Random number after method call : " + randomNumber);

            // Pass by refferance
            ChangeObejctName(fido);

            Console.WriteLine("Dog name after method call : " + fido.Name);

            Animal doggy = new Dog();
            Animal kitty = new Cat();

            Console.WriteLine("Doggy says : " + doggy.Sound);
            Console.WriteLine("Kitty says : " + kitty.Sound);

            Animal[] animals = new Animal[4];
            animals[0] = doggy;
            animals[1] = kitty;

            Console.WriteLine("Doggy says : " + animals[0].Sound);
            Console.WriteLine("Kitty says : " + animals[1].Sound);

            SpeakAnimal(doggy);

            ((Dog)doggy).DigHole();

            Console.ReadKey();
        }

        static void ChangeObejctName(Dog fido)
        { 
            fido.Name = "Marcus";
        }

        static void SpeakAnimal(Animal animal)
        {
            Console.WriteLine("Animal says: " + animal.Sound);
        }
    }
}
