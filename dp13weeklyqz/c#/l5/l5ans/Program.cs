using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5question
{
    class Program
    {

        public static void answer1()
        {
            //write your code here
            int times = int.Parse(Console.ReadLine());  
            int[] num = new int[times];
            int a = 0;
            for (int i = 0; i < times; i++)       
            {                                                
                num[i] = int.Parse(Console.ReadLine());    
            }
            //              2 <  10
            for (int i = 1; i < num[times - 1]; i++)   
            {
                for (int j = 0; j < times; j++)   
                {
                    if (i == num[j])             
                    {
                        a = 0;                      
                        j = times;              
                    }
                    else if (i != num[j])    
                    {
                        a = 1;
                    }
                }

                if (a != 0)   
                {
                    Console.WriteLine(i);    
                }
            }

            for (int i = 0; i < times; i++)
            {
                if (i + 1 == num[i])
                {
                    a = 0;
                }
                else if (i + 1 != num[i])
                {
                    a = 1;
                    i = times;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Good Job");
            }
        }

        public static void answer2()
        {
            //write your code here
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                string[] line = Console.ReadLine().Split(' ');
                int noads = int.Parse(line[0]);
                int yesads = int.Parse(line[1]);
                int adcost = int.Parse(line[2]);
                Console.WriteLine(yesads - adcost > noads ? "advertise" : yesads - adcost == noads ? "does not matter" : "do not advertise");
            }

        }

        public static void answer3()
        {
            //write your code here
            int cases = int.Parse(Console.ReadLine());
            int sum = 0;
            while (cases-- > 0)
            {
                string line = Console.ReadLine();
                int num = int.Parse(line.Substring(0, line.Length - 1));
                int pow = int.Parse(line.Substring(line.Length - 1));
                sum += (int)Math.Pow(num, pow);
            }
            Console.WriteLine(sum);
        }

        public static void answer4()
        {
            //write your code here
            string[] nums = Console.ReadLine().Split(' ');
            int cases = int.Parse(nums[0]);
            double hypot = Math.Sqrt(Math.Pow(int.Parse(nums[1]), 2) + Math.Pow(int.Parse(nums[2]), 2));
            while (cases-- > 0)
                Console.WriteLine(int.Parse(Console.ReadLine()) <= hypot ? "DA" : "NE");
        }

        public static void answer5()
        {
            //write your code here
            string line = Console.ReadLine();
            int space = line.IndexOf(' ');
            int day = int.Parse(line.Substring(0, space));
            int month = int.Parse(line.Substring(space + 1));
            for (int x = 1; x < month; x++)
            {
                switch (x)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        day += 31;
                        break;
                    case 2:
                        day += 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day += 30;
                        break;
                }
            }
            day %= 7;
            Console.WriteLine(day == 0 ? "Wednesday" : day == 1 ? "Thursday" : day == 2 ? "Friday" : day == 3 ? "Saturday" : day == 4 ? "Sunday" : day == 5 ? "Monday" : "Tuesday");
        }

        public static void answer6()
        {
            //write your code here
            int low = int.Parse(Console.ReadLine()) - 1;
            int high = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            while (low++ <= high)
            {
                char[] digits = low.ToString().ToCharArray();
                int sum = 0;
                foreach (char s in digits)
                    sum += int.Parse(s + "");
                if (sum == x)
                {
                    if (min == 0)
                    {
                        min = low;
                        max = low;
                    }
                    max = low;
                }
            }
            Console.WriteLine(min + "\n" + max);
        }

        public static void answer7()
        {
            //write your code here
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int num = int.Parse(Console.ReadLine());
                string[] cities = new string[num];
                for (int x = 0; x < num; x++)
                    cities[x] = Console.ReadLine();
                Console.WriteLine(cities.Distinct().Count());
            }
        }

        public static void answer8()
        {
            //write your code here
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                string[] line = Console.ReadLine().Split(' ');
                double first = double.Parse(line[0]);
                double sec = double.Parse(line[1]);
                double thi = double.Parse(line[2]);
                if (first + sec == thi || first == sec + thi)
                    Console.WriteLine("Possible");
                else if (first - sec == thi || first == sec - thi)
                    Console.WriteLine("Possible");
                else if (first * sec == thi || first == sec * thi)
                    Console.WriteLine("Possible");
                else if (first / sec == thi || first == sec / thi)
                    Console.WriteLine("Possible");
                else
                    Console.WriteLine("Impossible");
            }
        }

        public static void answer9()
        {
            //write your code here
            string[] words = Console.ReadLine().Split(' ');
            Console.WriteLine(words.Distinct().Count() != words.Count() ? "NO" : "YES");
        }


        public static void answer10()
        {
            //write your code here
            Console.WriteLine(Console.ReadLine().Contains("ss") ? "hiss" : "no hiss");
        }

        static void Main(string[] args)
        {
            
        }
    }
}
