using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern.Interfaces
{
    public interface Observer
    {
        void Update(double ibmPrice, double applePrice, double googlePrice);
    }
}
