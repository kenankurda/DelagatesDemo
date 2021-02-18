using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicateDelegates
{
    // traditional delegates
    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delagate3(string str);
    class Program
    {

        static void Main(string[] args)
        {
            // .net delegate func with return value
            Func<int,float,double,double> obj1 = AddNums1;
            double result = obj1.Invoke(3, 5.5f, 5.05);
            Console.WriteLine(result);

            // .net Action delegate with no return value
            Action<int,float,double> obj2 = AddNums2;
            obj2.Invoke(5, 3.5f, 5.6);

            Predicate<string> obj3 = CheckLength;
            // Func<string, bool> obj3 = CheckLength;
            bool stringLegth = obj3.Invoke("Hello world");

            Console.WriteLine(stringLegth);

        }

        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
            {
                return true;
            }
            return false;
        }
    }
}
