using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public delegate void CalculateDelegate(int n1, int n2);
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDelegate del1 = new CalculateDelegate(Add);
            CalculateDelegate del2 = new CalculateDelegate(Subtract);
            CalculateDelegate del3 = new CalculateDelegate(Multiply);
            CalculateDelegate del4 = new CalculateDelegate(Divide);

            // add 4 delegates to del5 which is multicast delegate
            CalculateDelegate del5 = del1 + del2 + del3 + del4;
            del5.Invoke(20, 5);

            del5 -= del4;
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            del5.Invoke(10, 2);

            Console.WriteLine("------------------------------------");

            del5 += del2;
            del5 += del2;
            del5 += del2;
            del5.Invoke(6, 3);
        }
         
        public static void Add(int x, int y)
        {
            Console.WriteLine($"The Sum of {x} and {y} is {x+y}");
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"The substraction of {a} and {b} is {a-b}");
        }

        public static void Multiply(int m1, int m2)
        {
            Console.WriteLine($"The multiplication of {m1} and {m2} is {m1*m2}");
        }

        public static void Divide(int d1, int d2)
        {
            Console.WriteLine($"The Division of {d1} and {d2} is {d1 * d2}");
        }
    }
}
