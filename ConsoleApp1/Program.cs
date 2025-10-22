int num = 0;

Console.WriteLine("Schreib dein Zahl");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Zahl ist durch 2 teilbar");
}
else
{
    Console.WriteLine("Zahl ist NICHT durch 2 teilbar");
}