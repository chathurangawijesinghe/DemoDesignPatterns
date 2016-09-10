using DemoStrategyPattern.Interfaces;
using System;

namespace DemoStrategyPattern.Classes
{
    public class WorkWithAnimals
    {
        static void Main(string[] args)
        {
            Animal sparky = new Dog();

            Animal tweety = new Bird();

            sparky.SetFlyingAbility(new ItFlys());

            Console.WriteLine("Dog : " + sparky.TryToFly());
            Console.WriteLine("Bird : " + tweety.TryToFly());

            Console.ReadKey();
        }
    }
}
