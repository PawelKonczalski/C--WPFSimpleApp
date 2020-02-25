using System;
using System.Collections.Generic;
using System.Text;

namespace eventsAndDelegates
{
    class Simulation
    {
        public delegate void OnEventThatCurrentTimeIsEven(string msg);
        // private OnEventThatCurrentTimeIsEven _listOfSubscribers;
        public event OnEventThatCurrentTimeIsEven listOfSubscribes
        /*
        {
            add
            {
                _listOfSubscribers += value;
            }
            remove
            {
                _listOfSubscribers -= value;
            }
        }
        */
        public int CurrentTime;
        public void simulation()
        {
            while(CurrentTime < 10)
            {
                if((CurrentTime%2) == 0)
                {
                Console.WriteLine(CurrentTime);
                    raiseEventCurrentTimeIsEven();
                }

                System.Threading.Thread.Sleep(100);
                CurrentTime++;
            }
        }

        public void raiseEventCurrentTimeIsEven()
        {
            if (listOfSubscribes != null)
                listOfSubscribes("Current time is Event ");
        }
        public Simulation()
        {
            CurrentTime = 0;
        }
    }
}
