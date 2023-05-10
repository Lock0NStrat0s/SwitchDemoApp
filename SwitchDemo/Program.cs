
string firstName = "Mohammad";
int age = 43;

//switch (firstName.ToLower())
//{
//    case "mohammad":
//        Console.WriteLine("Hello Mohammad.");
//        break;
//    //case "tom":
//    case "tim" or "tom":
//        Console.WriteLine("Hello Tim or Tom.");
//        break;
//    default:
//        Console.WriteLine("I don't know you.");
//        break;
//}

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child.");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job.");
        break;
    case >= 66:
        Console.WriteLine("Retired or retiring?");
        break;
    default:
        Console.WriteLine("Age not in expected range.");
        break;  
}