using DemoStrategyPattern.Interfaces;
using System;

namespace DemoStrategyPattern.Classes
{
    public class Animal{
        private string name;

        public Flys flyingType;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private int weight;

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Weight must be bigger than 0");
                }
            }
        }
        private string sound;

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public string TryToFly()
        {
            return flyingType.fly();
        }

        public void SetFlyingAbility(Flys flyingType)
        {
            this.flyingType = flyingType;
        }
    }
}
