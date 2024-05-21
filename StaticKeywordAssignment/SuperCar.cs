using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    sealed class SuperCar
    {
        private int horsepower;
        private double maxSpeed;

        public SuperCar(int horsepower, double maxSpeed)
        {
            this.horsepower = horsepower;
            this.maxSpeed = maxSpeed;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Super Car Details:");
            Console.WriteLine("Horsepower: " + horsepower);
            Console.WriteLine("Max Speed: " + maxSpeed + " mph");
        }


    }
}
