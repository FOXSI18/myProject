Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter operation (+, -, * or /)");
char opr = Convert.ToChar(Console.ReadLine());

int result = 0;

switch (opr)
{
    case '+': result = num1 + num2; break;
    case '-': result = num1 - num2; break;
    case '*': result = num1 * num2; break;
    case '/': 
        {
            result = num1 / num2; 
            Console.WriteLine("Rest von Division: {0}", num1 % num2); 
            break;
        } 
    default: Console.WriteLine("Unbekannt"); break;
}

Console.WriteLine("Result: {0}", result);
