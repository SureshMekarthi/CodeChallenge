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
                



            //var popleCollection = new List<People>
            //            {
            //                new People{ Age=21, Name="Test1"},
            //                new People{ Name="Test2", Age=22},
            //                 new People{ Age=23, Name="Test3"},
            //                new People{ Name="Test4", Age=24},
            //                new People{ Age=21, Name="Test1"},
            //                new People{ Name="Test5", Age=22},
            //                 new People{ Age=23, Name="Test3"},
            //                new People{ Name="Test6", Age=24},
            //            };

            //var groupbyCondition = popleCollection.Where(w => w.Age > 20).GroupBy(g => g.Age).ToList();

            //foreach (var person in groupbyCondition)
            //{
            //    Console.WriteLine(person.Key);

            //    foreach (var item in person)
            //    {
            //         Console.WriteLine($"{item.Name} {item.Age}");
            //    }
            //}


            //int[] tempArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //Add50ToSome(tempArray);

            //int x =10, y =20;

            //while (x++ <= 10)
            //{
            //    y = ++y + x;
            //}

            //Console.WriteLine("$the value of x: {x}");
            //Console.WriteLine("$the value of x: {y}");

            Console.ReadLine();


            //int favNumber = 3;
            //Cube(ref favNumber);
            //Console.WriteLine(favNumber);
            Console.ReadLine();
        }

        private static void PrintHello(int i)
        {
            if(i<=50)
            {
                Console.WriteLine("$ hello {i}");
                PrintHello(i+1); 
            }
            else
            {
                return;
            }
        }


        static void Add50ToSome(int[] localArray)
        {
            for (int i = 0; i < localArray.Length; i += 5)
            {
                localArray[i] += 50;
            }
        }
        static void Cube(ref int favNumber)
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


        public class People
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

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
