using System;


namespace ConsoleApp3
{

    class Program
    {
        public static void starPattern1()
        {
            //write your code here
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

        public static void starPattern2()
        {
            //write your code here
            int i, j, k;
            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 5; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void starPattern3()
        {
            //write your code here
            int i, j;
            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void starPattern4()
        {
            //write your code here
            int i, j, k;
            for (i = 5; i >= 1; i--)
            {
                for (j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void starPattern5()
        {
            //write your code here
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void starPattern6()
        {
            //write your code here
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void starPattern7()
        {
            //write your code here
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void starPattern8()
        {
            //write your code here
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    if (i == 5 || j == 1 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static void starPattern9()
        {
            //write your code here
            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void starPattern10()
        {
            //write your code here
            int i, j, k;
            for (i = 5; i >= 1; i--)
            {
                for (j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            starPattern1();
            starPattern2();
            starPattern3();
            starPattern4();
            starPattern5();
            starPattern6();
            starPattern7();
            starPattern8();
            starPattern9();
            starPattern10();
        }
    }
}
