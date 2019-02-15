using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy("Artem", 65, 19);
            Girl girl = new Girl("Dasha", 69, 25);

            Console.WriteLine(boy);
            boy.Voice();
            if (boy.IsMoreThanAverageWeight)
                Console.WriteLine("I'm fat");
            else
            {
                boy.ToEat = "egg";
                Console.WriteLine(boy.ToEat);
            }
            boy.Shaved();

            Console.WriteLine();

            Console.WriteLine(girl);
            girl.Voice();
            if (girl.IsMoreThanAverageWeight)
                Console.WriteLine("I'm fat");
            else
            {
                girl.ToCook = "egg";
                Console.WriteLine(girl.ToCook);
            }
            girl.ToDoMakeup();

            Console.ReadKey();
        }
    }
}
