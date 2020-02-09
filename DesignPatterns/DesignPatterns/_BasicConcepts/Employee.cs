using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._basicconcepts
{
    class Staff
    {
        private int staffID;
        private string staffName;
        public double salary {get; set;} 
        public int grade {get; set;}
        public string company = "IBM";

        public Staff(int staffID, string staffName)
        {
            this.staffID = staffID;
            this.staffName = staffName;
        }
    }

    class TestStaff
    { 
        static void Main()
        {
            Staff objectA = new Staff(100,"Jeff");
            // objectA.staffID = 100;
            // objectA.staffName = "Jeff";
            objectA.salary = 200000;

            Staff objectB = new Staff(200,"Steve");
        }
    }
}