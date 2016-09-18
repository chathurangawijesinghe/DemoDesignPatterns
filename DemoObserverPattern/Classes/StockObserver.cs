using DemoObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern.Classes
{
    public class StockObserver : Observer
    {
        private double ibmPrice;
        private double applePrice;
        private double googlePrice;

        private static int observerIDTracker = 0;

        private int observerID;

        private Subject stockGrabber;

        public StockObserver(Subject stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            this.observerID = ++observerIDTracker;
            Console.WriteLine("New Observer " + this.observerID);
            stockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double applePrice, double googlePrice)
        {
            this.ibmPrice = ibmPrice;
            this.applePrice = applePrice;
            this.googlePrice = googlePrice;

            PrintThePrices();
        }

        public void PrintThePrices()
        {
            Console.WriteLine(observerID + "\nIBM: " + ibmPrice + "\nApple: " + applePrice + "\nGoogle: " + googlePrice + "\n");
        }
    }
}
