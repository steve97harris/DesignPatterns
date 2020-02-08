using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.singletons
{
    class TestLogger        // Logger, used to create a customized error log file or log specific events.
    {
        static void Main()
        {
            // Logger object1 = new Logger();
            // Logger object2 = new Logger();
            Logger object1 = Logger.GetInstance();
            Logger object2 = Logger.GetInstance();
            Console.WriteLine(object1.GetHashCode());
            Console.WriteLine(object2.GetHashCode());
        }
    }
}
