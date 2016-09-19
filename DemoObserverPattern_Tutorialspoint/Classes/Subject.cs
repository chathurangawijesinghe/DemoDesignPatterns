using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern_Tutorialspoint.Classes
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int State
        {
            get { return state; }
            set 
            { 
                state = value;
                NotifyAllObservers();
            }
        }

        private void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        
    }
}
