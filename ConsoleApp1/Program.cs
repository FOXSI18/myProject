for(int i = 0; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("{0} FIZZBUZZ", i);
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("{0} FIZZ", i);
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("{0} BUZZ", i);
    }
    else
    {
        Console.WriteLine(i);
    }
}



