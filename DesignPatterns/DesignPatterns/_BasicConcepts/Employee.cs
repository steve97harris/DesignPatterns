using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._basicconcepts
{
    class Staff
    {
        public int staffID;
        public string staffName;
        public double salary;
        public int grade;
        public string company;

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
            Staff object = new Staff();
            object.staffID = 100;
            object.staffName = "Jeff";
        }
    }
}