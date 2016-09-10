using DemoStrategyPattern.Interfaces;
using System;

namespace DemoStrategyPattern.Classes
{
    public class Dog : Animal
    {
        public Dog() : base()
        {
            Sound = "bark";

            flyingType = new CantFly();
        }

        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }
    }

}
