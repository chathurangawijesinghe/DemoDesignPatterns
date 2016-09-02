using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public class Dog : Animal
    {
        public Dog()
            : base()
        {
            Sound = "bark";
        }

        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }
    }

}
