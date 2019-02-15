using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Boy : Human
    {
        public Boy(string name, double weight, int age) : base(name, weight, age)
        {
        }
        public Boy(string name, double weight) : base(name, weight)
        {
        }
        public Boy()
        {
        }

        //overriding methods and properties of a base class
        public override bool IsMoreThanAverageWeight
        {
            get
            {
                //82 kg is the average weight of men.
                return Weight > 82.0;
            }
        }
        public override void Voice()
        {
            Console.WriteLine("I am boy.");
        }

        //adding new methods and properties into subclasses
        public void Shaved()
        {
            Console.WriteLine("I shaved.");
        }
        private string Food;
        public string ToEat
        {
            get { return $"I eated {Food}"; }
            set
            {
                if (value != null)
                    Food = value;
                else
                {
                    Console.Write("Enter what are you going to eat: ");
                    Food = Console.ReadLine();
                }
                Console.WriteLine($"I'm eating {Food}");
            }
        }
    }
}
