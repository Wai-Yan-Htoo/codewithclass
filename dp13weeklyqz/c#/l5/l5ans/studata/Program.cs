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
        }

        public static void answer6()
        {
            //write your code here
            
        }

        public static void answer7()
        {
            //write your code here
            
        }

        public static void answer8()
        {
            //write your code here
            
        }

        public static void answer9()
        {
            //write your code here
           
        }


        public static void answer10()
        {
            //write your code here
            
        }

        static void Main(string[] args)
        {
            
        }
    }
}
