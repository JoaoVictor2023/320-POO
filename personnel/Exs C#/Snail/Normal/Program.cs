using System;

class Program
{
    static void Main()
    {
        Console.SetCursorPosition(1,15);
        Console.ForegroundColor = ConsoleColor.Blue;   
        Console.WriteLine("_@_ö");
        int vie = 50;
        Console.CursorVisible = false;
        for (int i = 0; i < 50; i++)
        {
            Console.Clear();
            Console.SetCursorPosition(i, 15);
            Console.WriteLine("_@_ö");
            vie -= 1;
            Thread.Sleep(125);
            if (vie == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(i, 15);
                Console.WriteLine("____");
            }
        }
        Console.ResetColor();
        Console.ReadKey();
    }
}