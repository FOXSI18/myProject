Console.WriteLine("Enter some text...");
string? name = Console.ReadLine();

string a = name ?? "its a null value";

Console.WriteLine(a);













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
