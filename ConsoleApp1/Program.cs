string? name;
int age = 0;

Console.WriteLine("Wie heißt du?");
name = Console.ReadLine();

Console.WriteLine("Wie alt bist du?");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hallo {0}, in 30 Jahren bist du {1} Jahre alt :(", name, age + 30);

// Output: Hallo {name}, in 30 Jahren bist du {age+30} Jahre alt :(