using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int proby = 0;
        int rozmiar = 0;

        while (proby < 3)
        {
            Console.Write("Podaj rozmiar rombu (nieparzysta liczba >= 3): ");
            if (int.TryParse(Console.ReadLine(), out rozmiar) && rozmiar >= 3 && rozmiar % 2 != 0)
            {
                romb(rozmiar);
                break;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość!");
                proby++;
            }
        }

        if (proby == 3)
        {
            Console.WriteLine("Przekroczono limit prób. Koniec programu.");
        }

        Console.ReadLine();
    }

    static void romb(int rozmiar)
    {
        Random random = new Random();
        List<char> borderChars = new List<char> { '#', '@', '|', '*' };
        List<char> innerChars = new List<char> { '.', ':', '-', '+' };

        int spacje = rozmiar / 2;
        int znaki = 1;

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < spacje; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < znaki; j++)
            {
                if (j == 0 || j == znaki - 1 || i == 0 || i == rozmiar - 1)
                {
                    Console.Write(borderChars[random.Next(borderChars.Count)]);
                }
                else
                {
                    Console.Write(innerChars[random.Next(innerChars.Count)]);
                }
            }

            Console.WriteLine();

            if (i < rozmiar / 2)
            {
                spacje--;
                znaki += 2;
            }
            else
            {
                spacje++;
                znaki -= 2;
            }
        }
    }
}
