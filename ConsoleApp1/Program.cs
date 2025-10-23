Console.WriteLine("Print dein text");
string? name = Console.ReadLine();
int len = name!.Length;
int qsum = 0;

Console.WriteLine("Text: {0} | Buchstaben: {1}", name, len);

for(int i = 1; i <= len; i++)
{
    Console.WriteLine("{0} + {1} = {2}", qsum, i, qsum + i);
    qsum += i;
}

Console.WriteLine("Die Quersumme: {0}", qsum);





//Console.WriteLine("Print dein Zahl");
//int num = Convert.ToInt32(Console.ReadLine());
//int i = 0;

//while (i <= num) // Make while condition == true
//{
//    if (i % 2 == 0)
//        Console.WriteLine(">>> {0} ist durch 2 teilbar.", i);
//    else
//        Console.WriteLine(i);

//    i++;
//}




//Console.WriteLine("Print dein Zahl");
//int num = Convert.ToInt32(Console.ReadLine());
//int i = 0;

//do
//{
//    if (i % 2 == 0)
//        Console.WriteLine(">>> {0} ist durch 2 teilbar.", i);
//    else
//        Console.WriteLine(i);

//    i++;
//}
//while (i <= num);



//string[] colors = { "red", "yellow", "orange", "green", "blue", "purple" }; // Array initialisierung
//foreach (string color in colors) // Variable init, that 1 color had (in every iteration 1 element of array)
//{
//    Console.WriteLine(color);
//}
