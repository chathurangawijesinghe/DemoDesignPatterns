using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Classes
{
    public class PassByValue
    {
        public void ChangeRandomNumber(int randomNumber)
        {
            randomNumber = 12;

            Console.WriteLine("Random number value in method : " + randomNumber);
        }
    }
}
