using System;
using ExSnail;

class Program
{
    static void Main()
    {
        List<Snail> snails = new List<Snail>();

        for (int i = 0; i < 10; i++) 
        {
            snails.Add(new Snail(i));
        }

        Console.CursorVisible = false;


        Console.ForegroundColor = ConsoleColor.Blue;
        while (snails[0].vie > 0)
        {
            Console.Clear();
            foreach (Snail snail in snails)
            {
                Console.SetCursorPosition(snail.x, snail.y);
                Console.Write(snail.enVie);
                snail.Move();
            }
            Thread.Sleep(40);
        }

        foreach (Snail snail in snails)
        {
            Console.SetCursorPosition(snail.x, snail.y);
            Console.Write(snail.mort);
        }

        Console.ResetColor();
        Console.ReadKey();
    }
}