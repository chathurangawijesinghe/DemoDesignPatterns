using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Interfaces
{
    public interface ILiving
    {
        string Name { get; set; }
        double Height { get; set; }
        double Weight { get; set; }
        string FavFood { get; set; }
        double Speed { get; set; }
        string Sound { get; set; }
    }
}
