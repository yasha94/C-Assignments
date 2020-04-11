using System;

namespace firstAssigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] matrix = new string[3][];
            matrix[0] = new string[3] { "main", "Up", "Sub"};
            matrix[1] = new string[3] { "Down", "Center", "Up" };
            matrix[2] = new string[3] { "Sub", "Down", "Main"};

            Console.WriteLine(" _ _ _ _ _ _ _ _ _ ");
            Console.WriteLine("| " + matrix[0][0] + "|" + matrix[0][1] + "    |" + matrix[0][2] + " |");
            Console.WriteLine("| " + matrix[1][0] + "|" + matrix[1][1] + "|" + matrix[1][2] + "  |");
            Console.WriteLine("| " + matrix[2][0] + " |" + matrix[2][1] + "  |" + matrix[2][2] + "|");
            Console.Write(" _ _ _ _ _ _ _ _ _ ");

            Console.ReadKey();
        }

    }
}
