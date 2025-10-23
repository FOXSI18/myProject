Console.WriteLine("Enter some text... (\"quit \" to exit.)");
Console.WriteLine();

while (true)
{
    string? name = Console.ReadLine();

    if (name == "quit")
        break;

    name = name!.ToLower().Trim();
    string defName = name;
    string? reversedName = string.Empty;

    foreach (char c in name.Reverse())
    {
        reversedName += c;
    }

    Console.WriteLine();
    Console.WriteLine("\"{0}\" {2} \"{1}\"", reversedName, defName, reversedName == defName ? "==" : "!=");
    Console.WriteLine(reversedName == defName ? "[+] True" : "[-] False");
    Console.WriteLine("-------------------------");
}
