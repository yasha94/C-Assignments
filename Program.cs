using System;

namespace firstAssigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for input to use in array length
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            //create array size of input
            int[] arr = new int[arrayLength];
            //asks user to enter number to multiply by the arrray's indexses
            Console.WriteLine("Please enter numer to multiply index by: ");
            int numToMul = Convert.ToInt32(Console.ReadLine());
            //print's number of elements in array and the number to multiply by.
            Console.WriteLine("Num of elements: " + arrayLength);
            Console.WriteLine("Num to mul: " + numToMul);
            //for loop to multuply the selected number with each index in the Array
            for(int i = 0; i < arr.Length; i++){
                //side variable to store the multiplication between chosen num and index
                int n = numToMul * i;
                //prints result of mul
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
