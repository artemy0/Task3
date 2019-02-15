using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Human(string name, double weight, int age) : this(name, weight)
        {
            Age = age;
        }
        public Human(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public Human()
        {
        }

        //properties that we override
        public virtual bool IsMoreThanAverageWeight
        {
            get
            {
                //75 kg is the average weight of women and men.
                return Weight > 75.0;
                //I can create AverageWeight hield and override it in derived class without override property, but in Task said "epresent similarities by overriding properties of a base class".
            }
        }

        //the method that we override
        public virtual void Voice()
        {
            Console.WriteLine("I am human.");
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}";
        }
    }
}
