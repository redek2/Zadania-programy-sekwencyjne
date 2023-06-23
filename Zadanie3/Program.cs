using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = int.Parse(Console.ReadLine());

        int szerokosc = 1;
        int spacje = wysokosc - 1;

        for (int i = 0; i < wysokosc; i++)
        {
            // Rysuj spacje na początku wiersza
            for (int j = 0; j < spacje; j++)
            {
                Console.Write(" ");
            }

            // Rysuj znaki "+" w wierszu
            for (int j = 0; j < szerokosc; j++)
            {
                Console.Write("+");
            }

            Console.WriteLine();

            // Zmniejsz liczbę spacji i zwiększ szerokość dla kolejnego wiersza
            spacje--;
            szerokosc += 2;
        }
    }
}
