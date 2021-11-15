using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   // public delegate void MyDelegate(int n, int m);
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
          //  MyDelegate del = Calculator.ADD;
            //// del += Calculator.SUB;
            // del += Calculator.MUL;
            //  del += Calculator.DIV;
            //  Console.WriteLine("")
            //del.Invoke(a,b);
            //  Calculator c = new Calculator();
            //Calculator.ADD(a, b);

            Console.WriteLine("ssssssssssssss");        
        }
      

    }

    public class Calculator
    {
        public static void ADD(int a, int b)
        {
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaa");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public static void SUB(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public static void MUL(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a + b);
        }
        public static void DIV(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a + b);
        }
    }


}
