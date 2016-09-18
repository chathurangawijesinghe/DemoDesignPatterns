using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern.Classes
{
    public class GrabStocks
    {
        static void Main(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver observer1 = new StockObserver(stockGrabber);

            stockGrabber.IbmPrice = 197.00;
            stockGrabber.ApplePrice = 677.00;
            stockGrabber.GooglePrice = 676.40;

            StockObserver observer2 = new StockObserver(stockGrabber);

            stockGrabber.IbmPrice = 197.00;
            stockGrabber.ApplePrice = 677.00;
            stockGrabber.GooglePrice = 676.40;

            Console.ReadKey();
        }
    }
}
