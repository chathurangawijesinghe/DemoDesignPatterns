using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNullObject.Classes
{
    public class NullCustomer : AbstractCustomer
    {
        public override bool IsNull()
        {
            return true;
        }

        public override string Name
        {
            get
            {
                return "Not Available in Customer Database";
            }
            set
            {
                name = value;
            }
        }
    }
}
