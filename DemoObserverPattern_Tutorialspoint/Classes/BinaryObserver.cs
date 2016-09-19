﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern_Tutorialspoint.Classes
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(subject.State, 2));
        }
    }
}
