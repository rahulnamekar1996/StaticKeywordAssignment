using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    public class SpecialEditionPhone
    {
        public string Model { get; }
        public string Color { get; }

        public SpecialEditionPhone(string model)
        {
            Model = model;
            Color = "Space Grey"; // Set color to "Space Grey" during initialization
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}, Color: {Color}");
        }

    }
}
