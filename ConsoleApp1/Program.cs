namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 + 2 = 5");
            Console.WriteLine(2 * 6);

            var a = 4;
            if (a == 5)
            {
                Console.WriteLine("If block");
            } else
            {
                a = 10;
            }

            Console.WriteLine(a);

            const int b = 15;

        }
    }
}