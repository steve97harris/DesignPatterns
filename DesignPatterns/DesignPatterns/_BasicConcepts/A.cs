using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._basicconcepts
{
    class A
    {
        public virtual void MethodA()
        {
            Console.WriteLine("A - MA");
        }
    }

    class B : A
    {
        public override void MethodA()
        {
            Console.WriteLine("B - MA");
        }
        public void MethodB()
        {
            Console.WriteLine("B - MB");
        }
    }

    class Test
    {
        static void MainOLD()
        {
            // Console.WriteLine("A object");
            // A aobject = new A();
            // aobject.MethodA();

            Console.WriteLine("B object");
            B bobject = new B();
            bobject.MethodA();
            bobject.MethodB();
            
            Console.WriteLine("A or B?");
            // Superclass object = new Subclass();
            int x = 23;

            A object1 = new B();
            object1.MethodA();
            (object1 as B).MethodB();

            // B object2 = new A(); (Can't do this).
        }
    }
}