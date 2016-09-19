﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern_Tutorialspoint.Classes
{
    class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(subject.State, 8));
        }
    }
}
