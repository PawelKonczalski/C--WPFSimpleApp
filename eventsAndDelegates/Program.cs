using System;

namespace eventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            MyObject myObject = new MyObject(simulation);
            MySecondObject mySecondObject = new MySecondObject(simulation);

            simulation.simulation();
            Console.ReadLine();

        }
    }
}
