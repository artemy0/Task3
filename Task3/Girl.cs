using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Girl : Human
    {
        public Girl(string name, double weight, int age) : base(name, weight, age)
        {
        }
        public Girl(string name, double weight) : base(name, weight)
        {
        }
        public Girl()
        {
        }

        //overriding methods and properties of a base class
        public override bool IsMoreThanAverageWeight
        {
            get
            {
                //68 kg is the average weight of women.
                return Weight > 68.0;
            }
        }
        public override void Voice()
        {
            Console.WriteLine("I am girl.");
        }

        //adding new methods and properties into subclasses
        public void ToDoMakeup()
        {
            Console.WriteLine("I did makeup.");
        }
        private string Food;
        public string ToCook
        {
            get { return $"I cooked {Food}"; }
            set
            {
                if (value != null)
                    Food = value;
                else
                {
                    Console.Write("Enter what are you going to cook: ");
                    Food = Console.ReadLine();
                }
                Console.WriteLine($"I'm cooking {Food}");
            }
        }
    }
}
