using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {

            int favNumber = 3;
            Cube(ref favNumber);
            Console.WriteLine(favNumber);
            Console.ReadLine();
        }

        static void Cube(ref int favNumber )
        {
            favNumber = favNumber * favNumber * favNumber;
        }

            //int[] tempList = { 10, 20, 30, 40, 50 };
            //int i = 2;
            //tempList[++i] = tempList[i] * 10;
            //Console.WriteLine( string.Join(" ",tempList));
            //Console.ReadLine();

            //ClassA a = new ClassC();
            //Console.WriteLine(a.Welcome());
            //Console.ReadLine();


            //var result = TransformedString.Solution("aaaaaaaaaaa");

            //Console.WriteLine(result);
            //Console.ReadLine();

            //try
            //{
            //    int result = Divide(10, 0);
            //    Console.WriteLine($"the {result}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error in try bloc " + ex.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Finally block executed");
            //}
       // }


        public class ClassA
        {
            public virtual string Welcome()
            {
                return "welcome from ClassA";
            }
        }

        public class ClassB : ClassA
        {
            public override string Welcome()
            {
                return "welcome from class B";
            }
        }

        public class ClassC : ClassB
        {
            public override string Welcome()
            {
                return "welcome from class C";
            }
        }

        //public static int Divide(int a, int b)
        //{
        //    try
        //    {
        //        return a / b;
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.WriteLine("Error in Divide method:" + ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Finally block in divide method executed");
        //    }
        //    return 0;
        //}
    }
}
