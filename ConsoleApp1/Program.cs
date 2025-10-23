int x = 0;
while (x < 10) // Make while condition == true
{
    Console.WriteLine(x);
    x++;
}



int y = 100;
do // Start minimum 1 time
{
    Console.WriteLine(y);
    y++;
}
while (y < 110);



for (int z = 40; z < 50; z++) // Initialisierung of variable - Condition - Change value of variable
{
    Console.WriteLine(z);
}


string[] colors = { "red", "yellow", "orange", "green", "blue", "purple" };
foreach (string color in colors)
{
    Console.WriteLine(color);
}