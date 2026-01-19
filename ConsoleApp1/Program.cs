/* Fibonacci Reihe
 * 1. Länge eingeben
 * 2. For Schleife
 * 3. Ausgabe sollte sein: 0 1 1 2 3 5 8 13 21 34 55 ...
*/
class Programm
{
     void Main(string[] args)
    {
        Console.WriteLine("Enter length:");
        int length = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1, sum = 0;

        for (int i = 1; i < length; i++)
        {
            Console.WriteLine(sum);
            sum = a + b;
            a = b;
            b = sum;
        }

        a = 0;
        b = 1;
        sum = 0;

        Rekursion(a, b, length);
    }

    void Rekursion(int zahl1, int zahl2, int depth)
    {
        if (depth == 0)
            return;

        Console.WriteLine(zahl1);
        Rekursion(zahl2, zahl1 + zahl2, depth - 1);
    }
}