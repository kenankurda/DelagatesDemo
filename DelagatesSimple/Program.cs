using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesSimple
{
    //public delegate void AddDelegate(int x, int y);
    //public delegate string GreetingsDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            //
            //AddDelegate addDelegate = new AddDelegate(AddNumbers);
            //addDelegate(3, 2);
            //addDelegate.Invoke(3, 2);

            Action<int, int, string> addDelegate =  AddNumbers;
            
            addDelegate(3, 2, "The sum of");


            //AddDelegate subtract = new AddDelegate(Subtract);
            //subtract(8, 2);
            Action<int, int, string> subtract = Subtract;
            subtract(8,2, "The subtraction of");


            //GreetingsDelegate greetingsDelegate = new GreetingsDelegate(Greetings);
            //string result = greetingsDelegate("Hello c# group");
            //string result = greetingsDelegate.Invoke("Hello c# group");

            Func<string, string> greetingsDelegate = Greetings;
            string result =  greetingsDelegate("Hello c# group");

            Console.WriteLine(result);


            Func<string, string> sayHello = SayHello;
            string sayHelloresult = sayHello("Hello");

            //GreetingsDelegate sayHello = new GreetingsDelegate(SayHello);
            //string sayHelloresult = sayHello("Hello");
            Console.WriteLine(sayHelloresult);

        }

        public static void AddNumbers(int a, int b, string s)
        {
            Console.WriteLine($"{s}  {a} and {b} is {a+b}" );
        }


        public static void Subtract(int a, int b, string s)
        {
            Console.WriteLine($"{s} {a} and {b} is {a/b}");
        }


        public static string Greetings(string str)
        {
            return str;
        }

        public static string SayHello(string str)
        {
            return str;
        }
    }
}
