using System;

class Program
{
    static void Main()
    {
        Console.SetCursorPosition(1,15);
        Console.ForegroundColor = ConsoleColor.Blue;   
        Console.WriteLine("_@_ö");
        int vies = 1000;
        for (int i = 0; i < 1000; i++)
        {
            Console.Clear();
            Console.SetCursorPosition(i, 15);
            Console.WriteLine("_@_ö");
            vies -= 1;
            Thread.Sleep(125);
            if (vies == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(i, 15);
                Console.WriteLine("____");
            }
        }
        Console.ResetColor();
    }
}