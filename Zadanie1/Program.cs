using System;

class Program
{
    static bool CzyPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Pierwsze {n} liczb pierwszych:");

        int licznik = 0;
        int pierwsza = 2;

        while (licznik < n)
        {
            if (CzyPierwsza(pierwsza))
            {
                Console.WriteLine(pierwsza);
                licznik++;
            }

            pierwsza++;
        }
    }
}
