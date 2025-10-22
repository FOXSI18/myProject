int num_day = Convert.ToInt32(Console.ReadLine());
string day;

switch (num_day)
{
    case 1: day = "Januar"; break;
    case 2: day = "Februar"; break;
    case 3: day = "März"; break;
    case 4: day = "April"; break;
    case 5: day = "Mai"; break;
    case 6: day = "Juni"; break;
    case 7: day = "Juli"; break;
    case 8: day = "August"; break;
    case 9: day = "September"; break;
    case 10: day = "Oktober"; break;
    case 11: day = "November"; break;
    case 12: day = "Dezember"; break;
    default: day = "Unbekannt"; break;
 
}

Console.WriteLine(day);