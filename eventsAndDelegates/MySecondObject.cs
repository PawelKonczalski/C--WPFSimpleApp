using System;
using System.Collections.Generic;
using System.Text;

namespace eventsAndDelegates
{
    class MySecondObject
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg + "second object");
        }
        public MySecondObject(Simulation simulation)
        {
            simulation.listOfSubscribes += Print;
        }
    }
}
