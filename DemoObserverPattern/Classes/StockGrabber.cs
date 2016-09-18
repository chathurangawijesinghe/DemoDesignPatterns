using DemoObserverPattern.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern.Classes
{
    public class StockGrabber : Subject
    {
        private List<Observer> observers;
        private double ibmPrice;
        private double applePrice;
        private double googlePrice;

        public StockGrabber()
        {
            observers = new List<Observer>();
        }

        public void NotifyObserver()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(IbmPrice, ApplePrice, GooglePrice);
            }
        }

        public void Register(Observer observer)
        {
            observers.Add(observer);
        }

        public void Unregister(Observer observer)
        {
            int observerIndex = observers.IndexOf(observer);
            Console.WriteLine("Observer " + (observerIndex + 1) + " deleting");
            bool isRemoved = observers.Remove(observer);
            Console.WriteLine("Observer deleted :" + isRemoved);
        }

        public double IbmPrice
        {
            get
            {
                return ibmPrice;
            }

            set
            {
                ibmPrice = value;
                NotifyObserver();
            }
        }

        public double ApplePrice
        {
            get
            {
                return applePrice;
            }

            set
            {
                applePrice = value;
                NotifyObserver();
            }
        }

        public double GooglePrice
        {
            get
            {
                return googlePrice;
            }

            set
            {
                googlePrice = value;
                NotifyObserver();
            }
        }

    }
}
