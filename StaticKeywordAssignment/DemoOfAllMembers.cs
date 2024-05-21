using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    public class DemoOfAllMembers
    {
        static int staticVar = 10; // Static variable

        // Default constructor
        public DemoOfAllMembers()
        {
            Console.WriteLine("Default constructor called.");
        }

        // Parameterized constructor
        public DemoOfAllMembers(int value)
        {
            Console.WriteLine("Parameterized constructor called with value: " + value);
        }

        // Static method
        public static void StaticMethod()
        {
            Console.WriteLine("Static method called.");
        }

        // Instance method
        public void InstanceMethod()
        {
            Console.WriteLine("Instance method called.");
        }

    }
}
