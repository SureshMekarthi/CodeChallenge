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

            var result = TransformedString.Solution("aaaaaaaaaaa");

            Console.WriteLine(result);
            Console.ReadLine();

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
        }

        public static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error in Divide method:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block in divide method executed");
            }
            return 0;
        }
    }
}
