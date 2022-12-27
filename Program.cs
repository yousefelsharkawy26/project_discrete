using System;

namespace method_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FNumber, SNumber;
            string process;
            Console.Write("please Enter your frist Number : ");
            FNumber = int.Parse(Console.ReadLine());
            Console.Write("please Enter your second Number : ");
            SNumber = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the process :");
            process = (Console.ReadLine());
            if (process == "prime")
                prime_number(FNumber, SNumber);
            if (process == "perfect")
                perfect_number(FNumber, SNumber);
        }
        static void prime_number(int n1,int n2)
        {
            int etrator, box;
            if (n1 == 1)
                n1++;
            while (n1 <= n2)
            {
                box = 0;
                for (etrator = 2; n1 > etrator;etrator++)
                {
                    if (n1 % etrator == 0)
                    {
                        box = 1;
                        break;
                    }
                }
                if (box == 0)
                    Console.WriteLine(n1);
                n1++;
                
            }
            Console.WriteLine("_________________________________");
        }

        static void perfect_number(int n1, int n2)
        {
            int reminder, summetion = 0;
            for (int frist = n1;frist <= n2;frist++)
            {
                for (int etrator = 1; etrator <= frist /2; etrator++)
                {
                    reminder = frist % etrator;
                    if (reminder == 0)
                        summetion += etrator;
                }
                if (summetion == frist)
                    Console.WriteLine($"Number {frist} is Perfect number in range ");
                summetion = 0;
            }
        }

    }
}
