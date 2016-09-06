using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public abstract class Creature
    {
        private string name;
        private int weight;
        private string sound;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public string Sound
        {
            get
            {
                return sound;
            }

            set
            {
                sound = value;
            }
        }
    }
}
