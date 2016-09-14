using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNullObject.Classes
{
    public class CustomerFactory
    {
        public static readonly string[] names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer GetCustomer(string name)
        {
            if (names.Contains(name))
            {
                return new RealCustomer(name);
            }
            return new NullCustomer();
        }
    }
}
