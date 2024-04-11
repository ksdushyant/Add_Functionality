using System;
using System.ComponentModel;
namespace prac
{
    class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Convert.ToInt32(Add(num1, num2));
            Console.WriteLine("Sum {0} + {1} = {2}",num1, num2, result);
        }
    }
}
