using System;

namespace Generics_Test_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Test Maximum");
            FindMaximum find = new FindMaximum();
            float max = find.MaximumValue(10.5f, 20.5f, 30.5f);
            Console.WriteLine("Maximum Integer Number : "+max);
        }
    }
}
