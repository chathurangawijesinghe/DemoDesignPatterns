using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public class Animal{
        private string name;

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
    }
}
