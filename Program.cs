using System;


namespace Assignment_4_part3
{
    internal class Program
    {
        static void Main(string[] args)
            //FIBONNACCI SERIES
        {
            Console.WriteLine("First 10 Numbers in Fibonacci Sequence:");
            int n = 10;
            int[] fibonacci = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (i <= 1)
                {
                    fibonacci[i] = i;
                }
                else
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                Console.Write($"{fibonacci[i]} ");
            }

            Console.ReadLine();

        }
        }
    }


