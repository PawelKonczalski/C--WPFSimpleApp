using System;
using System.Collections.Generic;
using System.Text;

namespace eventsAndDelegates
{
    class MyObject
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg + "object");
        }
        public MyObject(Simulation simulation)
        {
            simulation.listOfSubscribes += Print;
        }
    }
}
