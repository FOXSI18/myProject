int age = 0;
Console.WriteLine("Wie alt bist du?");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: {0}", age);

age += 4;
Console.WriteLine(age);