﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public abstract class Creature
    {
        protected string name;
        protected int weight;
        protected string sound;

        public abstract string Name
        {
            get;
            set;
        }

        public abstract int Weight
        {
            get;
            set;
        }

        public abstract string Sound
        {
            get;
            set;
        }
    }
}
