using DemoDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public class Monkey : ILiving
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string FavFood { get; set; }
        public double Speed { get; set; }
        public string Sound { get; set; }
    }
}
