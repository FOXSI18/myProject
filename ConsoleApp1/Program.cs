bool exit = false;
Console.WriteLine("Taschenrechner 2077");

while (true)
{
    Console.WriteLine("\nErste Zahl:");
    int num1 = Convert.ToInt32(Console.ReadLine()); // 1. Schritt num1
    Console.WriteLine("Zweite Zahl:");
    int num2 = Convert.ToInt32(Console.ReadLine()); // 2. Schritt num2

    Console.WriteLine("\nWählen Sie die Operation (+, -, * or /)");
    char operation = Convert.ToChar(Console.ReadLine()); // 3. Schritt operation
    int result = 0;

    switch (operation) //3.1 op
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
        default:
            Console.WriteLine("Unbekannt"); break;
    }
    Console.WriteLine("\n[RESULT] {0}\n", result); // 4. Schritt result
    Console.WriteLine("------------------------------------------");
    

    Console.WriteLine("\n[QUESTION] Was wollen Sie machen? 1: Weiterrechnen; 2: Neuanfang; 3: Ende;");
    byte option = Convert.ToByte(Console.ReadLine()); // 5. Schritt option

    // 5.1 option
    if (option == 1)
    {
        do
        {
            num1 = result; // 5.2 result -> num1

            Console.WriteLine("\nErste Zahl: {0}", num1);
            Console.WriteLine("Zweite Zahl:");
            int newNum = Convert.ToInt32(Console.ReadLine()); // 5.3 fragen newNum

            Console.WriteLine("\nWählen Sie die Operation (+, -, * or /)");
            char newOperation = Convert.ToChar(Console.ReadLine()); // 5.4 fragen newOperation

            switch (newOperation) // 5.5 switch Operationen
            {
                case '+': result = num1 + newNum; break;
                case '-': result = num1 - newNum; break;
                case '*': result = num1 * newNum; break;
                case '/':
                    {
                        result = num1 / newNum;
                        Console.WriteLine("Rest von Division: {0}", num1 % newNum);
                        break;
                    }
                default:
                    Console.WriteLine("Unbekannt"); break;
            }
            Console.WriteLine("\n[RESULT] {0}\n", result);
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("\n![QUESTION] 1: Weiterrechnen; 2: Neuanfang; 3: Ende;");
            byte newOption = Convert.ToByte(Console.ReadLine());

            if (newOption == 1)
                continue; // Weiterrechnen
            else if (newOption == 2)
                break; // Neuanfang
            else if (newOption == 3)
            {
                exit = true; // Ende Programm
                break;
            }
            else
                Console.WriteLine("[ERROR] Schreiben Sie bitte die richtige Operation (1-3).");
        }
        while (true); // Weiterrechnen
    }
    else if (option == 2) 
        continue; // Zurück zum Anfang
    else if (option == 3)
    {
        Console.WriteLine("Ende.");
        break; // Ende
    }
    else
        Console.WriteLine("[ERROR] Schreiben Sie bitte die richtige Operation (1-3).");

    if (exit)
    {
        Console.WriteLine("Ende.");
        break; // Ende von do-while
    }
}