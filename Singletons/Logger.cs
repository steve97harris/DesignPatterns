using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.singletons
{
    class Logger        // Logger, used to create a customized error log file or log specific events.
    {
        static void Main()
        {
            Logger object1 = new Logger();
            Logger object2 = new Logger();
        }
    }
}
