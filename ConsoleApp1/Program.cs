class Programm
{
    static void Main(string[] args)
    {
        int length;
        Console.WriteLine("Enter length:");
        length = Convert.ToInt32(Console.ReadLine());

        int first = 0;
        int second = 1;
        int third = 0;

        for (int i = 1; i < length; i++)
        {
            Console.WriteLine(third);
            third = first + second;
            first = second;
            second = third;
        }

    }
}