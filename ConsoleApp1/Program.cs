int age = 0;

Console.WriteLine("Print your age");
age = Convert.ToInt32(Console.ReadLine());

if (age < 10)
{
    Console.WriteLine("Baby");
}
else if (age >= 10 && age < 20)
{
    Console.WriteLine("Jugendlich");
}
else if (age >= 20 && age < 50)
{
    Console.WriteLine("Erwachsene");
}
else
{
    Console.WriteLine("Alt");
}