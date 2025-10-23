for (int i = 1; i < 100; i *= 2)
{
    if (i < 50)
        continue;

    Console.WriteLine(i);
}