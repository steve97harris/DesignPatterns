﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.singletons
{
    class TestLogger        // Logger, used to create a customized error log file or log specific events.
    {
        static void Main()      // Static, relates to the type itself, rather than an instance of the type. 
        {
            // Logger object1 = new Logger();
            // Logger object2 = new Logger();
            Console.WriteLine("---Singleton---");
            Logger object1 = Logger.GetInstance();
            Logger object2 = Logger.GetInstance();
            Console.WriteLine(object1.GetHashCode());
            Console.WriteLine(object2.GetHashCode());


            Console.WriteLine("---Non Singleton---");
            Test object3 = new Test();
            Test object4 = new Test();
            Console.WriteLine(object3.GetHashCode());
            Console.WriteLine(object4.GetHashCode());
        }
    }

    class Test
    {

    }
}
