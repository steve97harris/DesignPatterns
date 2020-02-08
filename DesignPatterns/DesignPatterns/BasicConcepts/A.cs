using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.basicconcepts
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
        static void Main()
        {
            Console.WriteLine("A object");
            A aobject = new A();
            aobject.MethodA();

            Console.WriteLine("B object");
            B bobject = new B();
            bobject.MethodA();
            bobject.MethodB();
            
            Console.WriteLine("A or B?");
            // Superclass object = new Subclass();
            int x = 10;
            A object1 = new B();
            object1.MethodA();

            // B object2 = new A(); (Can't do this).
        }
    }
}