internal class Program
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine()!);
        int Y = int.Parse(Console.ReadLine()!);

        if (X > 0 && Y > 0) Console.WriteLine("1");
        else if (X < 0 && Y > 0) Console.WriteLine("2");
        else if (X > 0 && Y < 0) Console.WriteLine("4");
        else if (X < 0 && Y < 0) Console.WriteLine("3");
    }
}
