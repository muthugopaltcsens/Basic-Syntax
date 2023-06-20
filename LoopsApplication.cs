using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            Console.ReadLine();
        }
    }
}




//using System;

//namespace Loops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            /* for loop execution */
//            for (int a = 10; a < 20; a = a + 1)
//            {
//                Console.WriteLine("value of a: {0}", a);
//            }
//            Console.ReadLine();
//        }
//    }
//}



//using System;

//namespace Loops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            /* local variable definition */
//            int a = 10;

//            /* do loop execution */
//            do
//            {
//                Console.WriteLine("value of a: {0}", a);
//                a = a + 1;
//            }
//            while (a < 20);
//            Console.ReadLine();
//        }
//    }
//}



//using System;

//namespace Loops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            /* local variable definition */
//            int i, j;

//            for (i = 2; i < 100; i++)
//            {
//                for (j = 2; j <= (i / j); j++)
//                    if ((i % j) == 0) break; // if factor found, not prime
//                if (j > (i / j)) Console.WriteLine("{0} is prime", i);
//            }
//            Console.ReadLine();
//        }
//    }
//}