using System;

namespace firstAssigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[arrayLength];

            Console.WriteLine("Please enter numer to multiply index by: ");
            int numToMul = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Num of elements: " + arrayLength);
            Console.WriteLine("Num to mul: " + numToMul);
            for(int i = 0; i < arr.Length; i++){

                int n = numToMul * i;
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
