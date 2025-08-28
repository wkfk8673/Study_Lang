using System;

class Program
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split();
        int A = int.Parse(str[0]);
        int B = int.Parse(str[1]);

        Console.WriteLine(A / B);
    }
}