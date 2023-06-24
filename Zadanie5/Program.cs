using System;

class Program
{
    static void Main()
    {
        int x, n;

        do
        {
            Console.Write("Podaj liczbę naturalną x: ");
        } while (!int.TryParse(Console.ReadLine(), out x) || x < 0);

        do
        {
            Console.Write("Podaj liczbę całkowitą nieujemną n: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

        int wynik = Power(x, n);

        int oczekiwany = (int)Math.Pow(x, n);

        Console.WriteLine("Wynik otrzymany napisanym algorytmem: " + wynik);
        Console.WriteLine("Wynik prawidłowy: " + oczekiwany);

        if (wynik == oczekiwany)
        {
            Console.WriteLine("Wyniki są zgodne.");
        }
        else
        {
            Console.WriteLine("Wyniki są różne.");
        }

        Console.ReadKey();
    }

    static int Power(int x, int n)
    {
        int result = x;

        for (int i = 1; i < n; i++)
        {
            int temp = 0;

            for (int j = 0; j < result; j++)
            {
                temp += x;
            }

            result = temp;
        }

        return result;
    }
}
