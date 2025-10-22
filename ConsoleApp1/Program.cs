Console.WriteLine("Wie alt bist du?");
byte age = Convert.ToByte(Console.ReadLine());

Console.WriteLine(age >= 18 ? "Du darfst rein." : "Du bist zu jung.");



//bool result = age >= 18;

//if (result)
//    Console.WriteLine("Du darfst rein.");
//else
//    Console.WriteLine("Du bist zu jung.");