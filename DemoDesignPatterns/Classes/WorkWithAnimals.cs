using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public class WorkWithAnimals
    {
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

            Console.ReadKey();
        }

        static void ChangeObejctName(Dog fido)
        { 
            fido.Name = "Marcus";
        }
    }
}
