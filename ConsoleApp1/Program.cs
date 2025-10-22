Console.WriteLine("Print one number");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 3 == 0 && num % 5 == 0)
    Console.WriteLine("FIZZBUZZ");
else if (num % 3 == 0)
    Console.WriteLine("FIZZ");
else if (num % 5 == 0)
    Console.WriteLine("BUZZ");
else
    Console.WriteLine(num);

 