using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern_Tutorialspoint.Classes
{
    class ObserverPatternDemo
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.State = 15;
            Console.WriteLine("First state change: 10");
            subject.State = 10;

            Console.ReadKey();
        }
    }
}
