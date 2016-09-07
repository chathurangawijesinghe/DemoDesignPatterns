using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public class Giraffe : Creature
    {
        public override string Name
        {
            get;
            set;
        }

        public override int Weight
        {
            get;
            set;
        }

        public override string Sound
        {
            get;
            set;
        }
    }
}
